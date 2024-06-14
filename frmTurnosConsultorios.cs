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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace clinica
{
    public partial class frmTurnosConsultorios : Form
    {

        public frmTurnosConsultorios()
        {
            InitializeComponent();

        }

        
        private int AsignarTurno(int idPaciente, int idAgendaturno, int idProfesional)
        {
            int salida = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = "update agendaturnos set TurnoStatus = 2, Paciente_id = @idPaciente, " +
                    "Profesional_id = @idProfesional where Id_Agendaturnos = @idAgendaturno;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                comando.Parameters.AddWithValue("@idAgendaturno", idAgendaturno);
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
                };
            }
            return salida;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (rbtOcupados.Checked)
            {
                MessageBox.Show("No se puede asignar un turno ya ocupado.");
                return;
            }
            if (lbxAgendaTurnos.SelectedIndex != -1 && cbxPacientes.SelectedIndex != -1 && cbxProfesionales.SelectedIndex != -1)
            {
                int rta = AsignarTurno(((KeyValuePair<int, string>)cbxPacientes.SelectedItem!).Key,
                    ((KeyValuePair<int, string>)lbxAgendaTurnos.SelectedItem!).Key,
                    ((KeyValuePair<int, string>)cbxProfesionales.SelectedItem!).Key);
                if (rta > 0)
                {
                    MessageBox.Show("Turno Asignado correctamente.");
                    CargarAgendaTurnos();
                }
                else
                {
                    MessageBox.Show("Error al asignar el turno.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno, estudio y paciente para poder asignarle el turno.");
            }
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

                    string baseQuery = "SELECT a.Id_Agendaturnos, a.Fecha, a.Hora, p.Nombre, p.Apellido, p.Especialidad, a.TurnoStatus " +
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
                                int id = reader.GetInt32(0);
                                string fecha = reader.GetDateTime(1).ToString("dd/MM/yyyy");

                                string hora = reader.GetTimeSpan(2).ToString();

                                string Nombre = reader.GetString(3);
                                string Apellido = reader.GetString(4);
                                string Especialidad = reader.GetString(5);
                                int turnoStatus = reader.GetInt32(6);

                                string turnoStatusDescripcion = turnoStatus == 1 ? "Disponible" : "Ocupado";

                                string descripcionTurno = $"{fecha}-{hora}-{Nombre} {Apellido}-{Especialidad}-{turnoStatusDescripcion}";

                                // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                                KeyValuePair<int, string> turno = new KeyValuePair<int, string>(id, descripcionTurno);
                                //KeyValuePair<int, string> turno = new KeyValuePair<int, string>(fecha.GetHashCode() ^ hora.GetHashCode(), descripcionTurno);
                                turnos.Add(turno);
                            }
                            // Asignar la lista de coberturas al ComboBox
                            lbxAgendaTurnos.DataSource = turnos;
                            // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
                            lbxAgendaTurnos.DisplayMember = "Value";
                            //lbxAgendaTurnos.ValueMember = "Key";
                            lbxAgendaTurnos.SelectedIndex = -1;
                            btnAsignar.Enabled = true;
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

        private int CancelarTurno(int idAgendaTurno)
        {

            int salida = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                string query = "update Agendaturnos set TurnoStatus = 1, Paciente_id = null where id_Agendaturnos = @idAgendaTurno;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idAgendaTurno", idAgendaTurno);
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
                };
            }
            return salida;
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
        public void CargarProfesionalesPorEspecialidad(string especialidad)
        {
            cbxProfesionales.Items.Clear();
            cbxProfesionales.Text = "";

            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    string query = "SELECT Profesional_id, Nombre, Apellido FROM profesional WHERE Especialidad = @Especialidad";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@Especialidad", especialidad);
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
                            cbxProfesionales.Items.Add(new KeyValuePair<string, string>(nombre, apellido));

                            //cbxProfesionales.Items.Add(new KeyValuePair<int, string>(idProfesional,nombreProfesional));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los profesionales: " + ex.Message);
            }
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la especialidad seleccionada
            string especialidad = cbxEspecialidad.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(especialidad))
            {
                // Llamar al método para cargar los profesionales según la especialidad seleccionada
                CargarProfesionalesPorEspecialidad(especialidad);
            }
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


        public void SetComboBoxValueProfesionales(string value)
        {
            cbxProfesionales.Text = value.ToString();
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

     

        private void lblFechaDesde_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (rbtDisponibles.Checked)
            {
                MessageBox.Show("No se puede cancelar un turno disponible.");
                return;
            }
            if (lbxAgendaTurnos.SelectedIndex != -1)
            {
                int rta = CancelarTurno(((KeyValuePair<int, string>)lbxAgendaTurnos.SelectedItem!).Key);
                if (rta > 0)
                {
                    MessageBox.Show("Turno cancelado correctamente.");
                    CargarAgendaTurnos();
                }
                else
                {
                    MessageBox.Show("Error al cancelar el turno.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno para cancelar.");
            }
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente Inscripcion = new frmRegistroPaciente(this);
            Inscripcion.Show();
        }

        
    }
}