using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADArticulo
    {
        private string connection;
        private SqlConnection connectBD;
        public CADArticulo()
        {
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            connectBD = new SqlConnection(connection);
        }

        //Inserta un articulo en la BD
        public bool createArticulo(ENArticulo arti)
        {
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Artiuclo(codigo, Nombre, Descripcion, Categoria, Precio, Imagen, Ciudad, Comprador, Vendedor) VALUES ('" + arti.codigoArticulo + "', '" + arti.nombreArticulo + "', '" + arti.descripcionArticulo + "', '" + arti.categoriaArticulo + "', '" + arti.precioArticulo + "', '" + arti.imagenArticulo + "', '" + arti.ciudadArticulo + "', '" + arti.compradorArticulo +"', '" + arti.vendedorArticulo + "' )", connectBD);
                command.ExecuteNonQuery();
                entra = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return(entra);
        }

        //Busca un Articulo en la BD
        public bool readArticulo(ENArticulo arti)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (!entra && dataReader.Read())
                {
                    if (dataReader["codigo"].ToString().Equals(arti.codigoArticulo))
                    {
                        arti.codigoArticulo = (int)dataReader["codigo"];
                        arti.nombreArticulo = dataReader["Nombre"].ToString();
                        arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                        arti.categoriaArticulo = (int)dataReader["Categoria"];
                        arti.precioArticulo = (float)dataReader["Precio"];
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                        arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                        arti.compradorArticulo = dataReader["Comprador"].ToString();
                        arti.vendedorArticulo = dataReader["vendedor"].ToString();
                        entra = true;
                    }
                }
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }

        //Actualiza un Articulo en la BD
        public bool updateArticulo(ENArticulo arti)
        {
            int response = 0;
            SqlDataReader dataReader = null;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("UPDATE Articulo SET codigo = @codigo, Nombre = @Nombre, Descripcion = @Descripcion, " +
                                                    "Categoria = @Categoria, Precio = @Precio, Imagen = @Imagen, Ciudad = @Ciudad, " +
                                                    "Comprador = @Comprador, Vendedor = @Vendedor where codigo = @codigo", connectBD);
                command.Parameters.AddWithValue("@codigo", arti.codigoArticulo);
                command.Parameters.AddWithValue("@Nombre", arti.nombreArticulo);
                command.Parameters.AddWithValue("@Descripcion", arti.descripcionArticulo);
                command.Parameters.AddWithValue("@Categoria", arti.categoriaArticulo);
                command.Parameters.AddWithValue("@Precio", arti.precioArticulo);
                command.Parameters.AddWithValue("@Imagen", arti.imagenArticulo);
                command.Parameters.AddWithValue("@Ciudad", arti.ciudadArticulo);
                command.Parameters.AddWithValue("@Comprador", arti.compradorArticulo);
                command.Parameters.AddWithValue("@Vendedor", arti.vendedorArticulo);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
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

        //Borra un Articulo en la BD
        public bool deleteArticulo(ENArticulo arti)
        {
            int response = 0;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Delete from Articulo where codigo = @codigo", connectBD);
                command.Parameters.AddWithValue("@Codigo", arti.codigoArticulo);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
    }
}
