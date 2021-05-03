using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADComentario
    {
        private string connection;
        private SqlConnection connectBD;
        public CADComentario()
        {
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            connectBD = new SqlConnection(connection);
        }

        // Crea un comentario al usuario
        public bool createComentario(ENComentario comment)
        {
            bool ok = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Comentario(IDComentario, Titulo, Descripcion, Cliente, Receptor) VALUES ('" + comment.IDComentario + "', '" + comment.TituloComentario + "', '" + comment.DescripcionComentario + "', '" + comment.Emisor + "', '" + comment.NifUsuario + ")", connectBD);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Report operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }

            return (ok);
        }
    }
}
