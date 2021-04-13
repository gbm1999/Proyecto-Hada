using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    class CADReporte
    {
        private string connection;
        private SqlConnection connectBD;
        public CADReporte()
        {
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            connectBD = new SqlConnection(connection);
        }

        // Eliminarcion de la cuenta de un usuario por mal uso
        public bool deleteUsuario(ENReporte report)
        {
            int response = 0;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Delete from Usuario where Nif = @Nif", connectBD);
                command.Parameters.AddWithValue("@Nif", report.NifUsuario);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Report operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }

        // Crea un comentario al usuario
        public bool createComentario(ENReporte report)
        {
            bool ok = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Comentario(IDComentario, Titulo, Descripcion, Cliente, Receptor) VALUES ('" + report.IDComentario + "', '" + report.TituloComentario + "', '" + report.DescripcionComentario + "', '" + report.Admin + "', '" + report.NifUsuario + ")", connectBD);
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
