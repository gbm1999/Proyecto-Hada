using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Windows;

namespace HadaPopWeb
{
    public partial class Credit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario user = new ENUsuario();

            user.NIFUsuario = (string)Session["nif"];

            bool ok = false;

            if(ok)
            {
                Balance.Text = user.balance.ToString() + "€";
            }
            else
            {
                
            }
        }
        
        protected void Depositar_Click(object sender, EventArgs e)
        {
            
        }

        protected void Retirar_Click(object sender, EventArgs e)
        {

        }
    }
}