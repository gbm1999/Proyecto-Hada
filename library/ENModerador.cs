using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENModerador
    {
        // Mod es la variable donde guardamos el nif del usuario que se desea hacer moderador
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

        // Usuario es la variable donde guardamos el usuario que sera baneado
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

        // Fecha es la variable donde guardaremos hasta cuand sera baneado un usuario
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
        // Constructor por defecto
        public ENModerador()
        {
            Mod = null;
            Usuario = null;
            Fecha = null;
        }
        // Constructor sobrecargado
        public ENModerador(string mod)
        {
            this.mod = mod;
        }
        // Crea un nuevo moderador
        public bool createModerador()
        {
            CADModerador Mod = new CADModerador();

            return (Mod.createModerador(this));
        } 
        // Baneo se encarga de añadir en una tabla el usuario y el tiempo que sera banedo
        public bool baneo()
        {
            CADModerador Mod = new CADModerador();

            return (Mod.baneo(this));
        }
    }
}
