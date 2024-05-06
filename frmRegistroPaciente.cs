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

namespace Clinica
{
    public partial class frmRegistroPaciente : Form
    {
         
        public frmRegistroPaciente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();
            this.Hide();
        }
         

        private void RegistrarPaciente()
        {
            int? idCobertura = null;

            if (cbxCobertura.SelectedIndex != -1)
            {
                idCobertura = ((KeyValuePair<int, string>)cbxCobertura.SelectedItem!).Key;
            } else
            {
                MessageBox.Show("Debe elegir la cobertura entre las opciones disponibles.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ExistePaciente(txtDNI.Text))
            {
                MessageBox.Show("Ya existe un paciente registrado con DNI "+ txtDNI.Text, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombre.Text == "" || txtDNI.Text == "" || cbxCobertura.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int respuesta;
            Paciente paciente = new();
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.DNI = txtDNI.Text;
            paciente.Email = txtEmail.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Cobertura_id = idCobertura;
            paciente.HistoriaClinica = "Inscripto el día: " + DateTime.Now;
   
            respuesta = Clinica.RegistrarNuevoPaciente(paciente);
                          
            if (respuesta == 0)
            {
                MessageBox.Show("USUARIO YA EXISTE", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {           
                MessageBox.Show("Inscripción exitosa ","AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtDNI.Enabled = false;
            txtEmail.Enabled = false;
            txtNombre.Enabled = false;
             btnInscribir.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            cbxCobertura.Enabled = false;

          
        }
        private void activarCampos()
        {
            txtDNI.Enabled = true;
            txtEmail.Enabled = true;
            txtNombre.Enabled = true;
             btnInscribir.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            cbxCobertura.Enabled = true;

       
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
         


            RegistrarPaciente();
            
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


     
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla especial
            // Si no es un número ni una tecla especial, se cancela la pulsación
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            // Además, verifica si ya hay un punto o coma en la TextBox y, si es así, cancela la pulsación
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }



        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            cargarDatosCobertura();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                        // Obtener el ID y el nombre de la cobertura
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);

                        // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                        KeyValuePair<int, string> cobertura = new(id, nombre);
                       
                        coberturas.Add(cobertura);

                     
                    }
                    // Asignar la lista de coberturas al ComboBox
                    cbxCobertura.DataSource = coberturas;
                    // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
                    cbxCobertura.DisplayMember = "Value";
                    cbxCobertura.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de cobertura");
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
    }
}
