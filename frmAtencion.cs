using Clinica.Datos;
using Clinica.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace clinica
{
    public partial class frmAtencion : Form
    {
        private Form formOrigen;
        public frmAtencion(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }

        private void frmAtencion_Load(object sender, EventArgs e)
        {
            CargarLugares();
            CargarEspera(-1);
            rtxtHistoriaClinica.Text = "";
            rtxtHistoriaClinica.Enabled = false;
            btnImprimirComprobante.Enabled = false;
        }

        private void CargarLugares()
        {
            cbxLugar.DataSource = null;
            cbxLugar.Items.Clear();
            cbxLugar.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select LugarDeAtencion.id, LugarDeAtencion.Descripcion " +
                    $"from LugarDeAtencion;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> lugares = new();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);
                        KeyValuePair<int, string> lugar = new(id, descripcion);
                        lugares.Add(lugar);
                    }
                    cbxLugar.DataSource = lugares;
                    cbxLugar.DisplayMember = "Value";
                    cbxLugar.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de lugares", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cbxLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLugar.SelectedIndex != -1)
            {
                CargarEspera(((KeyValuePair<int, string>)cbxLugar.SelectedItem!).Key);
            }
        }

        private void CargarEspera(int idLugar)
        {
            lbxEnEspera.DataSource = null;
            lbxEnEspera.Items.Clear();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {

                string query = "Select SalaDeEspera.FechaHoraAcreditacion, SalaDeEspera.Paciente_id, " +
                    "Paciente.Apellido, Paciente.Nombre, SalaDeEspera.Estudio_id, Estudio.Descripcion, " +
                    "SalaDeEspera.LugarDeAtencion_id, LugarDeAtencion.Descripcion, SalaDeEspera.Prioridad," +
                    "SalaDeEspera.id " +
                    "from saladeespera inner join Paciente on Paciente.id = SalaDeEspera.Paciente_id " +
                    "inner join LugarDeAtencion on lugardeatencion.id = saladeespera.LugarDeAtencion_id " +
                    "inner join Estudio on Estudio.id = saladeespera.Estudio_id " +
                    $"where saladeespera.LugarDeAtencion_id = {idLugar} ";

                query += " ORDER BY SalaDeEspera.Prioridad, SalaDeEspera.FechaHoraAcreditacion;";

                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> esperas = new();

                    while (reader.Read())
                    {
                        string fecha = reader.GetDateTime(0).ToString();
                        int pacienteId = reader.GetInt32(1);
                        string pacienteApellido = reader.GetString(2);
                        string pacienteNombre = reader.GetString(3);
                        string estudioDescripcion = reader.GetString(5);
                        string lugarDescripcion = reader.GetString(7);
                        int prioridad = reader.GetInt32(8);
                        int id = reader.GetInt32(9);

                        string esperaDescripcion = $"{pacienteApellido}, {pacienteNombre} - " +
                            $"{estudioDescripcion} - {fecha} - {prioridad}";

                        KeyValuePair<int, string> espera = new(pacienteId, esperaDescripcion);
                        esperas.Add(espera);
                    }
                    lbxEnEspera.DataSource = esperas;
                    lbxEnEspera.DisplayMember = "Value";
                    lbxEnEspera.SelectedIndex = 0;
                    lbxEnEspera.Enabled = true;
                }
                else
                {
                    lbxEnEspera.DataSource = null;
                    lbxEnEspera.Items.Clear();
                    lbxEnEspera.Items.Add("No hay datos disponibles con los criterios seleccionados");
                    lbxEnEspera.Enabled = false;
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

        private void lbxEnEspera_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtHistoriaClinica.Text = "";

            if (lbxEnEspera.SelectedIndex != -1)
            {
                KeyValuePair<int, string> espera = (KeyValuePair<int, string>)lbxEnEspera.SelectedItem!;
                int pacienteId = espera.Key;
                string? historiaClinica = Clinica.Clinica.ObtenerHistoriaClinica(pacienteId);
                if (historiaClinica != null)
                {
                    rtxtHistoriaClinica.Text = historiaClinica;
                    rtxtHistoriaClinica.Enabled = true;
                }
                else
                {
                    rtxtHistoriaClinica.Text = "No hay historia clínica para este paciente";
                }
            }
        }

        private void btnRegistrarAtencion_Click(object sender, EventArgs e)
        {
            int idPaciente = ((KeyValuePair<int, string>)lbxEnEspera.SelectedItem!).Key;
            int idLugar = ((KeyValuePair<int, string>)cbxLugar.SelectedItem!).Key;

            //guardar historia clínica
            string historiaClinica = rtxtHistoriaClinica.Text + "\n> Paciente atendido - " + DateTime.Now.ToString() + " - " + cbxLugar.Text + ".";
            int rtaHistoriaClinica = Clinica.Clinica.GuardarHistoriaClinica(idPaciente, historiaClinica);

            if (rtaHistoriaClinica < 1)
            {
                MessageBox.Show("Error al guardar la historia clínica del paciente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //quitar paciente de la sala
            int rtaQuitarSala = QuitarDeSala(idPaciente, idLugar);

            if (rtaQuitarSala > 0)
            {
                MessageBox.Show("Se registró la atención del paciente y se lo quitó de la lista de espera", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEspera(idLugar);
                btnImprimirComprobante.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al registrar la atención del paciente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int QuitarDeSala(int idPaciente, int idLugar)
        {
            int salida = 0;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = $"delete from SalaDeEspera where Paciente_id = {idPaciente} and LugarDeAtencion_id = {idLugar};";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                comando.Parameters.AddWithValue("@idLugar", idLugar);

                int rowsAffected = comando.ExecuteNonQuery();
                salida = rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }

        private void btnPacienteAusente_Click(object sender, EventArgs e)
        {
            int idPaciente = ((KeyValuePair<int, string>)lbxEnEspera.SelectedItem!).Key;
            int idLugar = ((KeyValuePair<int, string>)cbxLugar.SelectedItem!).Key;

            string historiaClinica = rtxtHistoriaClinica.Text + "\n> Paciente ausente - " + DateTime.Now.ToString() + " - " + cbxLugar.Text + ".";

            int rtaHistoriaClinica = Clinica.Clinica.GuardarHistoriaClinica(idPaciente, historiaClinica);
            
            if (rtaHistoriaClinica < 1)
            {
                MessageBox.Show("Error al guardar la historia clínica del paciente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int rtaQuitarSala = QuitarDeSala(idPaciente, idLugar);

            if (rtaQuitarSala > 0)
            {
                MessageBox.Show("Se registró la atención del paciente y se lo quitó de la lista de espera", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEspera(idLugar);
            }
            else
            {
                MessageBox.Show("Error al registrar la atención del paciente paciente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImprimirComprobante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se envió el documento a la impresora local", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnImprimirComprobante.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            formOrigen.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
