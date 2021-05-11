using System;
using System.Web;
using library;

using System.Drawing;
namespace HadaPopWeb
{
    public partial class articulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarArticulos();
            }
        }

        private void CargarArticulos()
        {
            bool seLee1 = false;
            ENArticulo art = new ENArticulo();
            seLee1 = art.readFirstArticulo();
            if (seLee1)
            {
            byte[] imagen = art.getImagen();
            string PROFILE_PIC = Convert.ToBase64String(imagen);
            //Falta comprobar si hay datos en la base de datos
            Image1.Src = String.Format("data:image/jpg;base64,{0}", PROFILE_PIC);
                /*
                nif.Text = usuario.nifUser;
                name.Text = usuario.nameUser;
                age.Text = usuario.ageUser.ToString();
                Label1.Text = "(STATUS-OK)" + nif.Text + ", " + name.Text + ", " + age.Text;
                Label2.Text = " ";
                */
            }
            else
            {
                /*
                Label1.Text = " ";
                Label2.Text = "**Error** no se ha encontrado al usuario con nif ";
                */
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}