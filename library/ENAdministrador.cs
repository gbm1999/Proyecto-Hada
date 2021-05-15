using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENAdministrador
    {
        // Administrador es la variable donde se guarara el nif del usuario que sera administrador
        private string Administrador;
        public string administrador
        {
            get
            {
                return Administrador;
            }
            set
            {
                Administrador = value;
            }
        }

        // Usuario es la variable donde ira el nif del usuario a expulsar
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
        // Constructor por defecto
        public ENAdministrador()
        {
            Administrador = null;
            Usuario = null;
        }
        // Constructor sobrecargado
        public ENAdministrador(string Admin)
        {
            this.administrador = Admin;
        }
        // Crea un nuevo administrador
        public bool createAdministrador()
        {
            CADAdministrador Admin = new CADAdministrador();

            return (Admin.createAdministrador(this));
        }
        // Realiza la expulsion de un usario
        public bool expulsion()
        {
            CADAdministrador Admin = new CADAdministrador();

            return (Admin.expulsion(this));
        }
    }
}
