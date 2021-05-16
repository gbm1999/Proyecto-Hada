using System;
using System.Collections;
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

        public ArrayList findComentarios(ENComentario comentario)
        {
            ArrayList lista = new ArrayList();

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Comentario where Receptor = @Receptor", connectBD);
                command.Parameters.AddWithValue("@Recetor", comentario.NifUsuario);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    comentario.IDComentario = (int)dataReader["IDComentario"];
                    comentario.TituloComentario = dataReader["Titulo"].ToString();
                    comentario.DescripcionComentario = dataReader["Descripcion"].ToString();
                    comentario.Emisor = dataReader["Cliente"].ToString();

                    lista.Add(comentario);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wallet operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }

            return lista;
        }
    }
}
