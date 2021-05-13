using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENMonedero
    {
        private string Tarjeta;
        public string numTarjeta
        {
            get
            {
                return Tarjeta;
            }
            set
            {
                Tarjeta = value;
            }
        }
        private int Contrasena;
        public int ContrasenaTarjeta
        {
            get
            {
                return Contrasena;
            }
            set
            {
                Contrasena = value;
            }
        }
        private float Saldo;
        public float SaldoTarjeta
        {
            get
            {
                return Saldo;
            }
            set
            {
                Saldo = value;
            }
        }
        public ENMonedero()
        {
            Tarjeta = null;
            Contrasena = 0;
            Saldo = 0;
        }
        public ENMonedero(string Tarjeta, int Contrasena, float Saldo)
        {
            this.Tarjeta = Tarjeta;
            this.Contrasena = Contrasena;
            this.Saldo = Saldo;
        }
        public bool createMonedero()
        {
            CADMonedero monedero = new CADMonedero();
            return monedero.createMonedero(this);
        }
        public bool readMonedero()
        {
            CADMonedero monedero = new CADMonedero();
            return monedero.readMonedero(this);
        }
        public bool updateMonedero()
        {
            CADMonedero monedero = new CADMonedero();
            return monedero.updateMonedero(this);
        }
        public bool deleteMonedero()
        {
            CADMonedero monedero = new CADMonedero();
            return monedero.deleteMonedero(this);
        }
        public bool AccesoSaldo()
        {
            CADMonedero monedero = new CADMonedero();
            return monedero.AccesoSaldo(this);
        }

        public ArrayList MostrarTarjetas()
        {
            ArrayList lista = new ArrayList();
            CADMonedero Monedero = new CADMonedero();
            lista = Monedero.MostrarTarjetas();

            return lista;
        }
    }
}
