using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADModerador
    {
        private string connection;
        private SqlConnection connectBD;

        public CADModerador()
        {
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            connectBD = new SqlConnection(connection);
        }

        public bool createModerador(ENModerador Mod)
        {
            bool ok = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Moderador(Usuario) VALUES('" + Mod.mod + "')", connectBD);

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

        public bool isModerador(ENModerador mod)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Moderador", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (!entra && dataReader.Read())
                {
                    if (dataReader["Usuario"].ToString().Equals(mod.mod))
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

        public bool baneo(ENModerador Mod)
        {
            bool ok = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Baneado(Moderador, Usuario, Fecha) VALUES('" + Mod.mod + "', '" + Mod.usuario + "', '" + Mod.fecha + "')", connectBD);
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

        public int CountBan(ENUsuario usu)
        {
            int count = 0;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Baneado ", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();
                
                while (dataReader.Read())
                {
                    if (usu.NIFUsuario == dataReader["Ususario"].ToString())
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
    }
}
