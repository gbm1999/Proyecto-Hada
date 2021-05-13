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

            ENArticulo articulo = new ENArticulo();
            articulo.nombreArticulo= Request.QueryString["Value"];
            mostrarArticulo(articulo);
        }

        private void mostrarArticulo(ENArticulo articulo)
        {
            
            nombre.Text = articulo.showOneArticle().nombreArticulo;
            Ciudad.Text = articulo.showOneArticle().ciudadArticulo;
            Descripcion.Text = articulo.showOneArticle().descripcionArticulo;
            vendedor.Text = articulo.showOneArticle().vendedorArticulo;
        }
    }
}