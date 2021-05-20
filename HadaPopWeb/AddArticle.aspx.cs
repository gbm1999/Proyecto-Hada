using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HadaPopWeb
{
    public partial class AddArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ENUsuario user = obtencionNif();

                bool ok = false;

                if (!ok/*user.readUsuario()*/)
                {
                    //Balance.Text = user.balance.ToString() + "€";
                    //IniciarLlenadoDropDown();
                    //Nombre_Usuario.Text = user.nombreUsuario;
                }
                else
                {
                    //PopupNoLogin.Show();
                }
            }

            Label1.Text = "";
        }

        protected ENUsuario obtencionNif()
        {
            ENUsuario user = new ENUsuario();

            user.NIFUsuario = (string)Session["nif"];

            return (user);
        }

        protected void create_Click(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();
            ENArticulo articulo = new ENArticulo();
            float numero = 0;

            if(float.TryParse(precio.Text, out numero))
            {
                articulo.nombreArticulo = name.Text;
                articulo.descripcionArticulo = description.Text;
                articulo.categoriaArticulo = categoria.Text;
                articulo.precioArticulo = float.Parse(precio.Text);
                articulo.ciudadArticulo = ciudad.Text;
                articulo.vendedorArticulo = user.NIFUsuario;
                articulo.imagenArticulo = photo.FileBytes;

                if (articulo.createArticulo())
                {
                    Label1.Text = "El articulo se ha creado con éxito";
                }
                else
                {
                    Label1.Text = "**Error** El articulo ya existe";
                }
            }
            else
            {
                Label1.Text = "Por favor en el campo de precio inserte numeros solo";
            }
        }
    }
}