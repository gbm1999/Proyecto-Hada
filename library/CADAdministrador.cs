using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    class CADAdministrador
    {
        private string connection;
        private SqlConnection connectBD;

        public CADAdministrador()
        {
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
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
    }
}
