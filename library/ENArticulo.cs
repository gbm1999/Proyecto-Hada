using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENArticulo
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


        private string categoria;
        public string categoriaArticulo
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

        private byte[] imagen;
        public byte[] imagenArticulo
        {
            get
            {
                return imagen;
            }
            set
            {
                byte[] prueba = new byte[0];

                if (value == prueba)
                {
                    value = null;
                }
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
            //aux.imgDefault(ref imagen);
            //Futura mejora
            //aux.imgDefault(ref imagen);   

            codigo = -1;
            nombre = null;
            descripcion = null;
            categoria = null;
            precio = -1.0f;
            ciudad = null;
            comprador = null;
            vendedor = null;
            imagen = null;
        }
        public ENArticulo(int codigo, string nombre, string descripcion, string categoria, float precio, string ciudad, string vendedor, byte[] imagen)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.precio = precio;
            this.ciudad = ciudad;
            this.vendedor = vendedor;
            this.imagen = imagen;
        }

        public bool createArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.createArticulo(this);
        }

        public bool readArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.readArticulo(this);
        }
        public ArrayList searchArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.searchArticulo(this);
        }
        public bool readFirstArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.readFirstArticulo(this);
        }
        public bool readPrevArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.readPrevArticulo(this);
        }
        public bool readNextArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.readNextArticulo(this);
        }

        public bool updateArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.updateArticulo(this);
        }

        public bool deleteArticulo()
        {
            CADArticulo arti = new CADArticulo();
            return arti.deleteArticulo(this);
        }

        public ArrayList showArticles()
        {
            CADArticulo arti = new CADArticulo();
            return arti.showArticles();
        }

        public ENArticulo showOneArticle()
        {
            CADArticulo arti = new CADArticulo();
            return arti.showOneArticle(this);
        }

        public ArrayList showArticlesFromUser(ENUsuario usu)
        {
            ArrayList lista = new ArrayList();
            CADArticulo arti = new CADArticulo();
            lista = arti.showArticlesFromUser(usu);
            return lista;
        }
        public ArrayList showArticlesFromCategory(ENCategoria cate)
        {
            CADArticulo arti = new CADArticulo();
            return arti.showArticlesFromCategory(cate);
        }
        public void guardaImagen(byte[] imagen)
        {
            CADArticulo arti = new CADArticulo();
            arti.GuardarImagen(this, imagen); ;
        }
        public byte[] getImagen()
        {
            CADArticulo arti = new CADArticulo();
            return arti.GetImagenByArticle(this); ;
        }

        public int countArticulo()
        {
            CADArticulo articulo = new CADArticulo();
            return (articulo.countArticulo(this));
        }
    }
}
