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
        frmTurnosConsultorios Frm01;
        private string esp;
        private frmTurnosConsultorios turnos;


        public frmListadoProfesionales(string esp)
        {
            InitializeComponent();
            this.esp = esp;
            txtEspecialidad.Text = esp;
            turnos = new frmTurnosConsultorios();
            turnos.Show();

            dtgvProfesionales.SelectionChanged += dtgvProfesionales_SelectionChanged;
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



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTurnosConsultorios turnosConsultorios = new frmTurnosConsultorios();
            turnosConsultorios.Show();
        }

        private void dtgvProfesionales_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvProfesionales.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvProfesionales.SelectedRows[0];
                try
                {
                    string valor = (row.Cells[1].Value.ToString()) + " " + (row.Cells[2].Value.ToString()); 
                    string especialidad = (row.Cells[3].Value.ToString()); 
                    turnos.SetTextBoxValue(valor);// Defino el valor a mostrar en el TextBox Profesional
                    turnos.SetComboBoxValue(especialidad);// Defino el valor a mostrar en el ComboBox Especialidad
                    this.Close();
                    turnos.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el valor de la celda: " + ex.Message);
                }


            }


        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
