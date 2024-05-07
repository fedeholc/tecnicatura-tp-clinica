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
