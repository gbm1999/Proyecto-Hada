using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENCategoria
    {
        private int Id;
        public int IdCategoria
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        private string Nombre;
        public string NombreCategoria
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        private string Descripcion;
        public string DescripCategoria
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
            }
        }
        public ENCategoria()
        {
            Id = -1;
            Nombre = null;
            Descripcion = null;
        }
        public ENCategoria(int Id, string Nombre, string Descripcion)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
        }
        public ArrayList MostrarCategorias()
        {
            ArrayList lista = new ArrayList();
            CADCategoria categoria = new CADCategoria();
            lista = categoria.MostrarCategorias();

            return lista;
        }
        public bool createCategoria()
        {
            CADCategoria categoria = new CADCategoria();
            return categoria.createCategoria(this);
        }
        public bool readCategoria()
        {
            CADCategoria categoria = new CADCategoria();
            return categoria.readCategoria(this);
        }
        public bool updateCategoria()
        {
            CADCategoria categoria = new CADCategoria();
            return categoria.updateCategoria(this);
        }
        public bool deleteCategoria()
        {
            CADCategoria categoria = new CADCategoria();
            return categoria.deleteCategoria(this);
        }
    }
}
