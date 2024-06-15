using MySql.Data.MySqlClient;
using Clinica.Datos;
using Clinica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clinica;

namespace Clinica
{
    public partial class frmRegistroPaciente : Form
    {
        private Form formOrigen;
        public frmRegistroPaciente(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }
        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            cargarDatosCobertura();
            btnImprimirComprobante.Enabled = false;
        }

        private void cargarDatosCobertura()
        {
            cbxCobertura.Items.Clear();
            cbxCobertura.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select id, Nombre from Cobertura;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> coberturas = new();

                    while (reader.Read())
                    {            
                        int id = reader.GetInt32(0);                           // Obtener el ID y el nombre de la cobertura
                        string nombre = reader.GetString(1);                
                        KeyValuePair<int, string> cobertura = new(id, nombre); // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                        coberturas.Add(cobertura);
                    }            
                    cbxCobertura.DataSource = coberturas;  // Asignar la lista de coberturas al ComboBox
                    cbxCobertura.DisplayMember = "Value";  // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
                    cbxCobertura.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de cobertura", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            RegistrarPaciente();
        }

        private void RegistrarPaciente()
        {
            int? idCobertura = null;

            if (cbxCobertura.SelectedIndex != -1)
            {
                idCobertura = ((KeyValuePair<int, string>)cbxCobertura.SelectedItem!).Key;
            }
            else
            {
                MessageBox.Show("Debe elegir la cobertura entre las opciones disponibles.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ExistePaciente(txtDNI.Text))
            {
                MessageBox.Show("Ya existe un paciente registrado con DNI " + txtDNI.Text, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDNI.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == ""
               || txtEmail.Text == "" || cbxCobertura.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpFechaNac.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser posterior a la fecha actual", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int respuesta;
            Paciente paciente = new();
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.FechaNac = dtpFechaNac.Value;
            paciente.DNI = txtDNI.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Email = txtEmail.Text;
            paciente.Cobertura_id = idCobertura;
            paciente.HistoriaClinica = "Inscripto el día: " + DateTime.Now;

            respuesta = Clinica.RegistrarNuevoPaciente(paciente);

            if (respuesta == 0)
            {
                MessageBox.Show("El usuario ya existe", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Inscripción exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                desactivarCampos();
            }
        }

        private bool ExistePaciente(string dni)
        {
            bool existe = false;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select DNI from Paciente where DNI = @DNI;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@DNI", dni);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return existe;
        }

        private void desactivarCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            dtpFechaNac.Enabled = false;
            txtDNI.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            cbxCobertura.Enabled = false;
            btnInscribir.Enabled = false;
            btnImprimirComprobante.Enabled = true;
        }

        private void btnNuevaInscripcion_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            cbxCobertura.SelectedIndex = -1;
            btnInscribir.Enabled = true;
            txtNombre.Focus();
            activarCampos();
        }
        private void activarCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dtpFechaNac.Enabled = true;
            txtDNI.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            cbxCobertura.Enabled = true;
            btnInscribir.Enabled = true;
        }

        private void validacionCampoDNI(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o tecla especial, si no es un número ni una tecla especial se cancela la pulsación
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' || e.KeyChar == ',') // Verifica si ya hay un punto o coma en la TextBox y, si es así, cancela la pulsación
            {
                e.Handled = true;
            }

            if (txtDNI.Text.Length > 8) //Se restringe el campo a un máximo de 8 cifras
            {
                txtDNI.Text = txtDNI.Text.Substring(0, 8);
                txtDNI.SelectionStart = 8;
            }
        }
        private void validacionCamposInt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) // Si no es un número o la tecla de retroceso, se ignora la pulsación
            {
                e.Handled = true;
            }
        }

        private void validacionCamposString(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back) // Si no es una letra, espacio ni la tecla de retroceso, se ignora la pulsación
            {
                e.Handled = true;
            }
        }

        private void btnImprimirComprobante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se envió el documento a la impresora local", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnImprimirComprobante.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formOrigen.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegistroPaciente_FormClosed(object sender, FormClosedEventArgs e) //Al cerrarse el formulario actualiza el listado de pacientes en el formulario
        {                                                                                 //de origen de la solicitud.
            if (formOrigen is frmTurnos formTurnos)
            {
                formTurnos.CargarPacientes();
            }
            if (formOrigen is frmAcreditacion frmAcreditacion)
            {
                frmAcreditacion.CargarPacientes();
            }
        }
    }
}
