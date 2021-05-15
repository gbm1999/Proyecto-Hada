using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENComentario
    {
        private string nifusuario;
        public string NifUsuario
        {
            get
            {
                return nifusuario;
            }
            set
            {
                nifusuario = value;
            }
        }

        private int idComentario;
        public int IDComentario
        {
            get
            {
                return idComentario;
            }
            set
            {
                idComentario = value;
            }
        }

        private string tituloComentario;
        public string TituloComentario
        {
            get
            {
                return tituloComentario;
            }
            set
            {
                tituloComentario = value;
            }
        }

        private string emisor;
        public string Emisor
        {
            get
            {
                return emisor;
            }
            set
            {
                emisor = value;
            }
        }


        private string descripcionComentario;
        public string DescripcionComentario
        {
            get
            {
                return descripcionComentario;
            }
            set
            {
                descripcionComentario = value;
            }
        }

        public ENComentario()
        {
            this.IDComentario = IDComentario + 1;
            this.NifUsuario = null;
            this.TituloComentario = null;
            this.DescripcionComentario = null;
            this.Emisor = null;
        }
        public ENComentario(string receptor, string titulo, string descripcion, string emisorCliente)
        {
            this.IDComentario = IDComentario + 1;
            this.NifUsuario = receptor;
            this.TituloComentario = titulo;
            this.DescripcionComentario = descripcion;
            this.Emisor = emisorCliente;
        }

        public bool ponerComentario()
        {
            CADComentario comment = new CADComentario();
            return comment.createComentario(this);
        }
        public ArrayList findComentarios()
        {
            CADComentario comentario = new CADComentario();
            return (comentario.findComentarios(this));
        }
    }
}
