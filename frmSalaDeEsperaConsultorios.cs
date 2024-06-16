using clinica.Entidades;
using Clinica.Datos;
using Clinica.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace clinica
{
    public partial class frmSalaDeEsperaConsultorios : Form
    {


        public frmSalaDeEsperaConsultorios()
        {
            InitializeComponent();

        }

        private void frmSalaDeEsperaConsultorios_Load(object sender, EventArgs e)
        {
            CargarSalas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipalConsultorios frmMenuPrincipalConsultorios = new frmMenuPrincipalConsultorios();
            frmMenuPrincipalConsultorios.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CargarSalas()
        {
            CargarEsperaListView(lvwConTurno, 2);
            CargarEsperaListView(lvwSinTurno, 1);
            CargarEsperaListView(listView1, 3);
        }

        private void CargarEsperaListView(ListView lvw, int idAgenda)
        {
            lvw.Items.Clear();
            lvw.Columns.Clear();
            lvw.View = View.Details;

            // Agregar columnas al ListView
            lvw.Columns.Add("Fecha y Hora Acreditación");
            lvw.Columns.Add("Paciente");
            lvw.Columns.Add("Profesional");
            lvw.Columns.Add("Especialidad");
            lvw.Columns.Add("Prioridad");

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "SELECT sec.FechaHoraAcreditacion, p.Apellido, p.Nombre, pro.Apellido AS Profesional, " +
                    "pro.Especialidad AS Especialidad, sec.Prioridad FROM saladeesperaconsultorios as sec " +
                    "INNER JOIN paciente p ON sec.Paciente_id = p.id INNER JOIN profesional pro ON sec.Profesional_id = pro.Profesional_id " +
                    $"WHERE sec.idAgenda = {idAgenda} ORDER BY sec.Prioridad, sec.FechaHoraAcreditacion;";




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
                        string especialidad = reader.GetString(4);
                        int prioridad = reader.GetInt32(5);

                        string nombreyApellido = $"{pacienteApellido}, {pacienteNombre}";

                        string[] row = { fecha, nombreyApellido, profesional, especialidad, prioridad.ToString() };

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

