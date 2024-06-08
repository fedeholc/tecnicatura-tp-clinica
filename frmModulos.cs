using Clinica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica
{
    public partial class frmModulos : Form
    {

        public frmModulos()
        {
            InitializeComponent();
        }
        internal string? rol;
        internal string? usuario;

        private void btnIngresarModulo_Click(object sender, EventArgs e)
        {
            if (rbtEstudiosClinic.Checked)
            {
                MessageBox.Show("Ha seleccionado Estudios Clínicos", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenuPrincipal Principal = new frmMenuPrincipal();
                Principal.rol = rol;
                Principal.usuario = usuario;
                Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ha seleccionado Consultorios Médicos", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenuPrincipalConsultorios PrincipalConsultorios = new frmMenuPrincipalConsultorios();
                PrincipalConsultorios.Show();
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
