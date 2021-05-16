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
    public partial class Credit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ENUsuario user = obtencionNif();

                bool ok = false;

                if (!ok/*user.readUsuario()*/)
                {
                    Balance.Text = user.balance.ToString() + "€";
                    //IniciarLlenadoDropDown();
                    Nombre_Usuario.Text =user.nombreUsuario;
                }
                else
                {
                    PopupNoLogin.Show();
                }
            }

            ErrorTransacciones.Text = "";
            ErrorTarjetas.Text = "";
        }

        protected ENUsuario obtencionNif()
        {
            ENUsuario user = new ENUsuario();

            user.NIFUsuario = (string)Session["nif"];

            return (user);
        }

        protected void PopUpLogin(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        
        private void IniciarLlenadoDropDown()
        {
            ENMonedero Monedero = new ENMonedero();
            TBNombre.DataSource = Monedero.MostrarTarjetasLibres();
            TBNombre.DataTextField = "numnTarjeta";
            TBNombre.DataValueField = "numTarjerta";
            TBNombre.DataBind();
            TBNombre.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
        
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ENMonedero monedero = new ENMonedero
            {
                numTarjeta = TBNombre.Items[TBNombre.SelectedIndex].Text,
                ContrasenaTarjeta = 2365,
                SaldoTarjeta = 0
            };
        }

        protected void Añadir(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();
            ENMonedero monedero = new ENMonedero();
            int numero = 0;

            monedero.numTarjeta = TBNombre.SelectedValue;

            if (int.TryParse(Contraseña.Text, out numero))
            {
                monedero.ContrasenaTarjeta = int.Parse(Contraseña.Text);

                bool ok = false;

                if (ok/*monedero.AccesoSaldo()*/)
                {
                    user.balance = (user.balance + monedero.SaldoTarjeta);

                    bool ok1 = false;

                    if (!ok1/*!user.updateUsuario()*/)
                    {
                        ErrorTransacciones.Text = "No se ha podido añadir el importe asignado, por favor vuelva a intentarlo";
                    }
                    else
                    {
                        Balance.Text = user.balance.ToString() + "€";
                    }
                }
                else
                {
                    ErrorTarjetas.Text = "Alguno de los campos es incorrecto por favor vuelva a introducirlos.";
                }
            }
            else
            {
                ErrorTarjetas.Text = "Por favor, introduzca solo numeros es la contraseña";
            }
        }

        protected void Eliminar(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();
            ENMonedero monedero = new ENMonedero();
            int numero = 0;

            monedero.numTarjeta = TBNombre.SelectedValue;

            if (int.TryParse(Contraseña.Text, out numero))
            {

                monedero.ContrasenaTarjeta = int.Parse(Contraseña.Text);

                bool ok = false;

                if (ok/*monedero.AccesoSaldo()*/)
                {
                    bool ok1 = false;

                    if (!ok1/*!user.updateUsuario()*/)
                    {
                        ErrorTransacciones.Text = "No se ha podido añadir el importe asignado, por favor vuelva a intentarlo";
                    }
                }
                else
                {
                    ErrorTarjetas.Text = "Alguno de los campos es incorrecto por favor vuelva a introducirlos.";
                }
            }
            else
            {
                ErrorTarjetas.Text = "Por favor, introduzca solo numeros es la contraseña";
            }
        }
    }
}