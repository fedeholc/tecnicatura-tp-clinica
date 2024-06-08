using Clinica.Datos;
using Clinica;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = true;
            cargarDatosUsuarios();
        }
        private void cargarDatosUsuarios()
        {
            cbxUsuarios.Items.Clear();
            cbxUsuarios.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select Nombre, Rol from Usuario;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbxUsuarios.Items.Add(reader.GetString(0));
                    }
                    cbxUsuarios.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No hay datos");
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
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = $"select Pass, Rol from Usuario where Nombre='{cbxUsuarios.Text}';";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        if (reader.GetString(0) == txtPass.Text)
                        {
                            MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            /*frmMenuPrincipal Principal = new frmMenuPrincipal();
                            
                            Principal.rol = Convert.ToString(reader.GetString(1));
                            Principal.usuario = cbxUsuarios.Text;*/
                            frmModulos Modulos = new frmModulos();
                            Modulos.rol = Convert.ToString(reader.GetString(1));
                            Modulos.usuario = cbxUsuarios.Text;
                            Modulos.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o password incorrecto", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
    }
}
