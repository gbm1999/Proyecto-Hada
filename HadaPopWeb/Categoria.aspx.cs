using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
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
            Response.Redirect("Categoriaconcrete.aspx");
            
            
        }
    }


  
}