using clinica.Entidades;
using Clinica;
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
    public partial class frmAcreditacionConsultorios : Form
    {

        public frmAcreditacionConsultorios()
        {
            InitializeComponent();

        }



        public void CargarPacientes()
        {
            cbxPaciente.DataSource = null;
            cbxPaciente.Items.Clear();
            cbxPaciente.Text = "";
            cbxPaciente.DataSource = Clinica.Clinica.ObtenerPacientes();
            // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre y apellido )
            cbxPaciente.DisplayMember = "Value";
            cbxPaciente.SelectedIndex = -1;
        }


        private void CargarListaProfesionales()
        {
            cbxProfesionales.Items.Clear();
            cbxProfesionales.Text = "";


            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    string query = "SELECT Profesional_id, Nombre, Apellido FROM Profesional;";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);

                    sqlCon.Open();
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                     
                            int idProfesional = reader.GetInt32("Profesional_id");
                            string nombreProfesional = reader.GetString("Nombre");
                            string apellidoProfesional = reader.GetString("Apellido");
                            string nombre = $"{nombreProfesional}";
                            string apellido = $"{apellidoProfesional}";
                            cbxProfesionales.Items.Add(new KeyValuePair<int, string>(idProfesional, apellido));
                        }
                        //cbxProfesionales.DataSource = profesionales;
                        cbxProfesionales.DisplayMember = "Value";
                        cbxProfesionales.SelectedIndex = -1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void CargarTurnos(int idPaciente, int idProfesional)
        {
            lbxTurnos.DataSource = null;
            lbxTurnos.Items.Clear();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "select at.Id_Agendaturnos, at.Fecha, at.Hora, pro.Nombre, pro.apellido, pro.Especialidad " +
                    " from agendaturnos as at INNER JOIN PACIENTE AS P INNER JOIN profesional AS PRO on at.Paciente_id = p.id " +
                    $" and at.Profesional_id = pro.Profesional_id where at.Paciente_id = {idPaciente} and " +
                    $" pro.Profesional_id = {idProfesional} and at.TurnoStatus = 2;";

                   

                    sqlCon = Conexion.getInstancia().CrearConexion();
                    MySqlCommand comando = new(query, sqlCon)
                    {
                        CommandType = CommandType.Text
                    };
                    sqlCon.Open();

                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        List<KeyValuePair<int, string>> turnos = new();

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            DateTime fecha = reader.GetDateTime(1);
                            TimeSpan hora = reader.GetTimeSpan(2);
                            string nombreProfesional = reader.GetString(3);
                            string apellidoProfesional = reader.GetString(4);
                            string especialidad = reader.GetString(5);


                            string descripcionTurno = $"{fecha:dd/MM/yyyy} - {hora} - {nombreProfesional} " +
                                                      $"-  {apellidoProfesional} - {especialidad}";

                     

                            KeyValuePair<int, string> turno = new(id, descripcionTurno);
                            turnos.Add(turno);
                        }

                        lbxTurnos.DataSource = turnos;
                        lbxTurnos.DisplayMember = "Value";
                        lbxTurnos.SelectedIndex = 0;
                        lbxTurnos.Enabled = true;
                    }
                    else
                    {
                        lbxTurnos.DataSource = null;
                        lbxTurnos.Items.Clear();
                        lbxTurnos.Items.Add("No hay turnos disponibles con los criterios seleccionados.");
                        lbxTurnos.Enabled = false;
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




      

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente Inscripcion = new frmRegistroPaciente(this);

            Inscripcion.Show();
        }

        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            if (cbxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un paciente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxProfesionales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un profesional", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

       

        private void NuevaAcreditacion_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            cbxPaciente.SelectedIndex = -1;
            cbxProfesionales.SelectedIndex = -1;
            lbxTurnos.SelectedIndex = -1;
            lbxTurnos.DataSource = null;
            rbtNormal.Checked = true;

        }

        private void HabilitarCampos()
        {
            cbxPaciente.Enabled = true;
            cbxProfesionales.Enabled = true;
            lbxTurnos.Enabled = true;
            rbtNormal.Enabled = true;
            rbtUrgencia.Enabled = true;
            lbxTurnos.Enabled = true;
            btnAcreditar.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            cbxPaciente.Enabled = false;
            cbxProfesionales.Enabled = false;
            lbxTurnos.Enabled = false;
            rbtNormal.Enabled = false;
            rbtUrgencia.Enabled = false;
            lbxTurnos.Enabled = false;
            btnAcreditar.Enabled = false;
        }

        private void frmAcreditacionConsultorios_Load_1(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarListaProfesionales();
            CargarTurnos(0, 0);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipalConsultorios MenuPrincipal = new frmMenuPrincipalConsultorios();
            MenuPrincipal.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxProfesionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPaciente.SelectedIndex != -1 && cbxProfesionales.SelectedIndex != -1)
            {
                int idPaciente = ((KeyValuePair<int, string>)cbxPaciente.SelectedItem!).Key;
                int idProfesional = ((KeyValuePair<int, string>)cbxProfesionales.SelectedItem!).Key;

                CargarTurnos(idPaciente, idProfesional);


            }
        }
    }
}