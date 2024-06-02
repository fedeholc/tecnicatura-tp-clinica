using Clinica;
using clinica;
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
using clinica.Entidades;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace clinica
{
    public partial class frmTurnosConsultorios : Form
    {

        public frmTurnosConsultorios()
        {
            InitializeComponent();

        }

        private void pnlTurnos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }

        private void frmTurnosConsultorios_Load(object sender, EventArgs e)
        {

            //Establecer la fecha actual en el primer DateTimePicker
            dtpFechaDesde.Value = DateTime.Today;

            // Establecer la fecha un mes después en el segundo DateTimePicker
            dtpFechaHasta.Value = DateTime.Today.AddMonths(1);

            dtpFechaDesde.MinDate = DateTime.Today;
            dtpFechaHasta.MinDate = DateTime.Today;

            cbxHoraDesde.SelectedIndex = 0;
            cbxHoraHasta.SelectedIndex = 23;

            CargarDatosEspecialista();
            CargarPacientes();
            CargarAgendaTurnos();

        }

        private void CargarAgendaTurnos()
        {
       
            lbxAgendaTurnos.DataSource = null;
            lbxAgendaTurnos.Items.Clear();

            //MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    StringBuilder queryBuilder = new StringBuilder();

                    string baseQuery = "SELECT a.Fecha, a.Hora, p.Nombre, p.Apellido, p.Especialidad, a.TurnoStatus " +
                                            "FROM `agendaturnos` as a " +
                                            "JOIN `profesional` AS p ON a.Profesional_id = P.Profesional_id";
                  

                    if (rbtDisponibles.Checked)
                    {
                        queryBuilder.Append(baseQuery);
                        queryBuilder.Append(" WHERE a.TurnoStatus = 1 ");
                    }
                    else
                    {
                        queryBuilder.Append(baseQuery);
                        queryBuilder.Append(" WHERE a.TurnoStatus = 2 ");
                    }
                    queryBuilder.Append(" and a.Fecha >= @FechaDesde and a.Fecha <= @FechaHasta ");
                    

                    if (cbxHoraDesde.SelectedIndex != -1)
                    {
                        queryBuilder.Append(" and a.Hora >= @HoraDesde");
                    }
                    if (cbxHoraHasta.SelectedIndex != -1)
                    {
                        queryBuilder.Append(" AND a.Hora <= @HoraHasta");
                    }
                    if (cbxEspecialidad.SelectedIndex != -1)
                    {
                        queryBuilder.Append(" and p.Especialidad = @Especialidad"); //o a.Especialidad
                    }
                    queryBuilder.Append(" ORDER BY a.Fecha, a.Hora");

                    MySqlCommand comando = new MySqlCommand(queryBuilder.ToString(), sqlCon)
                    {
                        CommandType = CommandType.Text
                    };

                    comando.Parameters.AddWithValue("@FechaDesde", dtpFechaDesde.Value.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@FechaHasta", dtpFechaHasta.Value.ToString("yyyy-MM-dd"));
                    if (cbxHoraDesde.SelectedIndex != -1)
                    {
                        comando.Parameters.AddWithValue("@HoraDesde", cbxHoraDesde.Text);
                    }
                    if (cbxHoraHasta.SelectedIndex != -1)
                    {
                        comando.Parameters.AddWithValue("@HoraHasta", cbxHoraHasta.Text);
                    }
                    if (cbxEspecialidad.SelectedIndex != -1)
                    {
                        comando.Parameters.AddWithValue("@Especialidad", cbxEspecialidad.SelectedItem.ToString());
                    }
                    sqlCon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            List<KeyValuePair<int, string>> turnos = new List<KeyValuePair<int, string>>();

                            while (reader.Read())
                            {
                                DateTime fecha = reader.GetDateTime(0);
                                TimeSpan hora = reader.GetTimeSpan(1);
                                string Nombre = reader.GetString(2);
                                string Apellido = reader.GetString(3);
                                string Especialidad = reader.GetString(4);
                                int turnoStatus = reader.GetInt32(5);

                                string turnoStatusDescripcion = turnoStatus == 1 ? "Disponible" : "Ocupado";

                                string descripcionTurno = $"{fecha:dd/MM/yyyy}-{hora}-{Nombre} {Apellido}-{Especialidad}-{turnoStatusDescripcion}";

                                // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                                KeyValuePair<int, string> turno = new KeyValuePair<int, string>(fecha.GetHashCode() ^ hora.GetHashCode(), descripcionTurno);
                                turnos.Add(turno);
                            }
                            // Asignar la lista de coberturas al ComboBox
                            lbxAgendaTurnos.DataSource = turnos;
                            // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
                            lbxAgendaTurnos.DisplayMember = "Value";
                            lbxAgendaTurnos.ValueMember = "Key";
                            lbxAgendaTurnos.SelectedIndex = -1;
                        }
                        else
                        {

                            lbxAgendaTurnos.Items.Add("No hay turnos disponibles con los criterios seleccionados.");
                            // TODO: ojo, si se deja eso hay que evitar que se pueda elegir el turno
                            // Otra opción es dejar el ListBox v

                        }


                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        

        private void CargarDatosEspecialista()
        {
            cbxEspecialidad.Items.Clear();
            cbxEspecialidad.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {

                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select distinct especialidad from profesional;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cbxEspecialidad.Items.Add(reader["especialidad"]);
                }


                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();

            }
        }
        public void CargarPacientes()
        {
            cbxPacientes.DataSource = null;
            cbxPacientes.Items.Clear();
            cbxPacientes.Text = "";
            // Asignar la lista de coberturas al ComboBox
            cbxPacientes.DataSource = Clinica.Clinica.ObtenerPacientes();
            // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
            cbxPacientes.DisplayMember = "Value";
            cbxPacientes.SelectedIndex = -1;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipalConsultorios MenuPrincipal = new frmMenuPrincipalConsultorios();
            MenuPrincipal.Show();


        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEspecialidad != null)
            {
                string esp = cbxEspecialidad.Text;
                this.Hide();
                frmListadoProfesionales profesionales = new frmListadoProfesionales(esp);
                profesionales.Show();
            }
            CargarAgendaTurnos();
        }
        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaHasta.MinDate = dtpFechaDesde.Value;

            CargarAgendaTurnos();
        }
        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            CargarAgendaTurnos();

        }


        public void SetTextBoxValue(string value)
        {
            txtProfesional.Text = value.ToString();
        }

        public void SetComboBoxValue(string value)
        {
            cbxEspecialidad.Text = value.ToString();
        }
        private void cbxHoraDesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarAgendaTurnos();

        }
        private void cbxHoraHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarAgendaTurnos();
        }

        private void rbtOcupados_CheckedChanged(object sender, EventArgs e)
        {
            CargarAgendaTurnos();
        }

        private void rbtDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            CargarAgendaTurnos();
        }

        private void lbxTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void cbxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProfesional_TextChanged(object sender, EventArgs e)
        {

        }
    }
}