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
        private Form formOrigen;
        public frmAcreditacionConsultorios(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }

        public frmAcreditacionConsultorios()
        {
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

        private void frmAcreditacionConsultorios_Load(object sender, EventArgs e)
        {
            cbxPaciente.SelectedIndex = -1;
            CargarPacientes();
            CargarListaProfesionales();
            CargarTurnos(0, 0);
        }

        public void CargarPacientes()
        {
            cbxPaciente.DataSource = null;
            cbxPaciente.Items.Clear();
            cbxPaciente.Text = "";

            cbxPaciente.DataSource = Clinica.Clinica.ObtenerPacientes();
            cbxPaciente.DisplayMember = "Value";
            cbxPaciente.SelectedIndex = -1;
        }

        private void CargarListaProfesionales()
        {
            cbxProfesionales.Items.Clear();
            cbxProfesionales.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT id, Nombre FROM Profesional;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> profesionales = new();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        KeyValuePair<int, string> profesional = new(id, nombre);
                        profesionales.Add(profesional);
                    }
                    cbxProfesionales.DataSource = profesionales;
                    cbxProfesionales.DisplayMember = "Value";
                    cbxProfesionales.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de profesionales.");
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
        public class ProfesionalesManager
        {
            public static DataTable ObtenerProfesionalesPorEspecialidad(string especialidad)
            {
                DataTable dataTable = new DataTable();
                MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();

                try
                {
                    string query = "SELECT * FROM profesional WHERE Especialidad LIKE @esp";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@esp", "%" + especialidad + "%");

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener profesionales: " + ex.Message);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }

                return dataTable;
            }
        }

        private void CargarLugares(int idEstudio)
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
                    $"from LugarDeAtencion inner join EstudioLugarDeAtencion " +
                    $"on EstudioLugarDeAtencion.LugarDeAtencion_id = LugarDeAtencion.id " +
                    $"inner join Estudio on EstudioLugarDeAtencion.Estudio_id = Estudio.id " +
                    $"where Estudio.id = {idEstudio};";

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
                    MessageBox.Show("No hay datos de Lugares");
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
        // Función para verificar la disponibilidad del profesional
        private bool VerificarDisponibilidadProfesional(int idProfesional, int idPaciente, DateTime fecha, TimeSpan hora)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM Turno " +
                               "WHERE Profesional_id = @ProfesionalId " +
                               "AND Paciente_id = @PacienteId " +
                               "AND Fecha = @Fecha " +
                               "AND Hora = @Hora " +
                               "AND TurnoStatus = @TurnoStatus";

                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                comando.Parameters.AddWithValue("@ProfesionalId", idProfesional);
                comando.Parameters.AddWithValue("@PacienteId", idPaciente);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@Hora", hora);
                comando.Parameters.AddWithValue("@TurnoStatus", (int)TurnoStatus.Disponible);
                sqlCon.Open();

                int count = Convert.ToInt32(comando.ExecuteScalar());

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        private void CargarTurnos(int idPaciente, int idEstudio)
        {
            lbxTurnos.DataSource = null;
            lbxTurnos.Items.Clear();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "select Turno.id, Turno.Fecha, Turno.Hora, Estudio.Descripcion, " +
                               "LugarDeAtencion.Descripcion,  TurnoStatus " +
                               "from Turno inner join lugardeatencion on Turno.LugarDeAtencion_id = Lugardeatencion.id " +
                               "inner join estudio on Turno.Estudio_id = estudio.id " +
                               $"where Turno.Paciente_id = {idPaciente} and Turno.Estudio_id = {idEstudio}";

                query += " ORDER BY Turno.Fecha, Turno.Hora;";

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
                        string estudioDescripcion = reader.GetString(3);
                        string lugarDescripcion = reader.GetString(4);
                        int turnoStatus = reader.GetInt32(5);

                        string turnoStatusDescripcion = turnoStatus == (int)TurnoStatus.Disponible ? "Disponible" : "Ocupado";

                        string descripcionTurno = $"{fecha:dd/MM/yyyy} - {hora} - {lugarDescripcion} " +
                                                  $"-  {estudioDescripcion} - {turnoStatusDescripcion}";

                        if (!VerificarDisponibilidadProfesional(idEstudio, idPaciente, fecha, hora))
                        {
                            descripcionTurno += " (Profesional no disponible)";
                        }

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

        private static Turno? ObtenerTurno(int idTurno)
        {


            MySqlConnection sqlCon = new MySqlConnection();
            try
            {


                string query = "select Turno.id, Turno.Fecha, Turno.Hora, Turno.LugarDeAtencion_id, " +
                    "Turno.Paciente_id, Turno.TurnoStatus, Turno.Estudio_id from Turno " +
                    $"where Turno. id = {idTurno}";


                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    Turno turno = new()
                    {
                        Id = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1),
                        Hora = reader.GetTimeSpan(2),
                        LugarDeAtencion_id = reader.GetInt32(3),
                        Paciente_id = reader.GetInt32(4),
                        TurnoStatus = reader.GetInt32(5),
                        Estudio_id = reader.GetInt32(6)
                    };

                    return turno;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }


        private int encontrarCbxIndex(int id, ComboBox cbx)
        {
            for (int i = 0; i < cbx.Items.Count; i++)
            {
                KeyValuePair<int, string> elemento = (KeyValuePair<int, string>)cbx.Items[i]!;
                if (elemento.Key == id)
                {
                    return i;
                }
            }
            return -1;
        }

        private void lbxTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTurnos.SelectedIndex != -1)
            {
                int idTurno = ((KeyValuePair<int, string>)lbxTurnos.SelectedItem!).Key;

                Turno? turnoSeleccionado = ObtenerTurno(idTurno);
                if (turnoSeleccionado != null)
                {
                    if (!VerificarDisponibilidadProfesional((int)turnoSeleccionado.Estudio_id!, (int)turnoSeleccionado.Paciente_id, (DateTime)turnoSeleccionado.Fecha, (TimeSpan)turnoSeleccionado.Hora))
                    {
                        MessageBox.Show("El profesional no puede atender al paciente en este horario. Por favor, seleccione otro turno.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CargarTurnos((int)turnoSeleccionado.Paciente_id, (int)turnoSeleccionado.Estudio_id!);
                        return;
                    }

                    cbxProfesionales.SelectedIndex = encontrarCbxIndex((int)turnoSeleccionado.Estudio_id!, cbxProfesionales);
                    cbxLugar.SelectedIndex = encontrarCbxIndex(turnoSeleccionado.LugarDeAtencion_id, cbxLugar);
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
            if (cbxLugar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un lugar de atención", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void HabilitarCampos1()
        {
            cbxPaciente.Enabled = true;
            cbxProfesionales.Enabled = true;
            cbxLugar.Enabled = true;
            lbxTurnos.Enabled = true;
            rbtNormal.Enabled = true;
            rbtUrgencia.Enabled = true;
            lbxTurnos.Enabled = true;
            btnAcreditar.Enabled = true;

        }

        private void NuevaAcreditacion_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            cbxPaciente.SelectedIndex = -1;
            cbxProfesionales.SelectedIndex = -1;
            cbxLugar.SelectedIndex = -1;
            lbxTurnos.SelectedIndex = -1;
            lbxTurnos.DataSource = null;
            rbtNormal.Checked = true;

        }

        private void HabilitarCampos()
        {
            throw new NotImplementedException();
        }

        private void DeshabilitarCampos()
        {
            cbxPaciente.Enabled = false;
            cbxProfesionales.Enabled = false;
            cbxLugar.Enabled = false;
            lbxTurnos.Enabled = false;
            rbtNormal.Enabled = false;
            rbtUrgencia.Enabled = false;
            lbxTurnos.Enabled = false;
            btnAcreditar.Enabled = false;
        }




    }
}