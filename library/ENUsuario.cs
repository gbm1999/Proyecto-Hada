﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
        private int tarjeta;
        public int tarjetaUsuario
        {
            get
            {
                return tarjeta;
            }
            set
            {
                tarjeta = value;
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
        private byte[] imagen;
        public byte[] imagenUsuario
        {
            get
            {
                return imagen;
            }
            set
            {
                imagen = value;
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
            tarjeta = 0;
            imagen = null;
        }
        public ENUsuario(string NIF, string nombre, string email,int telefono, bool admin, int edad, string contrasena, int tarjeta, byte[] imagen)
        {
            this.NIF = NIF;
            this.nombre = nombre;
            this.email = email;
            this.telefono = telefono;
            this.admin = admin;
            this.edad = edad;
            this.contrasena = contrasena;
            this.tarjeta = tarjeta;
            this.imagen = imagen;
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
        public int CountSales()
        {
            CADArticulo arti = new CADArticulo();
            return arti.CountSales(this);
        }
        public int CountBuys()
        {
            CADArticulo arti = new CADArticulo();
            return arti.CountBuys(this);
        }
        public void guardaImagen(byte[] imagen)
        {
            CADUsuario user = new CADUsuario();
            user.GuardarImagen(this,imagen); ;
        }
        public byte[] getImagen()
        {
            CADUsuario user = new CADUsuario();
            return user.GetImagenByUser(this); ;
        }
    }
}
