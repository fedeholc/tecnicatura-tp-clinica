using MySql.Data.MySqlClient;
using Clinica.Datos;
using Clinica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clinica.Clinica;

namespace Clinica
{
    //enumeración para cuando necesitamos distinguir entre socio y nosocio
    public enum TipoUsuarioClub
    {
       Socio = 0,
       NoSocio = 1
    }

    //enumeración para el método de pago
    public enum MetodoPago
    {
        Efectivo = 0,
        Tarjeta = 1
    }

    internal class Clinica
    {
        // query para traer la lista de socios con cuotas vencidas
        public static readonly string queryListadoVencidos = "select Nsocio, Nombre, DNI, IFNULL(MCuota, '') from (select socio.Nsocio, socio.Nombre, socio.DNI, max(cuotaSocio.Vencimiento) as MCuota from socio join cuotaSocio on socio.NSocio = cuotaSocio.NSocio  group by socio.Nsocio) t1 WHERE MCuota <= NOW();";

        // query para traer la lista de todos los socios
        public static readonly string queryListadoTodos = "select Nsocio, Nombre, DNI, IFNULL(MCuota, '') from (select socio.Nsocio, socio.Nombre, socio.DNI, max(cuotaSocio.Vencimiento) as MCuota from socio left join cuotaSocio on socio.NSocio = cuotaSocio.NSocio group by socio.Nsocio) t1;";

        //guarda la cuota en la base datos
        //cambia el nombre del procedure según se trato de un socio o de un nosocio
        //ya que se guarda en tablas distintas
        public static string CobrarCuota(E_Cuota cuota, TipoUsuarioClub tipoUsuario)
        {
            string? salida;
            string? nombreProcedure = "";

            if (tipoUsuario == TipoUsuarioClub.Socio)
            {
                nombreProcedure = "NuevaCuota";
            }
            else if (tipoUsuario == TipoUsuarioClub.NoSocio)
            {
                nombreProcedure = "NuevaCuotaDiaria";
            }

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(nombreProcedure, sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("inNSocio", MySqlDbType.Int32).Value = cuota.NSocio;
                comando.Parameters.Add("inMonto", MySqlDbType.Int32).Value = cuota.Monto;
                comando.Parameters.Add("inFechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                comando.Parameters.Add("inMetodoPago", MySqlDbType.Int32).Value = cuota.MetodoPago;
                comando.Parameters.Add("inFechaInicio", MySqlDbType.Date).Value = cuota.FechaInicio;
                comando.Parameters.Add("inVencimiento", MySqlDbType.Date).Value = cuota.Vencimiento;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                };
            }
            return salida ?? "error";
        }

        //guarda al nuevo socio/nosocio en la base datos
        //cambia el nombre del procedure según se trato de un socio o de un nosocio
        //ya que se guarda en tablas distintas
        public static string RegistrarUsuarioClub(E_UsuarioClub usuarioClub, TipoUsuarioClub tipoUsuario)
        {
            string? salida;
            string? nombreProcedure = "";

            if (tipoUsuario == TipoUsuarioClub.Socio)
            {
                nombreProcedure = "NuevoSocio";
            }
            else if (tipoUsuario == TipoUsuarioClub.NoSocio)
            {
                nombreProcedure = "NuevoNoSocio";
            }


            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(nombreProcedure, sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("inNombre", MySqlDbType.VarChar).Value = usuarioClub.Nombre;
                comando.Parameters.Add("inDNI", MySqlDbType.Int32).Value = usuarioClub.DNI;
                comando.Parameters.Add("inCorreo", MySqlDbType.VarChar).Value = usuarioClub.Correo;
                comando.Parameters.Add("inFechaInscripcion", MySqlDbType.Date).Value = usuarioClub.FechaInscripcion;
                comando.Parameters.Add("inAptoFisico", MySqlDbType.Bit).Value = usuarioClub.AptoFisico;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                };
            }
            return salida ?? "error";
        }

        public static int RegistrarNuevoPaciente(Paciente paciente)
        {
            ArgumentNullException.ThrowIfNull(paciente);

            int salida = 0;
            string? nombreTabla = "Paciente";
                    

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = $"INSERT INTO {nombreTabla} (Nombre, Apellido, DNI, Direccion, Email, Cobertura_id, " +
                    $"Historia_clinica) VALUES (@Nombre, @Apellido, @DNI, @Direccion, @Email, @Cobertura_id, @Historia_clinica)";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                comando.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                comando.Parameters.AddWithValue("@DNI", paciente.DNI);
                comando.Parameters.AddWithValue("@Direccion", paciente.Direccion);
                comando.Parameters.AddWithValue("@Email", paciente.Email);
                comando.Parameters.AddWithValue("@Cobertura_id", paciente.Cobertura_id);
                comando.Parameters.AddWithValue("@Historia_clinica", paciente.HistoriaClinica);
                
                //get query response
                int rowsAffected = comando.ExecuteNonQuery();
                salida = rowsAffected;
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                };
            }
            return salida;
        }
    }
}
