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

            /* Establecer la fecha actual en el primer DateTimePicker
            dtpFechaDesde.Value = DateTime.Today;

            // Establecer la fecha un mes después en el segundo DateTimePicker
            dtpFechaHasta.Value = DateTime.Today.AddMonths(1);

            dtpFechaDesde.MinDate = DateTime.Today;
            dtpFechaHasta.MinDate = DateTime.Today;

            cbxHoraDesde.SelectedIndex = 0;
            cbxHoraHasta.SelectedIndex = 23;*/

            CargarDatosEspecialista();

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
        }
    }
}
