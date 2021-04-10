﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {
        private string NIF;
        public string NIFUsuario
        {
            get
            {
                return NIF;
            }
            set
            {
                NIF = value;
            }
        }
        private string nombre;
        public string nombreUsuario
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        private string email;
        public string emailUsuario
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        private string contrasena;
        public string contrasenaUsuario
        {
            get
            {
                return contrasena;
            }
            set
            {
                contrasena = value;
            }
        }
        private int edad;
        public int edadUsuario
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        private int telefono;
        public int telefonoUsuario
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }
        private bool admin;
        public bool adminUsuario
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }
        public ENUsuario()
        {
            NIF = null;
            nombre = null;
            email = null;
            telefono = 0;
            admin = false;
            edad = 0;
            contrasena = null;
        }
        public ENUsuario(string NIF, string nombre, string email,int telefono, bool admin, int edad, string contrasena)
        {
            this.NIF = NIF;
            this.nombre = nombre;
            this.email = email;
            this.telefono = telefono;
            this.admin = admin;
            this.edad = edad;
            this.contrasena = contrasena;
        }
        public bool createUsuario()
        {
            CADUsuario usu = new CADUsuario();
            return usu.createUsuario(this);            
        }
        public bool readUsuario()
        {
            CADUsuario user = new CADUsuario();
            return user.readUsuario(this);
        }
        public bool updateUsuario()
        {
            CADUsuario user = new CADUsuario();
            return user.updateUsuario(this);
        }
        public bool deleteUsuario()
        {
            CADUsuario user = new CADUsuario();
            return user.deleteUsuario(this);
        }
        public bool InicioSesion()
        {
            CADUsuario user = new CADUsuario();
            return user.InicioSesion(this);
        }
    }
}