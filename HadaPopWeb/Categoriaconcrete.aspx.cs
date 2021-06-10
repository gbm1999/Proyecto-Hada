using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace HadaPopWeb
{
    public partial class Categoriaconcrete : System.Web.UI.Page
    {
        ENCategoria cat = new ENCategoria();
        protected void Page_Load(object sender, EventArgs e)
        {
            cat.NombreCategoria = Request.QueryString["Value"];
            cat.readCategoria();
            if (!IsPostBack) mostrarcategoria(cat);


        }
        protected void mostrarcategoria(ENCategoria cat)
        {
            nombre.Text = cat.NombreCategoria;
            description.Text = cat.DescripCategoria;
        }
        protected void borrar_categoria(object sender, EventArgs e)
        {
            ENCategoria cat_new = new ENCategoria();
            cat_new.NombreCategoria = nombre.Text;
            cat_new.DescripCategoria = description.Text;

            if (cat_new.deleteCategoria())
            {
                Label1.Text = "Categoría borrada correctamente";
                nombre.Text = "";
                description.Text = "";
            }
            else
            {
                Label1.Text = "ERROR: La categoría no se ha podido borrar.";
            }

        }

         
        protected void editar_categoria(object sender, EventArgs e)
        {
            
            cat.NombreCategoria = nombre.Text;
            cat.DescripCategoria = description.Text;

            if (cat.updateCategoria())
            {
                Label1.Text = "Categoría actualizada correctamente.";
            }
            else
            {
                Label1.Text = "ERROR: La categoría no se ha podido editar.";
            }

        }
    }
}