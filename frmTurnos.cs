﻿using Clinica;
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

namespace clinica
{
    public partial class frmTurnos : Form
    {
        private readonly Form formOrigen;
        public frmTurnos(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            // Establecer la fecha actual en el primer DateTimePicker
            dtpFechaDesde.Value = DateTime.Today;

            // Establecer la fecha un mes después en el segundo DateTimePicker
            dtpFechaHasta.Value = DateTime.Today.AddMonths(1);

            dtpFechaDesde.MinDate = DateTime.Today;
            dtpFechaHasta.MinDate = DateTime.Today;

            cbxHoraDesde.SelectedIndex = 0;
            cbxHoraHasta.SelectedIndex = 23;

            CargarDatosEstudios();
            CargarTurnos();
            CargarPacientes();
            btnImprimirComprobante.Enabled = false;
        }

        private void CargarDatosEstudios()
        {
            cbxEstudios.Items.Clear();
            cbxEstudios.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select id, Descripcion from Estudio where RequiereTurno = 1;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> estudios = new();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);
                        KeyValuePair<int, string> estudio = new(id, descripcion);
                        estudios.Add(estudio);

                    }
                    cbxEstudios.DataSource = estudios;
                    cbxEstudios.DisplayMember = "Value";
                    cbxEstudios.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No hay datos de estudios", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CargarTurnos()
        {
            lbxTurnos.DataSource = null;
            lbxTurnos.Items.Clear();
            int filtroEstudioId = 0;

            if (cbxEstudios.SelectedIndex != -1)
            {
                filtroEstudioId = ((KeyValuePair<int, string>)cbxEstudios.SelectedItem!).Key;
            }

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;

                string queryOcupados = "select Turno.id, Turno.Fecha, Turno.Hora, Estudio.Descripcion, " +
                    "LugarDeAtencion.Descripcion,  TurnoStatus " +
                    "from Turno inner join lugardeatencion on Turno.LugarDeAtencion_id = Lugardeatencion.id " +
                    "inner join estudio on Turno.Estudio_id = estudio.id";

                 string queryDisponibles = "select Turno.id, Turno.Fecha, Turno.Hora, Estudio.Descripcion, " +
                       "LugarDeAtencion.Descripcion,  TurnoStatus " +
                     "from Turno inner join lugardeatencion on Turno.LugarDeAtencion_id = Lugardeatencion.id " +
                     "inner join estudiolugardeatencion on estudiolugardeatencion.lugardeatencion_id = turno.LugarDeAtencion_id " +
                     "inner join estudio on estudio.id = estudiolugardeatencion.Estudio_id ";

                if (rbtDisponibles.Checked)
                {
                    query = queryDisponibles;
                }
                else
                {
                    query = queryOcupados;
                }

                query += $" where Turno.Fecha >= '{dtpFechaDesde.Value:yyyy-MM-dd}'";
                query += $" and Turno.Fecha <= '{dtpFechaHasta.Value:yyyy-MM-dd}'";

                if (cbxHoraDesde.SelectedIndex != -1)
                {
                    query += $" and Turno.Hora >= '{cbxHoraDesde.Text}'";
                }
                if (cbxHoraHasta.SelectedIndex != -1)
                {
                    query += $" and Turno.Hora <= '{cbxHoraHasta.Text}'";
                }

                if (filtroEstudioId > 0)
                {
                    query += $" and estudio.id = {filtroEstudioId}";
                }

                if (rbtDisponibles.Checked)
                {
                    query += $" and TurnoStatus = 1";
                }
                else
                {
                    query += $" and TurnoStatus = 2";
                }

                query += " ORDER BY Turno.Fecha, Turno.Hora;";

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
                    List<KeyValuePair<int, string>> turnos = new();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string fecha = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                        string hora = reader.GetTimeSpan(2).ToString();
                        string estudioDescripcion = reader.GetString(3);
                        string lugarDescripcion = reader.GetString(4);
                        int turnoStatus = reader.GetInt32(5);
                        string turnoStatusDescripcion = turnoStatus == (int)TurnoStatus.Disponible ? "Disponible" : "Ocupado";
                        string descripcionTurno = $"{fecha} - {hora} - {lugarDescripcion} -  {estudioDescripcion} - {turnoStatusDescripcion}";
                        KeyValuePair<int, string> turno = new(id, descripcionTurno);
                        turnos.Add(turno);
                    }
                    lbxTurnos.DataSource = turnos;
                    lbxTurnos.DisplayMember = "Value";
                    lbxTurnos.SelectedIndex = -1;
                    btnAsignar.Enabled = true;
                }
                else
                {
                    lbxTurnos.DataSource = null;
                    lbxTurnos.Items.Clear();
                    lbxTurnos.Items.Add("No hay turnos con los criterios seleccionados.");
                    btnAsignar.Enabled = false;
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

        public void CargarPacientes()
        {
            cbxPaciente.DataSource = null;
            cbxPaciente.Items.Clear();
            cbxPaciente.Text = "";
            cbxPaciente.DataSource = Clinica.Clinica.ObtenerPacientes();
            cbxPaciente.DisplayMember = "Value";
            cbxPaciente.SelectedIndex = -1;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (rbtOcupados.Checked)
            {
                MessageBox.Show("No se puede asignar un turno ya ocupado", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbxTurnos.SelectedIndex != -1 && cbxPaciente.SelectedIndex != -1 && cbxEstudios.SelectedIndex != -1)
            {
                int rta = AsignarTurno(((KeyValuePair<int, string>)cbxPaciente.SelectedItem!).Key,
                    ((KeyValuePair<int, string>)lbxTurnos.SelectedItem!).Key,
                    ((KeyValuePair<int, string>)cbxEstudios.SelectedItem!).Key);
                if (rta > 0)
                {
                    MessageBox.Show("Turno asignado correctamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTurnos();
                    btnImprimirComprobante.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al asignar el turno", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno, estudio y paciente para poder asignarle el turno", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int AsignarTurno(int idPaciente, int idTurno, int idEstudio)
        {
            int salida = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = "update Turno set TurnoStatus = 2, Paciente_id = @idPaciente, " +
                    "Estudio_id = @idEstudio where id = @idTurno;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idTurno", idTurno);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                comando.Parameters.AddWithValue("@idEstudio", idEstudio);

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (rbtDisponibles.Checked)
            {
                MessageBox.Show("No se puede cancelar un turno disponible", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbxTurnos.SelectedIndex != -1)
            {
                int rta = CancelarTurno(((KeyValuePair<int, string>)lbxTurnos.SelectedItem!).Key);
                if (rta > 0)
                {
                    MessageBox.Show("Turno cancelado correctamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTurnos();
                    btnImprimirComprobante.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al cancelar el turno", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno para cancelar", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CancelarTurno(int idTurno)
        {
            int salida = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                string query = "update Turno set TurnoStatus = 1, Estudio_id = null where id = @idTurno;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idTurno", idTurno);
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

        private void cbxEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTurnos();
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaHasta.MinDate = dtpFechaDesde.Value;  
            CargarTurnos();
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            CargarTurnos();
        }

        private void cbxHoraDesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTurnos();
        }

        private void cbxHoraHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTurnos();
        }

        private void rbtOcupados_CheckedChanged(object sender, EventArgs e)
        {
            CargarTurnos();
        }

        private void rbtDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            CargarTurnos();
        } 

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente Inscripcion = new frmRegistroPaciente(this);
            Inscripcion.Show();
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
