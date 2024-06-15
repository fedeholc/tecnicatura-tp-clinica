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
    public partial class frmSalaDeEspera : Form
    {
        private Form formOrigen;
        public frmSalaDeEspera(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }

        private void frmSalaDeEspera_Load(object sender, EventArgs e)
        {
            CargarEsperaListView(lvwConTurno, 1);
            CargarEsperaListView(lvwSinTurno, 0);
        }

        public void CargarSalas()
        {
            CargarEsperaListView(lvwConTurno, 1);
            CargarEsperaListView(lvwSinTurno, 0);
        }

        private void CargarEsperaListView(ListView lvw, int requiereTurno)
        {
            lvw.Items.Clear();
            lvw.Columns.Clear();

            lvw.View = View.Details;

            // Agregar columnas al ListView
            lvw.Columns.Add("Paciente");
            lvw.Columns.Add("Lugar");
            lvw.Columns.Add("Estudio");
            lvw.Columns.Add("Acreditación");
            lvw.Columns.Add("Prioridad");

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
                    $"where Estudio.RequiereTurno = {requiereTurno} ";

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
                        string pacienteApellido = reader.GetString(2);
                        string pacienteNombre = reader.GetString(3);
                        string estudioDescripcion = reader.GetString(5);
                        string lugarDescripcion = reader.GetString(7);
                        int prioridad = reader.GetInt32(8);
                        int id = reader.GetInt32(9);

                        string nombreyApellido = $"{pacienteApellido}, {pacienteNombre}";

                        string[] row = { nombreyApellido, lugarDescripcion, estudioDescripcion,  fecha, prioridad.ToString() };

                        // Crear un ListViewItem con los valores de la fila actual
                        ListViewItem item = new ListViewItem(row);

                        // Establecer el valor de la propiedad Tag del ListViewItem con el id
                        item.Tag = id;

                        // Agregar el ListViewItem al ListView
                        lvw.Items.Add(item);
                    }

                    lvw.Columns[0].Width = 120;
                    lvw.Columns[1].Width = 120;
                    lvw.Columns[2].Width = 180;
                    lvw.Columns[3].Width = 120;
                    lvw.Columns[4].Width = 70;
                }
                else
                {
                    /* lbxEnEspera.DataSource = null;
                     lbxEnEspera.Items.Clear();
                     lbxEnEspera.Items.Add("No hay datos disponibles con los criterios seleccionados.");
                     lbxEnEspera.Enabled = false;*/
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
