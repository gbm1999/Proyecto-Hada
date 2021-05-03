using System;
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

        private string idComentario;
        public string IDComentario
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

        public bool ponerComentario()
        {
            CADComentario comment = new CADComentario();
            return comment.createComentario(this);
        }
    }
}
