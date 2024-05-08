using MySql.Data.MySqlClient;
using Clinica.Datos;
using Clinica.Entidades;
 
using System.Data;
 

namespace Clinica
{
    

    internal class Clinica
    {
        public static List<KeyValuePair<int, string>>? ObtenerPacientes()
        {
      
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select id, Nombre, Apellido, DNI from Paciente;";
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    List<KeyValuePair<int, string>> pacientes = new();

                    while (reader.Read())
                    {
                        // Obtener el ID y el nombre de la cobertura
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        string dni = reader.GetString(3);

                        string descripcion = $"{nombre} {apellido} - {dni}";

                        // Crear un objeto de KeyValuePair con el ID y el nombre de la cobertura
                        KeyValuePair<int, string> paciente = new(id, descripcion);
                        pacientes.Add(paciente);

                    }
                    return pacientes;
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

        public static string? ObtenerCobertura(int idPaciente)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select Cobertura.Nombre from Cobertura " +
                    "inner join Paciente on Paciente.Cobertura_id = Cobertura.id " +
                    $"where Paciente.id = {idPaciente};";
                
                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    return reader.GetString(0);
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

        public static int? ObtenerMonto(int idEstudio, int idPaciente)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select CoberturaEstudio.Monto from CoberturaEstudio " +
                    "inner join Paciente on Paciente.Cobertura_id = CoberturaEstudio.Cobertura_id " +
                    $"where Paciente.id = {idPaciente} and CoberturaEstudio.Estudio_id = {idEstudio};";

                MySqlCommand comando = new(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    return reader.GetInt32(0);
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
