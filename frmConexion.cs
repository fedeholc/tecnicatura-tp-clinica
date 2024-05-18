using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using Clinica.Datos;
using MySql.Data.MySqlClient;
using clinica;

namespace Clinica
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                Datos.Conexion.baseDatos = txtBD.Text;
                Datos.Conexion.clave = txtPasswordBD.Text;
                Datos.Conexion.usuario = txtUsuarioBD.Text;
                Datos.Conexion.servidor = txtServidor.Text;
                Datos.Conexion.puerto = txtPuerto.Text;

                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();
                MessageBox.Show("Conexión a la Base de Datos exitosa", "MENSAJES DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin Login = new frmLogin();
                Login.Show();
                this.Hide();
            }

            catch (Exception ex)
            {
                // throw; 
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.ToString(), "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}