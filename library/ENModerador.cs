using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENModerador
    {
        private string Mod;
        public string mod
        {
            get
            {
                return Mod;
            }
            set
            {
                Mod = value;
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
        private string Fecha;
        public string fecha
        {
            get
            {
                return Fecha;
            }
            set
            {
                Fecha = value;
            }
        }

        public ENModerador()
        {
            Mod = null;
            Usuario = null;
            Fecha = null;
        }
        public ENModerador(string mod, string usuario, string fecha)
        {
            this.mod = mod;
            this.usuario = usuario;
            this.fecha = fecha;
        }
        public bool nuevoModerador()
        {
            CADModerador Mod = new CADModerador();

            return (Mod.nuevoModerador(this));
        }
        public bool baneo()
        {
            CADModerador Mod = new CADModerador();

            return (Mod.baneo(this));
        }
    }
}
