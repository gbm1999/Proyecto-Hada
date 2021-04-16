using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADMonedero
    {
        private string connection;
        private SqlConnection connectBD;
        public CADMonedero()
        {
            connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            connectBD = new SqlConnection(connection);
        }
        //Inserta un moendero en la BD
        public bool createMonedero(ENMonedero mon)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Insert into Monedero(TarjetaC,Contrasena,Saldo) VALUES ('" + mon.numTarjeta + "', '" + mon.ContrasenaTarjeta + "', '" + mon.SaldoTarjeta + "')", connectBD);
                command.ExecuteNonQuery();
                entra = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Wallet operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
        //Busca un monedero en la BD
        public bool readMonedero(ENMonedero mon)
        {
            bool entra = false;
            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Monedero", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();

                while (!entra && dataReader.Read())
                {
                    if (dataReader["TarjetaC"].ToString().Equals(mon.numTarjeta))
                    {
                        mon.numTarjeta = dataReader["TarjetaC"].ToString();
                        mon.ContrasenaTarjeta = (int)dataReader["Contrasena"];
                        mon.SaldoTarjeta = (float)dataReader["Saldo"];
                        entra = true;
                    }
                }
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Wallet operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
        //Actualiza un monedero en la BD
        public bool updateMonedero(ENMonedero mon)
        {
            int response = 0;
            SqlDataReader dataReader = null;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("UPDATE Monedero SET TarjetaC = @TarjetaC, Contrasena = @Contrasena, Saldo = @Saldo where TarjetaC = @TarjetaC", connectBD);
                command.Parameters.AddWithValue("@TarjetaC", mon.numTarjeta);
                command.Parameters.AddWithValue("@Contrasena", mon.ContrasenaTarjeta);
                command.Parameters.AddWithValue("@Saldo", mon.SaldoTarjeta);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Wallet operation has failed. Error: {0}", ex.Message);
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
        //Borra un monedero en la BD
        public bool deleteMonedero(ENMonedero mon)
        {
            int response = 0;
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Delete from Monedero where TarjetaC = @TarjetaC", connectBD);
                command.Parameters.AddWithValue("@TarjetaC",mon.numTarjeta);
                response = command.ExecuteNonQuery();

                if (response == 1)
                {
                    entra = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Wallet operation has failed. Error: {0}", ex.Message);
            }
            finally
            {
                connectBD.Close();
            }
            return entra;
        }
        //Comprueba si el numero de tarjeta y la contraseña son correctos para acceder al saldo
        public bool AccesoSaldo(ENMonedero mon)
        {
            bool entra = false;

            try
            {
                connectBD.Open();
                SqlCommand command = new SqlCommand("Select * from Monedero ", connectBD);
                SqlDataReader dataReader = command.ExecuteReader();
                while (!entra && dataReader.Read())
                {
                    if (mon.numTarjeta == dataReader["TarjetaC"].ToString() && mon.ContrasenaTarjeta == (int)dataReader["Contrasena"])
                    {
                        entra = true;
                    }
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
            return entra;

        }
        public string ConnectString
        {
            get { return connection; }
            set { connection = value; }
        }
    }
}