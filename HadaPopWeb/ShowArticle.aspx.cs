using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace HadaPopWeb
{
    public partial class ShowArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarArticulo();
        }

        private void mostrarArticulo()
        {
            ENArticulo articulo = new ENArticulo();
            
            Label1.Text = "pirulin";
            Label2.Text = articulo.showOneArticle().nombreArticulo;
        }
    }
}