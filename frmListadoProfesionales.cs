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
    public partial class frmListadoProfesionales : Form
    {
        private string esp;


        public frmListadoProfesionales(string esp)
        {
            InitializeComponent();
            this.esp = esp;
        }

        private void pnlAcreditacion_Paint(object sender, PaintEventArgs e)
        {

        }





        private void dtgvProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListadoProfesionales_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }
        public void CargaGrilla()
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {

                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = ("select * from profesional where profesional.Especialidad like @esp");
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@esp", "%" + esp + "%");
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                dtgvProfesionales.Rows.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvProfesionales.Rows.Add();
                        dtgvProfesionales.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvProfesionales.Rows[renglon].Cells[1].Value = reader.GetString(2);
                        dtgvProfesionales.Rows[renglon].Cells[2].Value = reader.GetString(3);
                        dtgvProfesionales.Rows[renglon].Cells[3].Value = reader.GetString(5);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
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

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
