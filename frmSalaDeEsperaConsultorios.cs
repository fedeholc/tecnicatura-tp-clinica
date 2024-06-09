using Clinica.Datos;
using Clinica.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            CargarSalas();
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
            CargarEsperaListView(lvwConTurno, "Kinesiología");
            CargarEsperaListView(lvwSinTurno, "Salud Mental");
            CargarEsperaListView(listView1, "Otros");
        }

        private void CargarEsperaListView(ListView lvw, string categoria)
        {
            lvw.Items.Clear();
            lvw.Columns.Clear();
            lvw.View = View.Details;

            // Agregar columnas al ListView
            lvw.Columns.Add("Paciente");
            lvw.Columns.Add("Lugar de Atención");
            lvw.Columns.Add("Profesional");
            lvw.Columns.Add("Fecha y Hora Acreditación");
            lvw.Columns.Add("Prioridad");

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "SELECT se.FechaHoraAcreditacion, p.Apellido, p.Nombre, pro.Nombre AS Profesional, la.Descripcion AS LugarAtencion, se.Prioridad " +
                               "FROM saladeespera se " +
                               "INNER JOIN paciente p ON se.Paciente_id = p.id " +
                               "INNER JOIN lugardeatencion la ON se.LugarDeAtencion_id = la.id " +
                               "INNER JOIN profesional pro ON se.Paciente_id = pro.id_Matricula " +//Cambiar se.Paciente por se.id_Matricula
                               "INNER JOIN estudio e ON se.Estudio_id = e.id ";

                if (categoria == "Kinesiología")
                {
                    query += "WHERE pro.Especialidad = 'Kinesiología' ";
                }
                else if (categoria == "Salud Mental")
                {
                    query += "WHERE pro.Especialidad = 'Salud Mental' ";
                }
                else // Otros
                {
                    query += "WHERE pro.Especialidad NOT IN ('Kinesiología', 'Salud Mental') ";
                }

                query += "ORDER BY se.Prioridad, se.FechaHoraAcreditacion";

                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand(query, sqlCon)
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
                        string pacienteApellido = reader.GetString(1);
                        string pacienteNombre = reader.GetString(2);
                        string profesional = reader.GetString(3);
                        string lugarAtencion = reader.GetString(4);
                        int prioridad = reader.GetInt32(5);

                        string nombreyApellido = $"{pacienteApellido}, {pacienteNombre}";

                        string[] row = { nombreyApellido, lugarAtencion, profesional, fecha, prioridad.ToString() };

                        // Crear un ListViewItem con los valores de la fila actual
                        ListViewItem item = new ListViewItem(row);

                        // Agregar el ListViewItem al ListView
                        lvw.Items.Add(item);
                    }

                    lvw.Columns[0].Width = 120;
                    lvw.Columns[1].Width = 120;
                    lvw.Columns[2].Width = 180;
                    lvw.Columns[3].Width = 200;
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
            // Manejador de clic para la etiqueta (si es necesario)
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

