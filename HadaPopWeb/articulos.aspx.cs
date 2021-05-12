using System;
using library;
using System.Web.UI.WebControls;
using System.Windows;
using System.Collections;

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
                //Falta comprobar si hay datos en la base de datos
                if (imagen != null)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        string PROFILE_PIC = Convert.ToBase64String(imagen);
                        ContentPlaceHolder Main = (ContentPlaceHolder)Page.Master.FindControl("ContentPlaceHolder1");
                        ImageButton image = (ImageButton)Main.FindControl("ImageButton" + i);
                        image.ImageUrl = String.Format("data:image/jpg;base64,{0}", PROFILE_PIC);
                    }

                }
            }
            else
            {
                /*
                Label1.Text = " ";
                Label2.Text = "**Error** no se ha encontrado al usuario con nif ";
                */
            }
        }

        protected void imgArticle0_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }
        protected void imgArticle5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }
        protected void imgArticle6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle8_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle9_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle10_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }

        protected void imgArticle11_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + nombreArt.Text);
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            ENCategoria cate = new ENCategoria
            {
                IdCategoria = -1,
                NombreCategoria = DropDownList1.Items[DropDownList1.SelectedIndex].Text,
                DescripCategoria = null
            };
            ENArticulo arti = new ENArticulo();
            lista = arti.showArticlesFromCategory(cate);
            lista = arti.showArticles();
            for (int i = 0; i < lista.Count && i < 12; i++)
            {
                if (lista[i] != null)
                {
                    arti = (ENArticulo)lista[i];
                    ContentPlaceHolder Main = (ContentPlaceHolder)Page.Master.FindControl("ContentPlaceHolder1");
                    Label lb = (Label)Main.FindControl("Label" + i);
                    lb.Text = arti.nombreArticulo;
                }
            }
        }
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreArt.Text))
            {

                MessageBox.Show("Debe completar el campo de búsqueda", "Info");

                return;

            }
            for (int i = 0; i < 12; i++)
            {
                ContentPlaceHolder Main = (ContentPlaceHolder)Page.Master.FindControl("ContentPlaceHolder1");
                Label lb = (Label)Main.FindControl("Label" + i);
                lb.Text = "";
            }
        }
    }
}