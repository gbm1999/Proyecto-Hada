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
            ENUsuario user = obtencionNif();

            if (!user.readUsuario())
            {
                PopupNoLogin.Show();
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
                articulo.codigoArticulo = articulo.countArticulo() + 1;
                articulo.nombreArticulo = name.Text;
                articulo.descripcionArticulo = description.Text;
                articulo.categoriaArticulo = categoria.Text;
                articulo.precioArticulo = float.Parse(precio.Text);
                articulo.ciudadArticulo = ciudad.Text;
                articulo.vendedorArticulo = user.NIFUsuario;

                // Obtener Imagen
                int tamanio = photo.PostedFile.ContentLength; //Obtenemos el tamano de la imagen
                byte[] ImagenOriginal = new byte[tamanio];          //Creo una imagen vacia con el tamano de la imagen importada
                photo.PostedFile.InputStream.Read(ImagenOriginal, 0, tamanio);    //Introducimos la imagen importada en la imagen local
                articulo.imagenArticulo = ImagenOriginal;

                if (articulo.createArticulo())
                {
                    Label1.Text = "El articulo se ha creado con éxito";
                }
                else
                {
                    Label1.Text = "**Error**";
                }
            }
            else
            {
                Label1.Text = "Por favor en el campo de precio inserte numeros solo";
            }
        }

        protected void PopUpLogin(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}