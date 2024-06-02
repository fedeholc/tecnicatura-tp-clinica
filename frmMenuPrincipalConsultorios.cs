using clinica.Entidades;
using Clinica;
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
using MySql.Data.MySqlClient;
using System.IO.Packaging;
using Microsoft.EntityFrameworkCore;


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

      
            public void CrearTurno(int pacienteId, int profesionalId, DateTime fechaHora)
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

        /*public List<Turno> ListarTurnos()
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

