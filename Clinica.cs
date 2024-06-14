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
                    List<KeyValuePair<int, string>> pacientes = new(); //Se instancia una lista vacía de pacientes

                    while (reader.Read())
                    {                  
                        int id = reader.GetInt32(0);                    // Obtener los datos de los pacientes
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        string dni = reader.GetString(3);

                        string descripcion = $"{nombre} {apellido} - {dni}";
                   
                        KeyValuePair<int, string> paciente = new(id, descripcion); // Crear un objeto de KeyValuePair con el ID y los datos (string descripcion) de cada uno de los pacientes
                        pacientes.Add(paciente);                                   //Agrega cada uno de los pacientes al listado pacientes
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

        public static int? ObtenerCoberturaId(int idPaciente)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select Cobertura.Id from Cobertura " +
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

        public static string? ObtenerHistoriaClinica(int idPaciente)
        {

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select Paciente.Historia_clinica from Paciente " +
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

                string query = $"INSERT INTO {nombreTabla} (Nombre, Apellido, FechaNac, DNI, Telefono, Direccion, Email, Cobertura_id, " +
                    $"Historia_clinica) VALUES (@Nombre, @Apellido, @FechaNac, @DNI, @Telefono, @Direccion, @Email, @Cobertura_id, @Historia_clinica)";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                comando.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                comando.Parameters.AddWithValue("@FechaNac", paciente.FechaNac);
                comando.Parameters.AddWithValue("@DNI", paciente.DNI);
                comando.Parameters.AddWithValue("@Telefono", paciente.Telefono);
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
        public static int RegistrarFactura(Factura factura)
        {
            ArgumentNullException.ThrowIfNull(factura);

            int salida = 0;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = "INSERT INTO Factura (Estudio_id, Cobertura_id, Paciente_id, Monto, MetodoPago, FacturaStatus) " +
                    "VALUES (@Estudio_id, @Cobertura_id, @Paciente_id, @Monto, @MetodoPago, @FacturaStatus)";
                 MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@Estudio_id", factura.Estudio_id);
                comando.Parameters.AddWithValue("@Cobertura_id", factura.Cobertura_id);
                comando.Parameters.AddWithValue("@Paciente_id", factura.Paciente_id);
                comando.Parameters.AddWithValue("@Monto", factura.Monto);
                comando.Parameters.AddWithValue("@MetodoPago", factura.MetodoPago);
                comando.Parameters.AddWithValue("@FacturaStatus", factura.FacturaStatus);

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
        public static int RegistrarSalaDeEspera(SalaDeEspera sala)
        {
            ArgumentNullException.ThrowIfNull(sala);

            int salida = 0;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = "INSERT INTO SalaDeEspera (FechaHoraAcreditacion, Paciente_id, Estudio_id, LugarDeAtencion_id, Prioridad)  " +
                    "VALUES (@FechaHoraAcreditacion, @Paciente_id, @Estudio_id, @LugarDeAtencion_id, @Prioridad)";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@FechaHoraAcreditacion", sala.FechaHoraAcreditacion);
                comando.Parameters.AddWithValue("@Paciente_id", sala.Paciente_id);
                comando.Parameters.AddWithValue("@Estudio_id", sala.Estudio_id);
                comando.Parameters.AddWithValue("@LugarDeAtencion_id", sala.LugarDeAtencion_id);
                comando.Parameters.AddWithValue("@Prioridad", sala.Prioridad);


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
        public static int GuardarHistoriaClinica(int idPaciente, string historiaClinica)
        {
            ArgumentNullException.ThrowIfNull(idPaciente);
            ArgumentNullException.ThrowIfNull(historiaClinica);


            int salida = 0;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = "UPDATE Paciente set Paciente.Historia_clinica = @historiaClinica where Paciente.id = @idPaciente;";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@historiaClinica", historiaClinica);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente); 


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
