using System;
using System.Web;
using library;

using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows;
using System.IO;

namespace HadaPopWeb
{
    public partial class articulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IniciarLlenadoDropDown();
                CargarArticulos();
            }
        }
        private void IniciarLlenadoDropDown()
        {
            ENCategoria categoria = new ENCategoria();
            DropDownList1.DataSource = categoria.MostrarCategorias();
            DropDownList1.DataTextField = "NombreCategoria";
            DropDownList1.DataValueField = "IdCategoria";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }
        protected void Button6_Click(object sender, EventArgs e)
        {

        }
        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {

        }

        protected void Button11_Click(object sender, EventArgs e)
        {

        }

        protected void Button12_Click(object sender, EventArgs e)
        {

        }
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(nombreArt.Text)){

           MessageBox.Show("Debe completar el campo de búsqueda","Info");

           return;

            }
                Response.Redirect("AddArticle.aspx?Value=" + nombreArt.Text);
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ENCategoria cate = new ENCategoria
            {
                IdCategoria = -1,
                NombreCategoria = DropDownList1.Items[DropDownList1.SelectedIndex].Text,
                DescripCategoria = null
            };
            ENArticulo arti = new ENArticulo();
            arti.showArticlesFromCategory(cate);

        }
    }
}