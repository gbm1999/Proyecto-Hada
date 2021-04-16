﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENArticulo
    {
        private int codigo;
        public int codigoArticulo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        private string nombre;
        public string nombreArticulo
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

        private string descripcion;
        public string descripcionArticulo
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        private int categoria;
        public int categoriaArticulo
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }

        private float precio;
        public float precioArticulo
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }

        private byte[] imagen = new byte[999];
        public byte[] imagenArticulo
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

        private string ciudad;
        public string ciudadArticulo
        {
            get
            {
                return ciudad;
            }
            set
            {
                ciudad = value;
            }
        }

        private string comprador;
        public string compradorArticulo
        {
            get
            {
                return comprador;
            }
            set
            {
                comprador = value;
            }
        }

        private string vendedor;
        public string vendedorArticulo
        {
            get
            {
                return vendedor;
            }
            set
            {
                vendedor = value;
            }
        }

        public ENArticulo()
        {
            CADArticulo aux = new CADArticulo();
            aux.imgDefault(ref imagen);

            codigo = -1;
            nombre = null;
            descripcion = null;
            categoria = -1;
            precio = -1;
            ciudad = null;
            comprador = null;
            vendedor = null;
        }
        public ENArticulo(int codigo, string nombre, string descripcion, int categoria, float precio, string ciudad, string comprador, string vendedor, byte[] imagen)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.precio = precio;
            this.ciudad = ciudad;
            this.comprador = comprador;
            this.vendedor = vendedor;
            this.imagen = imagen;
        }

        public bool createArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.createArticulo(this);
        }

        public bool readUsuario()
        {
            CADArticulo arti = new CADArticulo();
            return arti.readArticulo(this);
        }

        public bool updateUsuario()
        {
            CADArticulo arti = new CADArticulo();
            return arti.updateArticulo(this);
        }

        public bool deleteUsuario()
        {
            CADArticulo arti = new CADArticulo();
            return arti.deleteArticulo(this);
        }
    }
}