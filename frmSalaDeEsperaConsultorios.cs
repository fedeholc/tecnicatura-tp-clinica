using Clinica.Datos;
using Clinica.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace clinica
{
    public partial class frmSalaDeEsperaConsultorios : Form
    {
        private Form formOrigen;
        public frmSalaDeEsperaConsultorios(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }

        private void frmSalaDeEsperaConsultorios_Load(object sender, EventArgs e)
        {
            CargarEsperaListView(lvwConTurno, 1);
            CargarEsperaListView(lvwSinTurno, 0);
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
            lvw.Columns.Add("Profesional");
            lvw.Columns.Add("Acreditación");
            lvw.Columns.Add("Prioridad");

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "Select SalaDeEspera.FechaHoraAcreditacion, SalaDeEspera.Paciente_id, " +
                    "Paciente.Apellido, Paciente.Nombre, SalaDeEspera.Estudio_id, Estudio.Descripcion, " +
                    "from saladeespera inner join Paciente on Paciente.id = SalaDeEspera.Paciente_id " +
                    "inner join LugarDeAtencion on lugardeatencion.id = saladeespera.LugarDeAtencion_id " +
                    "inner join Profesional on Profesional.id = saladeespera.Profesional_id " +
                    $"where Estudio.RequiereTurno = {requiereTurno} " +
                    "ORDER BY SalaDeEspera.Prioridad, SalaDeEspera.FechaHoraAcreditacion;";

                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string fecha = reader.GetDateTime(0).ToString();
                        string pacienteApellido = reader.GetString(2);
                        string pacienteNombre = reader.GetString(3);
                        string profesional = reader.GetString(5);
                        string lugarDescripcion = reader.GetString(7);
                        int prioridad = reader.GetInt32(8);
                        int id = reader.GetInt32(9);

                        string nombreyApellido = $"{pacienteApellido}, {pacienteNombre}";

                        string[] row = { nombreyApellido, lugarDescripcion, profesional, fecha, prioridad.ToString() };

                        // Crear un ListViewItem con los valores de la fila actual
                        ListViewItem item = new ListViewItem(row)
                        {
                            Tag = id
                        };

                        // Agregar el ListViewItem al ListView
                        lvw.Items.Add(item);
                    }

                    lvw.Columns[0].Width = 120;
                    lvw.Columns[1].Width = 120;
                    lvw.Columns[2].Width = 180;
                    lvw.Columns[3].Width = 120;
                    lvw.Columns[4].Width = 70;
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

        private void lvwConTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para manejar el evento de selección en el ListView de con turno
            // Ejemplo: mostrar detalles del ítem seleccionado, etc.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
