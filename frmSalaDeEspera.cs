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
    public partial class frmSalaDeEspera : Form
    {
        private Form formOrigen;
        public frmSalaDeEspera(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }
        private void frmSalaDeEspera_Load(object sender, EventArgs e)
        {

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
    }
}
