using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENAdministrador
    {
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
        public ENAdministrador()
        {
            Administrador = null;
            Usuario = null;
        }
        public ENAdministrador(string Admin, string usuario)
        {
            this.administrador = Admin;
            this.usuario = usuario;
        }
        public bool nuevoAdministrador()
        {
            CADAdministrador Admin = new CADAdministrador();

            return (Admin.nuevoAdministrador(this));
        }
        public bool expulsion()
        {
            CADAdministrador Admin = new CADAdministrador();

            return (Admin.expulsion(this));
        }
        public ArrayList MostrarUsuarios()
        {
            ArrayList lista = new ArrayList();
            CADAdministrador admin = new CADAdministrador();
            lista = admin.MostrarUsers();

            return lista;
        }
    }
}
