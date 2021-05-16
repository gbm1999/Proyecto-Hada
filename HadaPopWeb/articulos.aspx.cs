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
                Session["click"] = 0;
                IniciarLlenadoDropDown();
                ENArticulo arti = new ENArticulo();
                CargarArticulos2(0,arti.showArticles());
            }
        }
        private void IniciarLlenadoDropDown()
        {
            ENCategoria categoria = new ENCategoria();
            DropDownList1.DataSource = categoria.MostrarCategorias();
            DropDownList1.DataTextField = "NombreCategoria";
            DropDownList1.DataValueField = "NombreCategoria";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Inicio", "0"));
        }

        private void CargarArticulos2(int contador, ArrayList lista)
        {

            for (int i = 0; i < 12; i++)
            {
                ContentPlaceHolder Main = (ContentPlaceHolder)Page.Master.FindControl("ContentPlaceHolder1");
                Label lb = (Label)Main.FindControl("Label" + i);
                lb.Text = "";
            }


            Session["click"] = contador;
            bool seLee1 = false;
            ENArticulo arti = new ENArticulo();
            seLee1 = false;
            int lleva = (int)Session["click"];
            int j = 0;
            for (int i = lleva; i < lleva+12; i++)
            {
                ContentPlaceHolder Main = (ContentPlaceHolder)Page.Master.FindControl("ContentPlaceHolder1");
                ImageButton im = (ImageButton)Main.FindControl("ImageButton" + j);
                if (lista.Count > i)
                {
                    arti = (ENArticulo)lista[i];
                    Label lb = (Label)Main.FindControl("Label" + j);
                    lb.Text = arti.nombreArticulo;
                    im.Style["Visibility"] = "visible";
                    Session["click"] = i;
                }
                else
                {
                    im.Style["Visibility"] = "hidden";
                }
                j++;
            }
            int p = Convert.ToInt32(Session["click"]);

            if (seLee1)
            {
                /*
                byte[] imagen = art.getImagen();
                //Falta comprobar si hay datos en la base de datos
                if (imagen != null)
                {
                    j = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        string PROFILE_PIC = Convert.ToBase64String(imagen);
                        ContentPlaceHolder Main = (ContentPlaceHolder)Page.Master.FindControl("ContentPlaceHolder1");
                        ImageButton image = (ImageButton)Main.FindControl("ImageButton" + j);
                        image.ImageUrl = String.Format("data:image/jpg;base64,{0}", PROFILE_PIC);
                        j++;
                    }

                }
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
        private ArrayList ObtieneLista()
        {
            ArrayList lista = new ArrayList();
            ENArticulo arti = new ENArticulo();
            if (DropDownList1.SelectedValue == "0")
            {
                lista = arti.showArticles();
            }
            else
            {
                ENCategoria cate = new ENCategoria
                {
                    NombreCategoria = DropDownList1.Items[DropDownList1.SelectedIndex].Text,
                    DescripCategoria = null
                };

                lista = arti.showArticlesFromCategory(cate);
            }
            return lista;
        }

        protected void imgArticle0_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label0.Text);
        }

        protected void imgArticle1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label1.Text);
        }

        protected void imgArticle2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label2.Text);
        }

        protected void imgArticle3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label3.Text);
        }

        protected void imgArticle4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label4.Text);
        }
        protected void imgArticle5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label5.Text);
        }
        protected void imgArticle6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label6.Text);
        }

        protected void imgArticle7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label7.Text);
        }

        protected void imgArticle8_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label8.Text);
        }

        protected void imgArticle9_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label9.Text);
        }

        protected void imgArticle10_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label10.Text);
        }

        protected void imgArticle11_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowArticle.aspx?Value=" + Label11.Text);
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList lista = ObtieneLista();
            Session["click"] = 0;
            CargarArticulos2(0, lista);
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
            ENArticulo arti = new ENArticulo
            {
                codigoArticulo = -1,
                nombreArticulo = nombreArt.Text,
                descripcionArticulo = null,
                categoriaArticulo = null,
                precioArticulo = -1.0f,
                ciudadArticulo = null,
                compradorArticulo = null,
                vendedorArticulo = null,
                imagenArticulo = null
            };
            ArrayList lista = new ArrayList();
            lista = arti.searchArticulo();
            if (lista.Count > 0)
            {
                arti = (ENArticulo)lista[0];
                DropDownList1.SelectedValue = arti.categoriaArticulo;
            }
            CargarArticulos2(0, lista);
        }
        protected void Prev_Click(object sender, EventArgs e)
        {
            int contador = Convert.ToInt32(Session["click"])-12;
                if(contador >= 0)
            {
                ArrayList lista = ObtieneLista();
                CargarArticulos2(contador, lista);
            }
        }
        protected void Next_Click(object sender, EventArgs e)
        {
            if ((int)Session["click"] >= 11 && (int)Session["click"] % 11 == 0)
            {
                int contador = Convert.ToInt32(Session["click"]) + 1;
                ArrayList lista = ObtieneLista();
                CargarArticulos2(contador, lista);
            }
        }
    }
}