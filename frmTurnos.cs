using Clinica.Datos;
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
        public frmTurnos()
        {
            InitializeComponent();
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {

            // Establecer la fecha actual en el primer DateTimePicker
            dtpFechaDesde.Value = DateTime.Today;

            // Establecer la fecha un mes después en el segundo DateTimePicker
            dtpFechaHasta.Value = DateTime.Today.AddMonths(1);

            dtpFechaDesde.MinDate = DateTime.Today;
            dtpFechaHasta.MinDate = DateTime.Today;


            cargarDatosEstudios();
            //cargarTurnos();
        }
        private void cargarTurnos()
        {
            cbxTurnos.DataSource = null;
            cbxTurnos.Items.Clear();
            cbxTurnos.Text = "";

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

                /*
                select Turno.id, Turno.Fecha, Turno.Hora, Estudio.Descripcion, Turno.LugarDeAtencion_id, lugardeatencion.Descripcion,  TurnoStatus 
                from 
                Turno inner join lugardeatencion on Turno.LugarDeAtencion_id = lugardeatencion.id
                inner join estudio on lugardeatencion.Estudio_id = estudio.id
                ;
                */
                string query = "select id, Fecha, Hora, LugarDeAtencion_id, TurnoStatus from Turno;";

                string query2 = "select Turno.id, Turno.Fecha, Turno.Hora, Estudio.Descripcion, " +
                    "LugarDeAtencion.Descripcion,  TurnoStatus " +
                    "from Turno inner join lugardeatencion on Turno.LugarDeAtencion_id = Lugardeatencion.id " +
                    "inner join estudio on Lugardeatencion.Estudio_id = estudio.id";

                if (filtroEstudioId > 0)
                {
                    query2 += $" where estudio.id = {filtroEstudioId}";
                }


                query2 += $" and Turno.Fecha >= '{dtpFechaDesde.Value:yyyy-MM-dd}'";
                query2 += $" and Turno.Fecha <= '{dtpFechaHasta.Value:yyyy-MM-dd}'";

                if (cbxHoraDesde.SelectedIndex != -1)
                {
                    query2 += $" and Turno.Hora >= '{cbxHoraDesde.Text}'";
                }
                if (cbxHoraHasta.SelectedIndex != -1)
                {
                    query2 += $" and Turno.Hora <= '{cbxHoraHasta.Text}'";
                }




                query2 += ";";

                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new(query2, sqlCon)
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
                        // Obtener el ID y el nombre de la cobertura
                        int id = reader.GetInt32(0);
                        string fecha = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                        string hora = reader.GetTimeSpan(2).ToString();
                        string estudioDescripcion = reader.GetString(3);
                        string lugarDescripcion = reader.GetString(4);
                        string turnoStatus = reader.GetInt32(5).ToString();

                        string descripcionTurno = $"{fecha} - {hora} - {estudioDescripcion} - {lugarDescripcion} - {turnoStatus}";

                        // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                        KeyValuePair<int, string> turno = new(id, descripcionTurno);
                        turnos.Add(turno);

                    }
                    // Asignar la lista de coberturas al ComboBox
                    cbxTurnos.DataSource = turnos;
                    // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
                    cbxTurnos.DisplayMember = "Value";
                    cbxTurnos.SelectedIndex = -1;

                    lbxTurnos.DataSource = turnos;
                    lbxTurnos.DisplayMember = "Value";
                    lbxTurnos.SelectedIndex = -1;
                }
                else
                {
                    //MessageBox.Show("No hay datos de Turnos");
                    lbxTurnos.DataSource = null;
                    lbxTurnos.Items.Clear();
                    lbxTurnos.Items.Add("No hay turnos disponibles con los criterios seleccionados.");
                    // TODO: ojo, si se deja eso hay que evitar que se pueda elegir el turno
                    // Otra opción es dejar el ListBox vacío y oculto, y mostrar un mensaje en un Label
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
        private void cargarDatosEstudios()
        {
            cbxEstudios.Items.Clear();
            cbxEstudios.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select id, Descripcion from Estudio;";
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
                        // Obtener el ID y el nombre de la cobertura
                        int id = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);

                        // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                        KeyValuePair<int, string> estudio = new(id, descripcion);
                        estudios.Add(estudio);

                    }
                    // Asignar la lista de coberturas al ComboBox
                    cbxEstudios.DataSource = estudios;
                    // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
                    cbxEstudios.DisplayMember = "Value";
                    cbxEstudios.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de Estudios");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cbxEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTurnos();



        }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            /* int idEstudio = 0;

             if (cbxEstudios.SelectedIndex != -1)
             {
                 idEstudio = ((KeyValuePair<int, string>)cbxEstudios.SelectedItem!).Key;
             }
             else
             {
                 MessageBox.Show("Debe elegir un estudio entre las opciones disponibles.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }*/

            cargarTurnos();

        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaHasta.MinDate = dtpFechaDesde.Value;

            cargarTurnos();
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            cargarTurnos();

        }

        private void cbxHoraDesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTurnos();

        }

        private void cbxHoraHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTurnos();

        }
    }
}
