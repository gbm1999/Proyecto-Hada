using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENReporte
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

        private string admin;
        public string Admin
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
        public bool deleteUsuario()
        {
            CADReporte report = new CADReporte();
            return report.deleteUsuario(this);
        }

        public bool ponerComentario()
        {
            CADReporte report = new CADReporte();
            return report.createComentario(this);
        }
    }
}
