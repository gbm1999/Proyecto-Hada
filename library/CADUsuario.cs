using System;
using System.Configuration;
using System.Data.SqlClient;


namespace library
{
    public class CADUsuario
    {
        private string connection;
        private SqlConnection connectBD;
        public CADUsuario()
        {
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            connectBD = new SqlConnection(connection);
        }
        //Inserta un usuario en la BD
        public bool createUsuario(ENUsuario usu)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Usuario(Nif,Nombre,Email,Telefono,Admin,Edad,Contrasena) VALUES ('" + usu.NIFUsuario + "', '" + usu.nombreUsuario + "', '" + usu.emailUsuario + "', '" + usu.telefonoUsuario + "', '" + usu.adminUsuario + "', '" + usu.edadUsuario + "', '" + usu.contrasenaUsuario + "')", connectBD);
                command.ExecuteNonQuery();
                entra = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
        //Busca un usuario en la BD
        public bool readUsuario(ENUsuario usu)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Usuario", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (!entra && dataReader.Read())
                {
                    if (dataReader["Nif"].ToString().Equals(usu.NIFUsuario))
                    {
                        usu.NIFUsuario = dataReader["Nif"].ToString();
                        usu.nombreUsuario = dataReader["Nombre"].ToString();
                        usu.emailUsuario = dataReader["Email"].ToString();
                        usu.telefonoUsuario = (int)dataReader["Telefono"];
                        usu.adminUsuario = (bool)dataReader["Admin"];
                        usu.edadUsuario = (int)dataReader["Edad"];
                        usu.contrasenaUsuario = dataReader["Contrasena"].ToString();
                        usu.tarjetaUsuario = (int)dataReader["TarjetaCred"];
                        entra = true;
                    }
                }
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
        //Actualiza un usuario en la BD
        public bool updateUsuario(ENUsuario usu)
        {
            int response = 0;
            SqlDataReader dataReader = null;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("UPDATE Usuarios SET nombre = @nombre, edad = @edad where nif = @nif", connectBD);
                command.Parameters.AddWithValue("@Nif", usu.NIFUsuario);
                command.Parameters.AddWithValue("@Nombre", usu.nombreUsuario);
                command.Parameters.AddWithValue("@Email", usu.emailUsuario);
                command.Parameters.AddWithValue("@Telefono", usu.telefonoUsuario);
                command.Parameters.AddWithValue("@Admin", usu.adminUsuario);
                command.Parameters.AddWithValue("@Edad", usu.edadUsuario);
                command.Parameters.AddWithValue("@Contrasena", usu.contrasenaUsuario);
                command.Parameters.AddWithValue("@TarjetaCred", usu.tarjetaUsuario);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
                connectBD.Close();
            }
            return entra;
        }
        //Borra un usuario en la BD
        public bool deleteUsuario(ENUsuario usu)
        {
            int response = 0;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Delete from Usuarios where nif = @Nif", connectBD);
                command.Parameters.AddWithValue("@Nif", usu.NIFUsuario);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
        //Comprueba si el email y la contraseña son correctos para iniciar sesión
        public bool InicioSesion(ENUsuario usu)
        {
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Usuario ", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();
                while (!entra && dataReader.Read())
                {
                    if (usu.emailUsuario == dataReader["Email"].ToString() && usu.contrasenaUsuario == dataReader["Contrasena"].ToString())
                    {
                        entra = true; 
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;

        }
        public string ConnectString
        {
            get { return connection; }
            set { connection = value; }
        }

    }
}
