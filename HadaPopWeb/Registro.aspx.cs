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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ResetErrores();
            Admin.Visible = false;
            
        }

        protected void register_Click(object sender, EventArgs e)
        {

            if (!isVacio())  // No hay nada Vacío        ↓↓↓ 
            {
                if (password.Text != password2.Text) // Contraseñas Coinciden       ↓↓↓
                {
                    errorpass.Visible = true;
                    errorpass.InnerText = "Las Contraseñas No coinciden";
                    errorcpass.Visible = true;
                    errorcpass.InnerText = "Revisa las Mayúsculas o.o";
                }
                else if(CampoVálidoPass(password.Text))
                {
                    ENUsuario user = new ENUsuario();
                    bool admin = false;

                    user.NIFUsuario = NIF.Text;
                    if (!user.readUsuario())                           // No existe el Usuario       ↓↓↓
                    {
                        if(Admincheck.Checked)      // Es un UsuAdmin
                        {
                            if (Admin.Text != Global.ADMINPASS)
                            {
                                erroradmin.Visible = true;
                                erroradmin.InnerText = "Vaya! ¿Estás seguro de ser un Administrador?";
                                Admincheck.Checked = false;
                            }
                            else
                                admin = true;
                        }
                        else
                        {
                            if (CompruebaValores()) // Si todo va bien Creo el Usuario
                            {
                                user.nombreUsuario = name.Text;
                                user.emailUsuario = email.Text;
                                user.edadUsuario = Convert.ToInt32(age.Text);
                                user. = admin;
                                user.telefonoUsuario = Convert.ToInt32(phone.Text);
                                user.contrasenaUsuario = password.Text;

                                user.createUsuario();

                                Response.Redirect("Login.aspx");
                            }

                        }

                    }
                    else
                    {
                        errornif.Visible = true;
                        errornif.InnerText = "Vaya! Parece que ya eres de la familia!";
                    }


                }
                else
                {
                    errorpass.Visible = true;
                    errorpass.InnerText = "7 a 16 Caracteres y al menos 1 Mayúscula Símbolo y Número.";

                }
            }
        }
        protected void Admincheck_CheckedChanged(object sender, EventArgs e)
        {
            Admin.Visible = Admincheck.Checked;
        }

        private bool CompruebaValores()
        {
            bool validos = true;
            try
            {
                int edad = Convert.ToInt32(age.Text);
                if (!CampoVálidoUser(name.Text))
                {
                    validos = false;
                    errorname.Visible = true;
                    errorname.InnerText = "Eres un Robot? :/";
                }
                else if (!CampoVálidoNif(NIF.Text))
                {
                    validos = false;
                    errornif.Visible = true;
                    errornif.InnerText = "Vaya! Ese Nif es Incorrecto";
                }
                else if (!CampoVálidoPass(password.Text))
                {
                    validos = false;
                    errorpass.Visible = true;
                    errorpass.InnerText = "7 a 16 Caracteres y al menos 1 Mayúscula Símbolo y Número.";
                }
                else if (!CampoVálidoAge(Convert.ToInt32(age.Text)))
                {
                    validos = false;
                    errorage.Visible = true;
                    errorage.InnerText = "Vaya! Parece que Tu edad es errónea :/";
                }
                else if(!CampoVálidoEmail(email.Text))
                {
                    validos = false;
                    erroremail.Visible = true;
                    erroremail.InnerText = "Vaya! Ese email no es correcto D:";
                }
                else if(!CampoVálidoTlf(phone.Text))
                {
                    validos = false;
                    errortlf.Visible = true;
                    errortlf.InnerText = "Vaya! Ese Teléfono no es correcto :(";
                }
                else if (!CampoVálidoPass(Admin.Text) && Admincheck.Checked)
                {
                    validos = false;
                    erroradmin.Visible = true;
                    erroradmin.InnerText = "7 a 16 Caracteres y al menos 1 Mayúscula Símbolo y Número.";
                }
            }
            catch (Exception)
            {
                validos = false;
                errorage.Visible = true;
                errorage.InnerText = "Vaya! Parece que Tu edad es errónea :/";
            }
           
            return validos;
        }
        private bool isVacio()
        {
            bool vacio = false;

            if (name.Text.Length == 0)
            {
                errorname.Visible = true;
                errorname.InnerText = "Campo Obligatorio*";
                vacio = true;
            }
            else if (NIF.Text.Length == 0)
            {
                errornif.Visible = true;
                errornif.InnerText = "Campo Obligatorio*";
                vacio = true;
            }
            else if (password.Text.Length == 0)
            {
                errorpass.Visible = true;
                errorpass.InnerText = "Campo Obligatorio*";
                vacio = true;
            }
            else if (age.Text.Length == 0)
            {
                errorage.Visible = true;
                errorage.InnerText = "Campo Obligatorio*";
                vacio = true;
            }
            else if (phone.Text.Length == 0)
            {
                errortlf.Visible = true;
                errortlf.InnerText = "Campo Obligatorio*";
                vacio = true;
            }
            else if (password2.Text.Length == 0)
            {
                errorcpass.Visible = true;
                errorcpass.InnerText = "Campo Obligatorio*";
                vacio = true;
            }
            else if (email.Text.Length == 0)
            {
                erroremail.Visible = true;
                erroremail.InnerText = "Campo Obligatorio*";
                vacio = true;
            }

            return vacio;
        }
        private void ResetErrores()
        {
            errorname.Visible = false;
            errorage.Visible = false;
            erroradmin.Visible = false;
            erroremail.Visible = false;
            errornif.Visible = false;
            errortlf.Visible = false;
            errorpass.Visible = false;
            errorcpass.Visible = false;
        }
        private bool CampoVálidoUser(string check) //Comprueba si la cadena pasada es válida para ser Nombre de User
        { 
            bool valido = true;
            Regex r = new Regex(@"^[^±!@£$% ^&*_ +§¡€#¢§¶•ªº«\\/<>?:;|=.,]{1,20}$");
            if (check.Length < 2 || check.Length > 30)
            {
                valido = false;
            }
            else if (r.IsMatch(check))  // Comprueba nombre
                valido = false;

            return valido;
        }
        private bool CampoVálidoEmail(string check) //Comprueba si la cadena pasada es válida para ser mail de Email
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
            else if (check[check.Length - 1] == '.')
                valido = false;

            return valido;
        }
        private bool CampoVálidoNif(string check) //Comprueba si la cadena pasada es válida para ser mail de Nif
        {                                                          

            bool valido = true;
            Regex r = new Regex(@"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]$");
            if (check.Length != 9)
            {
                valido = false;
            }
            else if (!r.IsMatch(check))  // Comprueba Nif
                valido = false;

            return valido;
        }
        private bool CampoVálidoPass(string check) //Comprueba si la cadena pasada es válida para ser Contraseña
        {                                      
            bool valido = true;
            Regex num = new Regex("[0-9]+");
            Regex mayus = new Regex(@"[A-Z]+");
            Regex minus = new Regex(@"[a-z]+");

            if (check.Length < 7 || check.Length > 16)
            {
                valido = false;
            }
            if (!(num.IsMatch(check) && mayus.IsMatch(check) && minus.IsMatch(check))) //Contiene al menos 1 Mayúscula, 1 número, 
                valido = false;

            return valido;
        }
        private bool CampoVálidoAge(int check) //Comprueba si la cadena pasada es válida para ser una edad
        { 
            bool valido = true;

            if (check < 18 || check > 120)
                valido = false;
            

            return valido;
        }
        private bool CampoVálidoTlf(string check) //Comprueba si la cadena pasada es válida para ser un teléfono
        {
            bool valido = true;
            Regex r = new Regex("(([6][0-9]{8}$)|([7][1-9]{1}[0-9]{7}$))");

            if (check.Length != 9)
            {
                valido = false;
            }
            if (!(r.IsMatch(check))) 
                valido = false;

            return valido;
        }

    }
}