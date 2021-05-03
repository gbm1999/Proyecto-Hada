using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HadaPopWeb
{
    public partial class AddArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_article(object sender, EventArgs e)
        {
            bool seCrea = false;
            ENArticulo articulo = new ENArticulo
            {
                codigoArticulo = ,
                nombreArticulo = nombre.Text,
                descripcionArticulo = description.Text,
                categoriaArticulo = ,
                precioArticulo = ,
                imagenArticulo = ,
                ciudadArticulo = ,
                compradorArticulo = ,
                vendedorArticulo = 
            };
            seCrea = articulo.createArticulo();
            if (seCrea)
            {
                Label2.Text = " ";
                Label1.Text = "(STATUS-OK) El articulo se ha creado con éxito";
            }
            else
            {
                Label1.Text = " ";
                Label2.Text = "**Error** El articulo ya existe";
            }
        }
    }
}