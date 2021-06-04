using System;
using library;
using System.Web.UI.WebControls;
using System.Windows;
using System.Collections;


namespace HadaPopWeb
{
    public partial class categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
    
        }

        protected void acceder_categoria(object sender, EventArgs e)
        {

            LinkButton b = (LinkButton)sender;

            Response.Redirect("Categoriaconcrete.aspx?Value=" + b.Text);

        }
    }


  
}