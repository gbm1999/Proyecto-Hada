using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CADAdmin
    {
        ArrayList lista = new ArrayList();
        private string connection;
        private SqlConnection connectBD;
        public CADAdmin()
        {
            connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            connectBD = new SqlConnection(connection);
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
