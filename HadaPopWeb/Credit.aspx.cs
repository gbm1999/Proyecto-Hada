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
            if(!IsPostBack)
            {
                ENUsuario user = obtencionNif();

                bool ok = false;

                if (!ok/*user.readUsuario()*/)
                {
                    Balance.Text = user.balance.ToString() + "€";
                    //IniciarLlenadoDropDown();
                }
                else
                {
                    PopupNoLogin.Show();
                }
            }
        }

        protected ENUsuario obtencionNif()
        {
            ENUsuario user = new ENUsuario();

            user.NIFUsuario = (string)Session["nif"];

            return (user);
        }

        protected void PopUpAceptarDepositar(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();

            bool dato = true;

            if(DepositarTextBox.Text == "")
            {
                dato = false;
            }
            else if(float.Parse(DepositarTextBox.Text) < 0)
            {
                DepositarTextBox.Text = "";
                dato = false;
            }


            if(dato)
            {
                user.balance = (user.balance + float.Parse(DepositarTextBox.Text));

                bool ok = false;

                if (!ok/*!user.updateUsuario()*/)
                {
                    ErrorTransacciones.Text = "No se ha podido añadir el importe asignado, por favor vuelva a intentarlo";
                }
                else
                {
                    Balance.Text = user.balance.ToString() + "€";
                }
            }
        }

        protected void PopUpAceptarRetirar(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();

            bool dato = true;

            if (DepositarTextBox.Text == "")
            {
                dato = false;
            }
            else if (float.Parse(DepositarTextBox.Text) < 0)
            {
                DepositarTextBox.Text = "";
                dato = false;
            }

            if(dato)
            {
                bool ok = false;

                user.balance = (user.balance - float.Parse(RetirarTextBox.Text));

                if (!ok/*!user.updateUsuario()*/)
                {
                    ErrorTransacciones.Text = "No se ha podido eliminar el importe asignado, por favor vuelva a intentarlo";
                }
                else
                {
                    Balance.Text = user.balance.ToString() + "€";
                }
            }
        }

        protected void PopUpLogin(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        /*
        private void IniciarLlenadoDropDown()
        {
            ENMonedero Monedero = new ENMonedero();
            TBNombre.DataSource = Monedero.MostrarTarjetas();
            TBNombre.DataTextField = "Tajeta";
            TBNombre.DataValueField = "numTarjerta";
            TBNombre.DataBind();
            TBNombre.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
        */
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ENMonedero monedero = new ENMonedero
            {
                numTarjeta = TBNombre.Items[TBNombre.SelectedIndex].Text,
                ContrasenaTarjeta = 5,
                SaldoTarjeta = 0
            };
        }

        protected void Añadir(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();
            ENMonedero monedero = new ENMonedero();

            monedero.numTarjeta = TBNombre.SelectedValue;

            if(Contraseña.Text == "")
            {
                Contraseña.Text = "0";
            }

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
                ErrorTarjetas.Text = "Alguno de los campos es incorrecto por favor vuelva aintroducirlos.";
            }
        }

        protected void Eliminar(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();
            ENMonedero monedero = new ENMonedero();

            monedero.numTarjeta = TBNombre.SelectedValue;
            
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "0";
            }

            monedero.ContrasenaTarjeta = int.Parse(Contraseña.Text);

            bool ok = false;

            if (ok/*monedero.AccesoSaldo()*/)
            {
                user.balance = (user.balance - monedero.SaldoTarjeta);

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
                ErrorTarjetas.Text = "Alguno de los campos es incorrecto por favor vuelva aintroducirlos.";
            }
        }
    }
}