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

namespace clinica
{
    public partial class frmAcreditacion : Form
    {
        private Form formOrigen;
        public frmAcreditacion(Form formOrigen)
        {
            InitializeComponent();
            this.formOrigen = formOrigen;
        }

        private void frmAcreditacion_Load(object sender, EventArgs e)
        {
            cbxPaciente.SelectedIndex = -1;
            rbtEfectivo.Enabled = false;
            rbtTarjeta.Enabled = false;
            rbtAdeudado.Enabled = false;
            rbtPagado.Enabled = false;
            lblCoberturaPaciente.Enabled = false;
            lblMonto.Enabled = false;
            lblMedioPago.Enabled = false;
            lblRegistroPago.Enabled = false;
            btnImprimirComprobante.Enabled = false;


            CargarPacientes();
            CargarListaEstudios();
            CargarTurnos(0, 0);
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

        private void CargarListaEstudios()
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
                        int id = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);
                        KeyValuePair<int, string> estudio = new(id, descripcion);
                        estudios.Add(estudio);
                    }
                    cbxEstudios.DataSource = estudios;
                    cbxEstudios.DisplayMember = "Value";
                    cbxEstudios.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de Estudios", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CargarTurnos(int idPaciente, int idEstudio)
        {
            lbxTurnos.DataSource = null;
            lbxTurnos.Items.Clear();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "select Turno.id, Turno.Fecha, Turno.Hora, Estudio.Descripcion, " +
                    "LugarDeAtencion.Descripcion,  TurnoStatus " +
                    "from Turno inner join lugardeatencion on Turno.LugarDeAtencion_id = Lugardeatencion.id " +
                    $"inner join estudio on Turno.Estudio_id = estudio.id " +
                    $"where Turno.Paciente_id = {idPaciente} and Turno.Estudio_id = {idEstudio}";

                query += " ORDER BY Turno.Fecha, Turno.Hora;";

                sqlCon = Conexion.getInstancia().CrearConexion();
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
                        int id = reader.GetInt32(0);
                        string fecha = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                        string hora = reader.GetTimeSpan(2).ToString();
                        string estudioDescripcion = reader.GetString(3);
                        string lugarDescripcion = reader.GetString(4);
                        int turnoStatus = reader.GetInt32(5);
                        string turnoStatusDescripcion = turnoStatus == (int)TurnoStatus.Disponible ? "Disponible" : "Ocupado";

                        string descripcionTurno = $"{fecha} - {hora} - {lugarDescripcion} " +
                            $"-  {estudioDescripcion} - {turnoStatusDescripcion}";

                        KeyValuePair<int, string> turno = new(id, descripcionTurno);
                        turnos.Add(turno);
                    }
                    lbxTurnos.DataSource = turnos;
                    lbxTurnos.DisplayMember = "Value";
                    lbxTurnos.SelectedIndex = 0;
                    lbxTurnos.Enabled = true;
                }
                else
                {
                    lbxTurnos.DataSource = null;
                    lbxTurnos.Items.Clear();
                    lbxTurnos.Items.Add("No hay turnos con los criterios seleccionados.");
                    lbxTurnos.Enabled = false;
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

        private void CargarLugares(int idEstudio)
        {
            cbxLugar.DataSource = null;
            cbxLugar.Items.Clear();
            cbxLugar.Text = "";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select LugarDeAtencion.id, LugarDeAtencion.Descripcion " +
                    $"from LugarDeAtencion inner join EstudioLugarDeAtencion " +
                    $"on EstudioLugarDeAtencion.LugarDeAtencion_id = LugarDeAtencion.id " +
                    $"inner join Estudio on EstudioLugarDeAtencion.Estudio_id = Estudio.id " +
                    $"where Estudio.id = {idEstudio};";

                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> lugares = new();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string descripcion = reader.GetString(1);
                        KeyValuePair<int, string> lugar = new(id, descripcion);
                        lugares.Add(lugar);
                    }

                    cbxLugar.DataSource = lugares;
                    cbxLugar.DisplayMember = "Value";
                    cbxLugar.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay datos de lugares", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cbxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPaciente.SelectedIndex != -1)
            {
                lblCoberturaPaciente.Text = Clinica.Clinica.ObtenerCobertura(((KeyValuePair<int, string>)cbxPaciente.SelectedItem!).Key);
                lblCoberturaPaciente.Enabled = true;
            }
            else
            {
                lblCoberturaPaciente.Text = "";
            }
        }

        private void cbxEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtEfectivo.Enabled = false;
            rbtTarjeta.Enabled = false;
            rbtAdeudado.Enabled = false;
            rbtPagado.Enabled = false;
            lblMedioPago.Enabled = false;
            lblRegistroPago.Enabled = false;

            if (cbxEstudios.SelectedIndex != -1)
            {
                CargarLugares(((KeyValuePair<int, string>)cbxEstudios.SelectedItem!).Key);
            }
            if (cbxPaciente.SelectedIndex != -1 && cbxEstudios.SelectedIndex != -1)
            {
                int idPaciente = ((KeyValuePair<int, string>)cbxPaciente.SelectedItem!).Key;
                int idEstudio = ((KeyValuePair<int, string>)cbxEstudios.SelectedItem!).Key;

                CargarTurnos(idPaciente, idEstudio);

                int? monto = Clinica.Clinica.ObtenerMonto(idEstudio, idPaciente);

                if (monto != null)
                {
                    lblMonto.Text = monto.ToString();
                    lblMonto.Enabled = true;
                    if (monto > 0)
                    {
                        rbtEfectivo.Enabled = true;
                        rbtTarjeta.Enabled = true;
                        rbtAdeudado.Enabled = true;
                        rbtPagado.Enabled = true;
                        lblMedioPago.Enabled = true;
                        lblRegistroPago.Enabled = true;
                    }
                }
                else
                {
                    lblMonto.Text = "Sin datos";
                }
            }
        }

        private void lbxTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTurnos.SelectedIndex != -1)
            {
                int idTurno = ((KeyValuePair<int, string>)lbxTurnos.SelectedItem!).Key;

                if (ObtenerTurno(idTurno) != null)   
                {                                   
                    Turno turnoSeleccionado = ObtenerTurno(idTurno)!;
                    cbxEstudios.SelectedIndex = encontrarCbxIndex((int)turnoSeleccionado.Estudio_id!, cbxEstudios);
                    cbxLugar.SelectedIndex = encontrarCbxIndex(turnoSeleccionado.LugarDeAtencion_id, cbxLugar);
                }
            }
        }

        private static Turno? ObtenerTurno(int idTurno)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query = "select Turno.id, Turno.Fecha, Turno.Hora, Turno.LugarDeAtencion_id, " +
                    "Turno.Paciente_id, Turno.TurnoStatus, Turno.Estudio_id from Turno " +
                    $"where Turno. id = {idTurno}";

                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    Turno turno = new()
                    {
                        Id = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1),
                        Hora = reader.GetTimeSpan(2),
                        LugarDeAtencion_id = reader.GetInt32(3),
                        Paciente_id = reader.GetInt32(4),
                        TurnoStatus = reader.GetInt32(5),
                        Estudio_id = reader.GetInt32(6)
                    };
                    return turno;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private int encontrarCbxIndex(int id, ComboBox cbx)
        {
            for (int i = 0; i < cbx.Items.Count; i++)
            {
                KeyValuePair<int, string> elemento = (KeyValuePair<int, string>)cbx.Items[i]!;
                if (elemento.Key == id)
                {
                    return i;
                }
            }
            return -1;
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
            if (cbxEstudios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estudio", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxLugar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un lugar de atención", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // guardar datos de pago en factura
            int rtaFactura;
            Factura factura = new();
            factura.Paciente_id = ((KeyValuePair<int, string>)cbxPaciente.SelectedItem!).Key;
            factura.Estudio_id = ((KeyValuePair<int, string>)cbxEstudios.SelectedItem!).Key;
            factura.Cobertura_id = (int)Clinica.Clinica.ObtenerCoberturaId(factura.Paciente_id)!;
            float monto;
            if (float.TryParse(lblMonto.Text, out monto))
            {
                factura.Monto = monto;

                if (factura.Monto > 0)
                {
                    if (!rbtAdeudado.Checked && !rbtPagado.Checked)
                    {
                        MessageBox.Show("Debe seleccionar si se realizó el pago o " +
                            "si se registrará como adeudado", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (rbtPagado.Checked && !rbtEfectivo.Checked && !rbtTarjeta.Checked)
                    {
                        MessageBox.Show("Debe seleccionar el medio de pago", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (rbtEfectivo.Checked)
                    {
                        factura.MetodoPago = (int)MetodoPago.Efectivo;
                    }
                    else if (rbtTarjeta.Checked)
                    {
                        factura.MetodoPago = (int)MetodoPago.Tarjeta;
                    }
                    else
                    {
                        factura.MetodoPago = (int)MetodoPago.SinPago;
                    }
                    if (rbtPagado.Checked)
                    {
                        factura.FacturaStatus = (int)FacturaStatus.Pagada;
                    }
                    else if (rbtAdeudado.Checked)
                    {
                        factura.FacturaStatus = (int)FacturaStatus.Adeudada;
                    }
                    else
                    {
                        factura.FacturaStatus = (int)FacturaStatus.SinPago;
                    }
                }
                else if (factura.Monto <= 0)
                {
                    factura.MetodoPago = (int)MetodoPago.SinPago;
                    factura.FacturaStatus = (int)FacturaStatus.SinPago;
                }
            }
            else
            {
                MessageBox.Show("Falta el dato del monto del estudio. Avise al administrador del sistema",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rtaFactura = Clinica.Clinica.RegistrarFactura(factura);

            if (rtaFactura == 0)
            {
                MessageBox.Show("Error al registrar la factura", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DeshabilitarCampos();

            // acreditar para sala de espera
            int rtaSaladeEspera;
            SalaDeEspera salaDeEspera = new();
            salaDeEspera.Paciente_id = ((KeyValuePair<int, string>)cbxPaciente.SelectedItem!).Key;
            salaDeEspera.Estudio_id = ((KeyValuePair<int, string>)cbxEstudios.SelectedItem!).Key;
            salaDeEspera.LugarDeAtencion_id = ((KeyValuePair<int, string>)cbxLugar.SelectedItem!).Key;
            salaDeEspera.FechaHoraAcreditacion = DateTime.Now;
            salaDeEspera.Prioridad = rbtUrgencia.Checked ? (int)Prioridad.Urgencia : (int)Prioridad.Normal;

            rtaSaladeEspera = Clinica.Clinica.RegistrarSalaDeEspera(salaDeEspera);
            if (rtaSaladeEspera == 0)
            {
                MessageBox.Show("Error al acreditar al paciente.", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Acreditación del paciente exitosa.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnImprimirComprobante.Enabled = true;
            }

            var formsSalas = Application.OpenForms.OfType<frmSalaDeEspera>().ToList();

            // Recorrer las instancias abiertas del form y actualizar datos
            foreach (var form in formsSalas)
            {
                form.CargarSalas();
            }
        }

        private void DeshabilitarCampos()
        {
            cbxPaciente.Enabled = false;
            cbxEstudios.Enabled = false;
            cbxLugar.Enabled = false;
            lbxTurnos.Enabled = false;
            rbtEfectivo.Enabled = false;
            rbtTarjeta.Enabled = false;
            rbtAdeudado.Enabled = false;
            rbtPagado.Enabled = false;
            lblCoberturaPaciente.Enabled = false;
            lblMonto.Enabled = false;
            lblMedioPago.Enabled = false;
            lblRegistroPago.Enabled = false;
            rbtNormal.Enabled = false;
            rbtUrgencia.Enabled = false;
            lbxTurnos.Enabled = false;
            btnAcreditar.Enabled = false;
        }

        private void NuevaAcreditacion_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            cbxPaciente.SelectedIndex = -1;
            cbxEstudios.SelectedIndex = -1;
            cbxLugar.SelectedIndex = -1;
            lbxTurnos.SelectedIndex = -1;
            rbtEfectivo.Checked = false;
            rbtTarjeta.Checked = false;
            rbtAdeudado.Checked = false;
            rbtPagado.Checked = false;
            lblCoberturaPaciente.Text = "";
            lblMonto.Text = "";
            lbxTurnos.DataSource = null;
            rbtAdeudado.Enabled = false;
            rbtPagado.Enabled = false;
            rbtTarjeta.Enabled = false;
            rbtEfectivo.Enabled = false;
            rbtNormal.Checked = true;
        }

        private void HabilitarCampos()
        {
            cbxPaciente.Enabled = true;
            cbxEstudios.Enabled = true;
            cbxLugar.Enabled = true;
            lbxTurnos.Enabled = true;
            rbtEfectivo.Enabled = true;
            rbtTarjeta.Enabled = true;
            rbtAdeudado.Enabled = true;
            rbtPagado.Enabled = true;
            lblCoberturaPaciente.Enabled = true;
            lblMonto.Enabled = true;
            lblMedioPago.Enabled = true;
            lblRegistroPago.Enabled = true;
            rbtNormal.Enabled = true;
            rbtUrgencia.Enabled = true;
            lbxTurnos.Enabled = true;
            btnAcreditar.Enabled = true;
        }

        private void btnImprimirComprobante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se envió el documento a la impresora local", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnImprimirComprobante.Enabled = false;
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
