using clinica.Entidades;
using Clinica;
using Clinica.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace clinica
{
    public partial class frmMenuPrincipalConsultorios : Form
    {
        public frmMenuPrincipalConsultorios()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "Usuario: " + usuario + " " + "(" + rol + ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmModulos Modulos = new frmModulos();
            Modulos.rol = rol;
            Modulos.usuario = usuario;
            Modulos.Show();
            this.Hide();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente Inscripcion = new frmRegistroPaciente(this);
            Inscripcion.Show();
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
            frmAcreditacionConsultorios acreditacionConsultorios = new frmAcreditacionConsultorios();
            acreditacionConsultorios.Show();
            this.Hide();
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            frmAtencionConsultorios acreditacionConsultorios = new frmAtencionConsultorios(this);
            acreditacionConsultorios.Show();
            this.Hide();
        }

        private void btnSalaDeEspera_Click(object sender, EventArgs e)
        {
            frmSalaDeEsperaConsultorios acreditacionConsultorios = new frmSalaDeEsperaConsultorios();
            acreditacionConsultorios.Show();
            this.Hide();
        }

        /*
         public void CrearTurno(int pacienteId, int profesionalId, DateTime fechaHora)   //este método es huérfano y creo que debería ir en la clase Turno, de implementarse.
        {
            using (var context = new ClinicaContext())
            {
                var turno = new AgendaTurnos
                {
                    PacienteId = pacienteId,
                    ProfesionalId = profesionalId,
                    FechaHora = fechaHora
                };

                context.AgendaTurnos.Add(turno);
                context.SaveChanges();
            }
        }
        */

        /*
         public List<Turno> ListarTurnos()         //Mismo comentario que arriba, pero este método ya estaba comentado.
        {
            using (var context = new ClinicaContext())
            {
                return context.AgendaTurnos
                    .Include(at => at.Paciente)
                    .Include(at => at.Profesional)
                    .ToList();
            }
        }*/
    }
}

