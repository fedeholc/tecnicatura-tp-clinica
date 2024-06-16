using Clinica.Datos;
using Clinica.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace clinica
{
    public partial class frmAtencionConsultorios : Form
    {
        private Form formOrigen;

        public frmAtencionConsultorios(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }

        private void frmAtencionConsultorios_Load(object sender, EventArgs e)
        {
            CargarProfesionalesSalaDeEspera();
            CargarEspera(-1);
            rtxtHistoriaClinica.Text = "";
            rtxtHistoriaClinica.Enabled = false;
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

        private void CargarProfesionalesSalaDeEspera()
        {
            cbxProfesionalSE.DataSource = null;
            cbxProfesionalSE.Items.Clear();
            cbxProfesionalSE.Text = "";
            cbxProfesionalSE.DataSource = Clinica.Clinica.ObtenerProfesionales();
            cbxProfesionalSE.DisplayMember = "Value";
            cbxProfesionalSE.SelectedIndex = -1;
        }

        private void cbxProfesionalSE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProfesionalSE.SelectedIndex != -1)
            {
                CargarEspera(((KeyValuePair<int, string>)cbxProfesionalSE.SelectedItem!).Key);
            }
        }

        private void CargarEspera(int idProfesional)
        {
            lbxEnEspera.DataSource = null;
            lbxEnEspera.Items.Clear();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                //Query para buscar en saladeesperaC
                string query = "SELECT sec.FechaHoraAcreditacion, sec.Paciente_id, sec.Profesional_id, p.Apellido, " +
                    " p.Nombre, sec.Prioridad " +
                    "FROM SalaDeEsperaconsultorios as sec " +
                    "INNER JOIN paciente p ON sec.Paciente_id = p.id " +
                    "INNER JOIN profesional pro ON sec.Profesional_id = pro.Profesional_id " +
                    $"WHERE sec.Profesional_id = {idProfesional} " +
                    "ORDER BY sec.Prioridad, sec.FechaHoraAcreditacion;";

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
                        string pacienteApellido = reader.GetString(3);
                        string pacienteNombre = reader.GetString(4);
                        int prioridad = reader.GetInt32(5);
                        string profesionalApellido = reader.GetString(2);


                        string esperaDescripcion = $"{pacienteApellido}, {pacienteNombre} - {fecha} - {prioridad}";
                        KeyValuePair<int, string> espera = new(pacienteId, esperaDescripcion);
                        esperas.Add(espera);
                    }
                    lbxEnEspera.DataSource = esperas;
                    lbxEnEspera.DisplayMember = "Value";
                    lbxEnEspera.SelectedIndex = 0;
                    lbxEnEspera.Enabled = true;
                    //Hasta acá cambio de lógica en saladeesperaC
                }
                else
                {
                    lbxEnEspera.DataSource = null;
                    lbxEnEspera.Items.Clear();
                    lbxEnEspera.Items.Add("No hay datos disponibles con los criterios seleccionados.");
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
                    rtxtHistoriaClinica.Text = "No hay historia clínica para este paciente.";
                }
            }
        }

        private void btnRegistrarAtencion_Click(object sender, EventArgs e)
        {
            int idPaciente = ((KeyValuePair<int, string>)lbxEnEspera.SelectedItem!).Key;
            int idProfesional = ((KeyValuePair<int, string>)cbxProfesionalSE.SelectedItem!).Key;

            string historiaClinica = rtxtHistoriaClinica.Text + "\n> Paciente atendido - " + DateTime.Now.ToString() + " - " + cbxProfesionalSE.Text + ".";
            int rtaHistoriaClinica = Clinica.Clinica.GuardarHistoriaClinica(idPaciente, historiaClinica);
            if (rtaHistoriaClinica < 1)
            {
                MessageBox.Show("Error al guardar la historia clínica del paciente.");
            }

            int rtaQuitarSala = QuitarDeSalaC(idPaciente, idProfesional);
            if (rtaQuitarSala > 0)
            {
                MessageBox.Show("Se registró la atención del Paciente y se lo quitó de la lista de espera.");
                CargarEspera(idProfesional);
            }
            else
            {
                MessageBox.Show("Error al registrar la atención del paciente.");
            }
        }

        private int QuitarDeSalaC(int idPaciente, int idProfesional)
        {
            int salida = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                string query = $"DELETE FROM SalaDeEsperaconsultorios WHERE Paciente_id = {idPaciente} AND Profesional_id = {idProfesional};";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                comando.Parameters.AddWithValue("@idProfesional", idProfesional);
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
            int idProfesional = ((KeyValuePair<int, string>)cbxProfesionalSE.SelectedItem!).Key;

            string historiaClinica = rtxtHistoriaClinica.Text + "\n> Paciente ausente - " + DateTime.Now.ToString() + " - " + cbxProfesionalSE.Text + ".";
            int rtaHistoriaClinica = Clinica.Clinica.GuardarHistoriaClinica(idPaciente, historiaClinica);
            if (rtaHistoriaClinica < 1)
            {
                MessageBox.Show("Error al guardar la historia clínica del paciente.");
            }

            int rtaQuitarSala = QuitarDeSalaC(idPaciente, idProfesional);
            if (rtaQuitarSala > 0)
            {
                MessageBox.Show("Se registró la ausencia del Paciente y se lo quitó de la lista de espera.");
                CargarEspera(idProfesional);
            }
            else
            {
                MessageBox.Show("Error al registrar la ausencia del paciente.");
            }
        }
    }
}


