using Clinica;
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
    public partial class frmMenuPrincipalConsultorios : Form
    {
        public frmMenuPrincipalConsultorios()
        {
            InitializeComponent();
        }





        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnVolver_Click(object sender, EventArgs e, frmModulos Modulos)
        {
            this.Close();
            Modulos.Show();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente Inscripcion = new frmRegistroPaciente(this);

            Inscripcion.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmModulos Modulos = new frmModulos();
            Modulos.Show();
            this.Hide();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmTurnosConsultorios turnosConsultorios = new frmTurnosConsultorios();
            turnosConsultorios.Show();
            this.Hide();
        }

        private void btnAcreditacion_Click(object sender, EventArgs e)
        {
            frmAcreditacionConsultorios acreditacionConsultorios = new(this);
            acreditacionConsultorios.Show();
            this.Hide();
        }

        private void btnSalaDeEspera_Click(object sender, EventArgs e)
        {
            frmSalaDeEsperaConsultorios salaDeEsperaForm = new frmSalaDeEsperaConsultorios(this);
            salaDeEsperaForm.Show();
            this.Hide(); // Ocultar el formulario principal si es necesario
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmAtencionConsultorios
            using frmAtencion frm = new(this);

            // Mostrar el formulario
            frm.ShowDialog(); // Utiliza Show() si no necesitas bloquear el formulario principal
        }

    }
}
