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
    class CADCategoria
    {
        ArrayList lista = new ArrayList();
        private string connection;
        private SqlConnection connectBD;
        public CADCategoria()
        {
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            connectBD = new SqlConnection(connection);
        }
        public ArrayList MostrarCategorias()
        {
            connectBD.Open();
            SqlCommand command = new SqlCommand("Select * from Categoria", connectBD);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ENCategoria cat = new ENCategoria();
                cat.IdCategoria = (int)dataReader["Id"];
                cat.NombreCategoria = dataReader["Nombre"].ToString();
                cat.DescripCategoria = dataReader["Descripcion"].ToString();

                lista.Add(cat);
            }
            dataReader.Close();
            connectBD.Close();

            return lista;
        }
        public bool createCategoria(ENCategoria cat)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Categoria(Id,Nombre,Descripcion) VALUES ('" + cat.IdCategoria + "', '" + cat.NombreCategoria + "', '" + cat.DescripCategoria + "')", connectBD);
                command.ExecuteNonQuery();
                entra = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Category operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
        //Busca una categoria en la BD
        public bool readCategoria(ENCategoria cat)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Categoria", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (!entra && dataReader.Read())
                {
                    if (dataReader["Id"].ToString().Equals(cat.IdCategoria))
                    {
                        cat.IdCategoria = (int)dataReader["Id"];
                        cat.NombreCategoria = dataReader["Nombre"].ToString();
                        cat.DescripCategoria = dataReader["Descripcion"].ToString();
                        entra = true;
                    }
                }
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Category operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
        //Actualiza una categoria en la BD
        public bool updateCategoria(ENCategoria cat)
        {
            int response = 0;
            SqlDataReader dataReader = null;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("UPDATE Categoria SET Id = @Id, Nombre = @Nombre, Descripcion = @Descripcion where Id = @Id", connectBD);
                command.Parameters.AddWithValue("@Id", cat.IdCategoria);
                command.Parameters.AddWithValue("@Nombre", cat.NombreCategoria);
                command.Parameters.AddWithValue("@Descripcion", cat.DescripCategoria);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Category operation has failed. Error: {0}", ex.Message);
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
        //Borra una categoria en la BD
        public bool deleteCategoria(ENCategoria cat)
        {
            int response = 0;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Delete from Categoria where Id = @Id", connectBD);
                command.Parameters.AddWithValue("@Id", cat.IdCategoria);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Category operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
    }
}
