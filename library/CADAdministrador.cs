using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace library
{
   public class CADAdministrador
    {
        private string connection;
        private SqlConnection connectBD;

        public CADAdministrador()
        {
            ArrayList lista = new ArrayList();
            connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            connectBD = new SqlConnection(connection);
        }

        public bool createAdministrador(ENAdministrador Admin)
        {
            bool ok = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Administrador(Usuario) VALUES('" + Admin.administrador + "')", connectBD);

                command.ExecuteNonQuery();
                ok = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }

            return (ok);
        }

        public bool isAdministrador(ENAdministrador admin)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Administrador", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (!entra && dataReader.Read())
                {
                    if (dataReader["Usuario"].ToString().Equals(admin.administrador))
                    {
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
        public bool expulsion(ENAdministrador Admin)
        {
            bool ok = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Delete from Usuario where Nif = @Nif", connectBD);
                command.Parameters.AddWithValue("@Nif", Admin.usuario);
                command.ExecuteNonQuery();
                
                ok = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return ok;
        }
        public ArrayList MostrarUsers()
        {
            ArrayList lista = new ArrayList();
            connectBD.Open();
            SqlCommand command = new SqlCommand("Select * from Usuario", connectBD);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ENUsuario usu = new ENUsuario();
                usu.NIFUsuario = dataReader["Nif"].ToString();
                usu.nombreUsuario = dataReader["Nombre"].ToString();
                usu.emailUsuario = dataReader["Email"].ToString();
                usu.telefonoUsuario = (int)dataReader["Telefono"];
                usu.edadUsuario = (int)dataReader["Edad"];
                usu.contrasenaUsuario = dataReader["Contrasena"].ToString();
                usu.imagenUsuario = (byte[])dataReader["Imagen"];
                usu.balance = (float)dataReader["Balance"];
                lista.Add(usu);
            }
            dataReader.Close();
            connectBD.Close();

            return lista;
        }
    }
}
