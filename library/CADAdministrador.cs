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
        ArrayList lista;

        public CADAdministrador()
        {
            ArrayList lista = new ArrayList();
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            connectBD = new SqlConnection(connection);
        }

        public bool nuevoAdministrador(ENAdministrador Admin)
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
                usu.tarjetaUsuario = (int)dataReader["TarjetaCred"];
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
