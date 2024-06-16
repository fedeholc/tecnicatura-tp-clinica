using clinica.Entidades;
using Clinica;
using Clinica.Datos;
using Clinica.Entidades;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace clinica
{
    public partial class frmAcreditacionConsultorios : Form
    {
        int salaDeEspera;

        public frmAcreditacionConsultorios()
        {
            InitializeComponent();

        }



        public void CargarPacientes()
        {
            cbxPaciente.DataSource = null;
            cbxPaciente.Items.Clear();
            cbxPaciente.Text = "";
            cbxPaciente.DataSource = Clinica.Clinica.ObtenerPacientes();
            cbxPaciente.DisplayMember = "Value";
            cbxPaciente.SelectedIndex = -1;
        }


        public void CargarProfesionales()
        {
            cbxProfesionales.DataSource = null;
            cbxProfesionales.Items.Clear();
            cbxProfesionales.Text = "";
            cbxProfesionales.DataSource = Clinica.Clinica.ObtenerProfesionales();
            cbxProfesionales.DisplayMember = "Value";
            cbxProfesionales.SelectedIndex = -1;
        }


        private void CargarTurnos(int idPaciente, int idProfesional)
        {
            lbxTurnos.DataSource = null;
            lbxTurnos.Items.Clear();
            lbxTurnos.DataSource = Clinica.Clinica.ObtenerTurnosC(idPaciente, idProfesional);
            lbxTurnos.DisplayMember = "Value";
            lbxTurnos.SelectedIndex = -1;
            lbxTurnos.Enabled = true;
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente Inscripcion = new frmRegistroPaciente(this);

            Inscripcion.Show();
        }

        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            if (cbxPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un paciente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxProfesionales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un profesional", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // acreditar para sala de espera
            int rtaSaladeEspera;
            SalaDeEsperaConsultorios salaDeEspera = new();
            salaDeEspera.Paciente_id = ((KeyValuePair<int, string>)cbxPaciente.SelectedItem!).Key;
            salaDeEspera.Profesional_id = ((KeyValuePair<int, string>)cbxProfesionales.SelectedItem!).Key;
            //salaDeEspera.idAgenda = Clinica.Clinica.ObteneridAgenda(((KeyValuePair<int, string>)cbxProfesionales.SelectedItem!).Key);
            salaDeEspera.FechaHoraAcreditacion = DateTime.Now;
            salaDeEspera.Prioridad = rbtUrgencia.Checked ? (int)Prioridad.Urgencia : (int)Prioridad.Normal;

            rtaSaladeEspera = Clinica.Clinica.RegistrarSalaDeEsperaC(salaDeEspera);
            if (rtaSaladeEspera == 0)
            {
                MessageBox.Show("Error al acreditar al paciente.", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Acreditación del paciente exitosa.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var formsSalas = Application.OpenForms.OfType<frmSalaDeEsperaConsultorios>().ToList();

            // Recorrer las instancias abiertas del form y actualizar datos
            foreach (var form in formsSalas)
            {
                form.CargarSalas();
            }
        }







        private void NuevaAcreditacion_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            cbxPaciente.SelectedIndex = -1;
            cbxProfesionales.SelectedIndex = -1;
            lbxTurnos.SelectedIndex = -1;
            lbxTurnos.DataSource = null;
            rbtNormal.Checked = true;

        }

        private void HabilitarCampos()
        {
            cbxPaciente.Enabled = true;
            cbxProfesionales.Enabled = true;
            lbxTurnos.Enabled = true;
            rbtNormal.Enabled = true;
            rbtUrgencia.Enabled = true;
            lbxTurnos.Enabled = true;
            btnAcreditar.Enabled = true;
        }

        private void DeshabilitarCampos()
        {
            cbxPaciente.Enabled = false;
            cbxProfesionales.Enabled = false;
            lbxTurnos.Enabled = false;
            rbtNormal.Enabled = false;
            rbtUrgencia.Enabled = false;
            lbxTurnos.Enabled = false;
            btnAcreditar.Enabled = false;
        }

        private void frmAcreditacionConsultorios_Load_1(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarProfesionales();
            CargarTurnos(0, 0);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuPrincipalConsultorios MenuPrincipal = new frmMenuPrincipalConsultorios();
            MenuPrincipal.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxProfesionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPaciente.SelectedIndex != -1 && cbxProfesionales.SelectedIndex != -1)
            {
                int idPaciente = ((KeyValuePair<int, string>)cbxPaciente.SelectedItem!).Key;
                int idProfesional = ((KeyValuePair<int, string>)cbxProfesionales.SelectedItem!).Key;
                //int idAgenda = 

                CargarTurnos(idPaciente, idProfesional);


            }
        }
    }
}