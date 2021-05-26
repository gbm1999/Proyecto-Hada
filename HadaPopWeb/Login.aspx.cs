using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace HadaPopWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResetErrores();

        }
        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string name, pass;
            name = pass = "";

            ResetErrores();
            name = email.Text;
            pass = password.Text;

                if (!CampoVálidoUser(name))
                {
                    errorname.Visible = true;
                    errorname.InnerText = "El email Introducido es Incorrecto";
                }
                if(!CampoVálidoPass(pass))                                    // Comprobradores de Normalización Datos
                {
                    errorpass.Visible = true;
                    errorpass.InnerText = "7 a 16 Caracteres y al menos 1 Mayúscula Símbolo y Número.";
                }
            if( CampoVálidoUser(name) && CampoVálidoPass(pass) )
            {
                ENUsuario user = new ENUsuario();

                user.emailUsuario = name;
                
               if( user.readUsuario() )     //  Existe? -> Es Correcto? -> Logeado
                {
                    if(Global.Decrypt(user.contrasenaUsuario) == pass )
                    {
                        Session.Clear();
                        Session.Add("user", user.nombreUsuario);
                        Session.Add("nif", user.NIFUsuario);
                        Response.Redirect("articulos.aspx");
                    }
                    else
                    {
                        errorpass.Visible = true;
                        errorpass.InnerText = "Vaya! Parece que esa contraseña no era :/";
                    }

                }
                else
                {
                    errorname.Visible = true;
                    errorname.InnerText = "Vaya! No hemos encontrado ese Usuario :O";
                }

            }
        }
        private bool CampoVálidoUser(string check) //Comprueba si la cadena pasada es válida para ser mail de Usuario
        {                                      // Para ser válida debe: -Estar entre 6 y 30 caracteres
                                                //                      - Contener un @ y .
                                                //                      - El . no ser el último dígito

            bool valido = true;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (check.Length < 6 || check.Length > 30)
            {
                valido = false;
            }
            else if (!r.IsMatch(check))  // Comprueba email
                valido = false;
            else if (check[check.Length-1] == '.')
                valido = false;

            return valido;
        }
        private bool CampoVálidoPass(string check) //Comprueba si la cadena pasada es válida para ser Contraseña
        {                                      // Para ser válida debe: -Estar entre 7 y 16 caracteres
                                               //                       -Contener
                                               //                        1 Mayúscula, 1 Minúscula
                                               //                        1 Símbolo, 1 Número
            bool valido = true;
            Regex num = new Regex("[0-9]+");
            Regex mayus = new Regex(@"[A-Z]+");
            Regex minus = new Regex(@"[a-z]+");

            if (check.Length < 7 || check.Length > 16)
            {
                valido = false;
            }
            if ( !(num.IsMatch(check) && mayus.IsMatch(check) && minus.IsMatch(check)) ) //Contiene al menos 1 Mayúscula, 1 número, 
                valido = false;

            return valido;
        }
    
        private void ResetErrores()
        {
            errorname.Visible = false;
            errorname.InnerText = "";
            errorpass.Visible = false;
            errorpass.InnerText = "";
        }
    }
}