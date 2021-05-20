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
            connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            connectBD = new SqlConnection(connection);
        }
        //Inserta un usuario en la BD
        public bool createUsuario(ENUsuario usu)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Usuario(Nif,Nombre,Email,Telefono,Admin,Edad,Contrasena,TarjetaCred,Imagen,Balance) VALUES ('" + usu.NIFUsuario + "', '" + usu.nombreUsuario + "', '" + usu.emailUsuario + "', '" + usu.telefonoUsuario + "', '" + usu.edadUsuario + "', '" + usu.contrasenaUsuario + "', '" + usu.tarjetaUsuario + "', '" + usu.imagenUsuario + "', '" + usu.balance + "')", connectBD);
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
                        usu.edadUsuario = (int)dataReader["Edad"];
                        usu.contrasenaUsuario = dataReader["Contrasena"].ToString();
                        usu.tarjetaUsuario = (string)dataReader["TarjetaCred"];
                        if (dataReader["Imagen"] != System.DBNull.Value)
                        {
                            usu.imagenUsuario = (byte[])dataReader["Imagen"];
                        }
                        //usu.balance = (float)dataReader["Balance"];
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
                SqlCommand command = new SqlCommand("UPDATE Usuario SET Nif = @Nif,Nombre = @Nombre,Email = @Email," +
                                                    "Telefono = @Telefono,Admin = @Admin, Edad = @Edad, Contrasena = @Contrasena," +
                                                    "TarjetaCred = @TarjetaCred, Imagen = @Imagen, Balance = @Balance where nif = @nif", connectBD);
                command.Parameters.AddWithValue("@Nif", usu.NIFUsuario);
                command.Parameters.AddWithValue("@Nombre", usu.nombreUsuario);
                command.Parameters.AddWithValue("@Email", usu.emailUsuario);
                command.Parameters.AddWithValue("@Telefono", usu.telefonoUsuario);
                command.Parameters.AddWithValue("@Edad", usu.edadUsuario);
                command.Parameters.AddWithValue("@Contrasena", usu.contrasenaUsuario);
                command.Parameters.AddWithValue("@TarjetaCred", usu.tarjetaUsuario);
                command.Parameters.AddWithValue("@Imagen", usu.imagenUsuario);
                command.Parameters.AddWithValue("@Balance", usu.balance);
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
                SqlCommand command = new SqlCommand("Delete from Usuario where Nif = @Nif", connectBD);
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
        public int CountSales(ENUsuario usu)
        {
            int count = 0;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo ", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (usu.NIFUsuario == dataReader["Vendedor"].ToString())
                    {
                        count++;
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
            return count;
        }
        public int CountBuys(ENUsuario usu)
        {
            int count = 0;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo ", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (usu.NIFUsuario == dataReader["comprador"].ToString())
                    {
                        count++;
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
            return count;
        }
        public void GuardarImagen(ENUsuario usu, byte[] imagen)
        {
            try
            {
                int response = 0;
                connectBD.Open();
                SqlCommand command = new SqlCommand("UPDATE Usuario SET Imagen = @Imagen where nif = @nif",connectBD);
                SqlParameter imageParam = command.Parameters.Add("@Imagen", System.Data.SqlDbType.Image);
                command.Parameters.AddWithValue("@Nif", usu.NIFUsuario);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    imageParam.Value = imagen;
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
        }
        public byte[] GetImagenByUser(ENUsuario usu)
        {
            byte[] Imagen = null;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("SELECT Imagen FROM Usuario where nif = @nif", connectBD);
                command.Parameters.AddWithValue("@nif", usu.NIFUsuario);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    Imagen = (byte[])dataReader["Imagen"];

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return Imagen;
        }
        public string ConnectString
        {
            get { return connection; }
            set { connection = value; }
        }

    }
}
