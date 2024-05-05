﻿using Clinica.Datos;
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
    public partial class frmTurnos : Form
    {
        public frmTurnos()
        {
            InitializeComponent();
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            cargarDatosEstudios();
            cargarTurnos();
        }
        private void cargarTurnos()
        {
            cbxTurnos.Items.Clear();
            cbxTurnos.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select id, Fecha, Hora, LugarDeAtencion_id, TurnoStatus from Turno;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> turnos = new();

                    while (reader.Read())
                    {
                        // Obtener el ID y el nombre de la cobertura
                        int id = reader.GetInt32(0);
                        string fecha = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                        string hora = reader.GetTimeSpan(2).ToString();
                        string lugarDeAtencion = reader.GetInt32(3).ToString();
                        string turnoStatus = reader.GetInt32(4).ToString();

                        string descripcionTurno = $"{fecha} - {hora} - {lugarDeAtencion} - {turnoStatus}";

                        // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                        KeyValuePair<int, string> turno = new(id, descripcionTurno);
                        turnos.Add(turno);

                    }
                    // Asignar la lista de coberturas al ComboBox
                    cbxTurnos.DataSource = turnos;
                    // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
                    cbxTurnos.DisplayMember = "Value";
                    cbxTurnos.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de Turnos");
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
        private void cargarDatosEstudios()
        {
            cbxEstudios.Items.Clear();
            cbxEstudios.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select id, Descripcion from Estudio;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> estudios = new();

                    while (reader.Read())
                    {
                        // Obtener el ID y el nombre de la cobertura
                        int id = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);

                        // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                        KeyValuePair<int, string> estudio = new(id, descripcion);
                        estudios.Add(estudio);

                    }
                    // Asignar la lista de coberturas al ComboBox
                    cbxEstudios.DataSource = estudios;
                    // Especificar qué propiedad del KeyValuePair se debe mostrar en el ComboBox (en este caso, el nombre)
                    cbxEstudios.DisplayMember = "Value";
                    cbxEstudios.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de Estudios");
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
