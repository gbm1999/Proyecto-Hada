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
            if (!IsPostBack)
            {
                ResetErrores();
                Admin.Visible = false;
            }

            ResetErrores();
        }

        protected void register_Click(object sender, EventArgs e)
        {
            if (true)//!isVacio())  // No hay nada Vacío        ↓↓↓ 
            {
                if (password.Text != password2.Text) // Contraseñas Coinciden       ↓↓↓
                {
                    errorpass.Visible = true;
                    errorpass.Text = "Las Contraseñas No coinciden";
                    errorcpass.Visible = true;
                    errorcpass.Text = "Revisa las Mayúsculas o.o";
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
                                erroradmin.Text = "Vaya! ¿Estás seguro de ser un Administrador?";
                                Admincheck.Checked = false;
                            }
                            else
                                admin = true;
                        }
                        if (CompruebaValores()) // Si todo va bien Creo el Usuario
                        {
                            user.nombreUsuario = name.Text;
                            user.emailUsuario = email.Text;
                            user.edadUsuario = Convert.ToInt32(age.Text);
                            user.telefonoUsuario = Convert.ToInt32(phone.Text);
                            user.contrasenaUsuario = Global.Encrypt(password.Text);
                            user.balance = 0;

                            if (user.createUsuario())
                            {
                                Response.Redirect("Login.aspx");
                                if (admin)
                                    Creadmin(user);
                            }

                            else
                            {
                                errorname.Visible = true;
                                errorname.Text = "Vaya! Parece que algo ha ido mal :(";
                            }
                        }
                    }
                    else
                    {
                        errornif.Visible = true;
                        errornif.Text = "Vaya! Parece que ya eres de la familia!";
                    }
                }
                else
                {
                    errorpass.Visible = true;
                    errorpass.Text = "7 a 16 Caracteres y al menos 1 Mayúscula Símbolo y Número.";

                }
            }
        }
        protected void Admincheck_CheckedChanged(object sender, EventArgs e)
        {
            Admin.Visible = Admincheck.Checked;
            if (!Admincheck.Checked)
                Admin.Text = "";
        }
        private void Creadmin(ENUsuario user)
        {
            ENAdministrador admin = new ENAdministrador(user.NIFUsuario);

            admin.createAdministrador();
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
                    errorname.Text = "Eres un Robot? :/";
                }
                else if (!CampoVálidoNif(NIF.Text))
                {
                    validos = false;
                    errornif.Visible = true;
                    errornif.Text = "Vaya! Ese Nif es Incorrecto";
                }
                else if (!CampoVálidoPass(password.Text))
                {
                    validos = false;
                    errorpass.Visible = true;
                    errorpass.Text = "7 a 16 Caracteres y al menos 1 Mayúscula Símbolo y Número.";
                }
                else if (!CampoVálidoAge(Convert.ToInt32(age.Text)))
                {
                    validos = false;
                    errorage.Visible = true;
                    errorage.Text = "Vaya! Parece que Tu edad es errónea :/";
                }
                else if(!CampoVálidoEmail(email.Text))
                {
                    validos = false;
                    erroremail.Visible = true;
                    erroremail.Text = "Vaya! Ese email no es correcto D:";
                }
                else if(!CampoVálidoTlf(phone.Text))
                {
                    validos = false;
                    errortlf.Visible = true;
                    errortlf.Text = "Vaya! Ese Teléfono no es correcto :(";
                }
                else if (!CampoVálidoPass(Admin.Text) && Admincheck.Checked)
                {
                    validos = false;
                    erroradmin.Visible = true;
                    erroradmin.Text = "7 a 16 Caracteres y al menos 1 Mayúscula Símbolo y Número.";
                }
            }
            catch (Exception)
            {
                validos = false;
                errorage.Visible = true;
                errorage.Text = "Vaya! Parece que Tu edad es errónea :/";
            }
           
            return validos;
        }
        private bool isVacio()
        {
            bool vacio = false;

            if (RequiredFieldValidator1.IsValid)
            {   
                vacio = true;
            }
            else if (RequiredFieldValidator2.IsValid)
            {
                vacio = true;
            }
            else if (RequiredFieldValidator3.IsValid)
            {
                vacio = true;
            }
            else if (RequiredFieldValidator4.IsValid)
            {
                vacio = true;
            }
            else if (RequiredFieldValidator5.IsValid)
            {
                vacio = true;
            }
            else if (RequiredFieldValidator6.IsValid)
            {
                vacio = true;
            }
            else if (RequiredFieldValidator7.IsValid)
            {
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
            if (check.Length < 2 || check.Length > 30)
            {
                valido = false;
            }
            

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

            if (check.Length < 7 || Global.Encrypt(check).Length > 200)
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