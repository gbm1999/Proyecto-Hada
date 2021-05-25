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
    public class CADArticulo
    {
        private string connection;
        private SqlConnection connectBD;
        ArrayList lista = new ArrayList();
        public CADArticulo()
        {
            connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            connectBD = new SqlConnection(connection);
        }

        //Inserta un articulo en la BD
        public bool createArticulo(ENArticulo arti)
        {
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Articulo(codigo, Nombre, Descripcion, Categoria, Precio, Imagen, Ciudad, Vendedor) VALUES ('" + arti.codigoArticulo + "', '" + arti.nombreArticulo + "', '" + arti.descripcionArticulo + "', '" + arti.categoriaArticulo + "', '" + arti.precioArticulo + "', '" + arti.imagenArticulo + "', '" + arti.ciudadArticulo + "', '" + arti.vendedorArticulo + "' )", connectBD);
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
                    if (dataReader["codigo"].ToString().Equals(arti.codigoArticulo) || dataReader["nombre"].ToString().Equals(arti.nombreArticulo))
                    {
                        arti.codigoArticulo = (int)dataReader["codigo"];
                        arti.nombreArticulo = dataReader["Nombre"].ToString();
                        arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                        arti.categoriaArticulo = dataReader["Categoria"].ToString();
                        arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                        if (dataReader["Imagen"] != System.DBNull.Value)
                        {
                            arti.imagenArticulo = (byte[])dataReader["Imagen"];
                        }
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
        public ArrayList searchArticulo(ENArticulo arti)
        {
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo WHERE Nombre LIKE @Nombre", connectBD);
                command.Parameters.AddWithValue("@Nombre", "%" + arti.nombreArticulo + "%");
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    arti = new ENArticulo();
                    arti.codigoArticulo = (int)dataReader["codigo"];
                    arti.nombreArticulo = dataReader["Nombre"].ToString();
                    arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                    arti.categoriaArticulo = dataReader["Categoria"].ToString();
                    arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                    if (dataReader["Imagen"] != System.DBNull.Value)
                    {
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                    }
                    arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                    arti.compradorArticulo = dataReader["Comprador"].ToString();
                    arti.vendedorArticulo = dataReader["vendedor"].ToString();

                    lista.Add(arti);
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
            return lista;
        }
        public bool readFirstArticulo(ENArticulo arti)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    arti.codigoArticulo = (int)dataReader["codigo"];
                    arti.nombreArticulo = dataReader["Nombre"].ToString();
                    arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                    arti.categoriaArticulo = dataReader["Categoria"].ToString();
                    arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                    if (dataReader["Imagen"] != System.DBNull.Value)
                    {
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                    }
                    arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                    arti.compradorArticulo = dataReader["Comprador"].ToString();
                    arti.vendedorArticulo = dataReader["vendedor"].ToString();
                    entra = true;
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

        public bool readNextArticulo(ENArticulo arti)
        {
            bool entra = false;
            bool encontrado = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (!encontrado && dataReader.Read())
                {
                    if (dataReader["codigo"].ToString().Equals(arti.codigoArticulo) || dataReader["nombre"].ToString().Equals(arti.nombreArticulo))
                    {
                        encontrado = true;
                    }
                }

                if (encontrado && dataReader.Read())
                {
                    arti.codigoArticulo = (int)dataReader["codigo"];
                    arti.nombreArticulo = dataReader["Nombre"].ToString();
                    arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                    arti.categoriaArticulo = dataReader["Categoria"].ToString();
                    arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                    if (dataReader["Imagen"] != System.DBNull.Value)
                    {
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                    }
                    arti.categoriaArticulo = (string)dataReader["Categoria"];
                    arti.precioArticulo = (float)dataReader["Precio"];
                    arti.imagenArticulo = (byte[])dataReader["Imagen"];
                    arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                    arti.compradorArticulo = dataReader["Comprador"].ToString();
                    arti.vendedorArticulo = dataReader["vendedor"].ToString();
                    entra = true;
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

        public bool readPrevArticulo(ENArticulo article)
        {
            bool entra = false;
            bool esPrimero = true;
            bool encontrado = false;
            ENArticulo arti = new ENArticulo();

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (!encontrado && dataReader.Read())
                {
                    if (dataReader["codigo"].ToString().Equals(arti.codigoArticulo) || dataReader["nombre"].ToString().Equals(arti.nombreArticulo))
                    {
                        encontrado = true;
                    }
                    if (!encontrado)
                    {
                        arti.codigoArticulo = (int)dataReader["codigo"];
                        arti.nombreArticulo = dataReader["Nombre"].ToString();
                        arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                        arti.categoriaArticulo = dataReader["Categoria"].ToString();
                        arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                        if (dataReader["Imagen"] != System.DBNull.Value)
                        {
                            arti.imagenArticulo = (byte[])dataReader["Imagen"];
                        }
                        arti.categoriaArticulo = (string)dataReader["Categoria"];
                        arti.precioArticulo = (float)dataReader["Precio"];
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                        arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                        arti.compradorArticulo = dataReader["Comprador"].ToString();
                        arti.vendedorArticulo = dataReader["vendedor"].ToString();
                    }
                    if (esPrimero && encontrado)
                    {

                    }
                    else
                    {
                        esPrimero = false;
                    }
                }
                if (esPrimero)
                {
                    entra = false;
                }
                else if (encontrado)
                {
                    article.codigoArticulo = arti.codigoArticulo;
                    article.nombreArticulo = arti.nombreArticulo;
                    article.descripcionArticulo = arti.descripcionArticulo;
                    article.categoriaArticulo = arti.categoriaArticulo;
                    article.precioArticulo = arti.precioArticulo;
                    article.imagenArticulo = arti.imagenArticulo;
                    article.ciudadArticulo = arti.ciudadArticulo;
                    article.compradorArticulo = arti.compradorArticulo;
                    article.vendedorArticulo = arti.vendedorArticulo;

                    entra = true;
                }
                else
                {

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
                SqlCommand command = new SqlCommand("UPDATE Articulo SET Nombre = @Nombre, Descripcion = @Descripcion, " +
                                                    "Precio = @Precio, Ciudad = @Ciudad, " +
                                                    "Vendedor = @Vendedor where codigo = @codigo", connectBD);
                command.Parameters.AddWithValue("@codigo", arti.codigoArticulo);
                command.Parameters.AddWithValue("@Nombre", arti.nombreArticulo);
                command.Parameters.AddWithValue("@Descripcion", arti.descripcionArticulo);
                //command.Parameters.AddWithValue("@Categoria", arti.categoriaArticulo);
                command.Parameters.AddWithValue("@Precio", arti.precioArticulo);
                //command.Parameters.AddWithValue("@Imagen", arti.imagenArticulo);
                command.Parameters.AddWithValue("@Ciudad", arti.ciudadArticulo);
                //command.Parameters.AddWithValue("@Comprador", arti.compradorArticulo);
                command.Parameters.AddWithValue("@Vendedor", arti.vendedorArticulo);
                response = command.ExecuteNonQuery();
                entra = true;
                
            }
            catch (SqlException ex)
            {
                entra = false;
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

        public ArrayList showArticles()
        {
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    ENArticulo arti = new ENArticulo();
                    arti.codigoArticulo = (int)dataReader["codigo"];
                    arti.nombreArticulo = dataReader["Nombre"].ToString();
                    arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                    arti.categoriaArticulo = dataReader["Categoria"].ToString();
                    arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                    if (dataReader["Imagen"] != System.DBNull.Value)
                    {
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                    }
                    arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                    arti.compradorArticulo = dataReader["Comprador"].ToString();
                    arti.vendedorArticulo = dataReader["vendedor"].ToString();

                    lista.Add(arti);
                }
                dataReader.Close();
                connectBD.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return lista;
        }

        public ENArticulo showOneArticle(ENArticulo art)
        {
            ENArticulo arti = new ENArticulo();
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo where nombre=@nombre", connectBD);
                command.Parameters.AddWithValue("@nombre", art.nombreArticulo);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    arti.codigoArticulo = (int)dataReader["codigo"];
                    arti.nombreArticulo = dataReader["Nombre"].ToString();
                    arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                    arti.categoriaArticulo = dataReader["Categoria"].ToString();
                    arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                    if (dataReader["Imagen"] != System.DBNull.Value)
                    {
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                    }
                    arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                    arti.compradorArticulo = dataReader["Comprador"].ToString();
                    arti.vendedorArticulo = dataReader["vendedor"].ToString();

                }
                dataReader.Close();
                connectBD.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return arti;
        }

        public ArrayList showArticlesFromCategory(ENCategoria cate)
        {
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo where Categoria = @Nombre", connectBD);
                command.Parameters.AddWithValue("@Nombre", cate.NombreCategoria);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    ENArticulo arti = new ENArticulo();
                    arti.codigoArticulo = (int)dataReader["codigo"];
                    arti.nombreArticulo = dataReader["Nombre"].ToString();
                    arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                    arti.categoriaArticulo = dataReader["Categoria"].ToString();
                    arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                    if (dataReader["Imagen"] != System.DBNull.Value)
                    {
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                    }
                    arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                    arti.compradorArticulo = dataReader["Comprador"].ToString();
                    arti.vendedorArticulo = dataReader["vendedor"].ToString();

                    lista.Add(arti);
                }
                dataReader.Close();
                connectBD.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return lista;
        }
        public ArrayList showArticlesFromUser(ENUsuario usu)
        {
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo where Vendedor = @Vendedor", connectBD);
                command.Parameters.AddWithValue("@Vendedor", usu.nombreUsuario);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    ENArticulo arti = new ENArticulo();
                    arti.codigoArticulo = (int)dataReader["codigo"];
                    arti.nombreArticulo = dataReader["Nombre"].ToString();
                    arti.descripcionArticulo = dataReader["Descripcion"].ToString();
                    arti.categoriaArticulo = dataReader["Categoria"].ToString();
                    arti.precioArticulo = (float)Convert.ToDouble(dataReader["Precio"]);
                    if (dataReader["Imagen"] != System.DBNull.Value)
                    {
                        arti.imagenArticulo = (byte[])dataReader["Imagen"];
                    }
                    arti.ciudadArticulo = dataReader["Ciudad"].ToString();
                    arti.compradorArticulo = dataReader["Comprador"].ToString();
                    arti.vendedorArticulo = dataReader["vendedor"].ToString();

                    lista.Add(arti);
                }
                dataReader.Close();
                connectBD.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return lista;
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
        public void GuardarImagen(ENArticulo art, byte[] imagen)
        {
            try
            {
                int response = 0;
                connectBD.Open();
                SqlCommand command = new SqlCommand("UPDATE Articulo SET Imagen = @Imagen where codigo = @codigo", connectBD);
                SqlParameter imageParam = command.Parameters.Add("@Imagen", System.Data.SqlDbType.Image);
                command.Parameters.AddWithValue("@codigo", art.codigoArticulo);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    imageParam.Value = imagen;
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
        }
        public byte[] GetImagenByArticle(ENArticulo art)
        {
            byte[] Imagen = null;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("SELECT Imagen FROM Articulo where codigo = @codigo", connectBD);
                command.Parameters.AddWithValue("@codigo", art.codigoArticulo);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    Imagen = (byte[])dataReader["Imagen"];

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Article operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return Imagen;
        }

        public int countArticulo(ENArticulo articulo)
        {
            int count = 0;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Articulo ", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    count++;
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
        public string ConnectString
        {
            get { return connection; }
            set { connection = value; }
        }
    }
}
