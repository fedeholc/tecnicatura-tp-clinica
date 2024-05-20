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

        private void btnSeleccionarModulo_Click(object sender, EventArgs e)
        {
            if (rbtEstudiosClinic.Checked)
            {
                MessageBox.Show("Ha seleccionado Estudios Clìnicos");
                frmMenuPrincipal Principal = new frmMenuPrincipal();
                Principal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Ha seleccionado Consultorios Medicos");
                frmMenuPrincipal Principal = new frmMenuPrincipal();
                Principal.Show();
                this.Hide();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
