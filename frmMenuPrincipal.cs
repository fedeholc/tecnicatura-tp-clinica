using clinica;
using Clinica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        internal string? rol;
        internal string? usuario;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol +
            ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente Inscripcion = new frmRegistroPaciente(this);

            Inscripcion.Show();
            this.Hide();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmTurnos Turnos = new(this);

            Turnos.Show();
            this.Hide();
        }





        private void btnAcreditacion_Click(object sender, EventArgs e)
        {
            frmAcreditacion Acreditacion = new(this);

            Acreditacion.Show();
            this.Hide();
        }

        private void btnSalaDeEspera_Click(object sender, EventArgs e)
        {
            frmSalaDeEspera SalaDeEspera = new(this);
            SalaDeEspera.Show();

        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            frmAtencion Atencion = new(this);
            Atencion.Show();
            this.Hide();

        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmModulos Modulos = new frmModulos();
            Modulos.Show();
            this.Hide();
        }
    }

}
