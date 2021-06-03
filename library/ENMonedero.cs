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

        private string Usuario;
        public string usuario
        {
            get
            {
                return Usuario;
            }
            set
            {
                Usuario = value;
            }
        }
        public ENMonedero()
        {
            Tarjeta = null;
            Contrasena = 0;
            Usuario = null;
        }
        public ENMonedero(string Tarjeta, int Contrasena, string Usuario)
        {
            this.Tarjeta = Tarjeta;
            this.Contrasena = Contrasena;
            this.Usuario = Usuario;
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
        public bool Acceso()
        {
            CADMonedero monedero = new CADMonedero();
            return monedero.Acceso(this);
        }

        public ArrayList MostrarTarjetasLibres()
        {
            ArrayList lista = new ArrayList();
            CADMonedero Monedero = new CADMonedero();
            lista = Monedero.MostrarTarjetasLibres();

            return lista;
        }

        public bool deleteUser()
        {
            CADMonedero monedero = new CADMonedero();
            return (monedero.deleteUser(this));
        }
    }
}
