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
            ENUsuario user = obtencionNif();

            if (user.readUsuario())
            {
                Balance.Text = user.balance.ToString() + "€";
                Nombre_Usuario.Text =user.nombreUsuario;
                ResetErrores();
            }
            else
            {
                PopupNoLogin.Show();
            }
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

        protected void Añadir(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();
            ENMonedero monedero = new ENMonedero();
            int numero = 0;

            monedero.numTarjeta = TBTarjeta.Text;

            if(user.readUsuario())
            {
                if (int.TryParse(Contraseña.Text, out numero))
                {
                    monedero.ContrasenaTarjeta = int.Parse(Contraseña.Text);

                    if (monedero.AccesoSaldo())
                    {
                        ArrayList lista = monedero.MostrarTarjetasLibres();
                        bool ok = false;

                        for(int i = 0; !ok && i < lista.Count; i++)
                        {
                            ENMonedero moneAux = (ENMonedero)lista[i];
                            if (moneAux.numTarjeta == monedero.numTarjeta)
                            {
                                ok = true;
                                user.balance = (user.balance + monedero.SaldoTarjeta);

                                if (!user.updateUsuario())
                                {
                                    ErrorTransaccione.Visible = true;
                                    ErrorTransaccione.InnerText = "No se ha podido añadir el importe asignado, por favor vuelva a intentarlo";
                                }
                                else
                                {
                                    monedero.usuario = user.NIFUsuario;
                                    monedero.updateMonedero();
                                    Balance.Text = user.balance.ToString() + "€";
                                }
                            }
                            else
                            {
                                ErrorTarjeta.Visible = true;
                                ErrorTarjeta.InnerText = "Tarjeta no valida.";
                            }
                        }
                    }
                    else
                    {
                        ErrorTarjeta.Visible = true;
                        ErrorTarjeta.InnerText = "Alguno de los campos es incorrecto por favor vuelva a introducirlos.";
                    }
                }
                else
                {
                    ErrorTarjeta.Visible = true;
                    ErrorTarjeta.InnerText = "Por favor, introduzca solo numeros es la contraseña";
                }
            }
        }

        protected void Eliminar(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();
            ENMonedero monedero = new ENMonedero();
            int numero = 0;

            monedero.numTarjeta = TBTarjeta.Text;

            if (int.TryParse(Contraseña.Text, out numero))
            {

                monedero.ContrasenaTarjeta = int.Parse(Contraseña.Text);

                if (monedero.AccesoSaldo())
                {
                    if (!user.updateUsuario())
                    {
                        ErrorTransaccione.Visible = true;
                        ErrorTransaccione.InnerText = "No se ha podido añadir el importe asignado, por favor vuelva a intentarlo";
                    }
                }
                else
                {
                    ErrorTarjeta.Visible = true;
                    ErrorTarjeta.InnerText = "Alguno de los campos es incorrecto por favor vuelva a introducirlos.";
                }
            }
            else
            {
                ErrorTarjeta.Visible = true;
                ErrorTarjeta.InnerText = "Por favor, introduzca solo numeros es la contraseña";
            }
        }

        private void ResetErrores()
        {
            ErrorTransaccione.Visible = false;
            ErrorTransaccione.InnerText = "";
            ErrorTarjeta.Visible = false;
            ErrorTarjeta.InnerText = "";
        }
    }
}