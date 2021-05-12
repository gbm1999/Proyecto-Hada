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

            if (!ok/*user.readUsuario()*/)
            {
                Balance.Text = user.balance.ToString() + "€";
            }
            else
            {
                PopupNoLogin.Show();
            }
        }

        protected void PopUpAceptarDepositar(object sender, EventArgs e)
        {
            ENUsuario user = new ENUsuario();

            user.NIFUsuario = (string)Session["nif"];

            user.balance = (user.balance + float.Parse(DepositarTextBox.Text));

            bool ok = false;

            if(!ok/*!user.updateUsuario()*/)
            {
                ErrorTransacciones.Text = "No se ha podido añadir el importe asignado, por favor vuelva a intentarlo";
            }
        }

        protected void PopUpAceptarRetirar(object sender, EventArgs e)
        {
            ENUsuario user = new ENUsuario();

            user.NIFUsuario = (string)Session["nif"];

            bool ok = false;

            user.balance = (user.balance + float.Parse(RetirarTextBox.Text));

            if (!ok/*!user.updateUsuario()*/)
            {
                ErrorTransacciones.Text = "No se ha podido eliminar el importe asignado, por favor vuelva a intentarlo";
            }
        }

        protected void PopUpLogin(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}