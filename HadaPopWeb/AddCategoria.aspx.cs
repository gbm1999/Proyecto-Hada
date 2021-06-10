using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace HadaPopWeb
{
   
    public partial class AddCategoria : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void boton_crear(object sender, EventArgs e)
        {
            
            ENCategoria cat_new = new ENCategoria();
            cat_new.NombreCategoria = nombre.Text;
            cat_new.DescripCategoria = description.Text;

            if (cat_new.createCategoria())
            {
                Label1.Text = "La nueva categoría se ha creado correctamente.";
            }
            else
            {
                Label1.Text = "La nueva categoría no se ha podido crear.";
            }
            
        }



    }
}