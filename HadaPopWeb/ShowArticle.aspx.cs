using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace HadaPopWeb
{
    public partial class ShowArticle : System.Web.UI.Page
    {
        ENArticulo articulo = new ENArticulo();


        protected void Page_Load(object sender, EventArgs e)
        {
            vendedor.ReadOnly = true;
            numero.ReadOnly = true;
            Precio.ReadOnly=false;
            articulo.nombreArticulo= Request.QueryString["Value"];
            articulo=articulo.showOneArticle();
            if(!IsPostBack) mostrarArticulo(articulo);

        }

        private void mostrarArticulo(ENArticulo articulo)
        {
            nombre.Text = articulo.nombreArticulo;
            Ciudad.Text = articulo.ciudadArticulo;
            Descripcion.Text = articulo.descripcionArticulo;
            vendedor.Text = articulo.vendedorArticulo;
            Precio.Text = articulo.precioArticulo.ToString();
            
            ENUsuario usuarioVendedor = new ENUsuario();
            usuarioVendedor.NIFUsuario = vendedor.Text;

            usuarioVendedor.readUsuario();
            numero.Text = usuarioVendedor.telefonoUsuario.ToString();
        }

      

        protected void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Session["nif"]!=null && Session["nif"].ToString() == articulo.vendedorArticulo)
                {
                    if (!CampoValidoPrecio(Precio.Text))
                    {
                        errorprecio.Visible = true;
                        errorprecio.InnerText = "El precio Introducido no es un número";
                    }

                    else
                    {

                        errorprecio.InnerText = "";
                        ENArticulo articulo1 = new ENArticulo(articulo.codigoArticulo, nombre.Text, Descripcion.Text, articulo.categoriaArticulo, (float)Convert.ToDouble(Precio.Text),
                        Ciudad.Text, vendedor.Text, articulo.imagenArticulo);

                        if (articulo1.updateArticulo())
                        {

                            Label1.Text = "El artículo se ha modificado correctamente.";

                        }
                        else
                        {
                            Label1.Text = "El artículo no se ha podido modificar.";
                        }
                        mostrarArticulo(articulo1);
                    }
                }
                else Label1.Text = "No tienes permiso para modificar este artículo.";
            }
            catch(Exception ex)
            {
                Label1.Text = "No tienes permiso para modificar este artículo.";
                Console.WriteLine("No tienes permiso para modificar este artículo.", ex.Message);
            }
            
            

        }

        private bool CampoValidoPrecio(string check) //Comprueba si la cadena pasada es válida para ser precio
        {                                      // Para ser válida debe ser un número

            bool valido = false;

            if (int.TryParse(check, out _))
            {
                valido = true;
            }
           
            return valido;
        }
        protected void borrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Session["nif"] != null && Session["nif"].ToString() == articulo.vendedorArticulo)
                {

                    ENArticulo articulo1 = new ENArticulo(articulo.codigoArticulo, nombre.Text, Descripcion.Text, articulo.categoriaArticulo, (float)Convert.ToDouble(Precio.Text),
                    Ciudad.Text, vendedor.Text, articulo.imagenArticulo);

                    if (articulo1.deleteArticulo())
                    {

                        Label1.Text = "El artículo se ha borrado correctamente.";

                    }
                    else
                    {
                        Label1.Text = "El artículo no se ha podido eliminar.";
                    }

                    Response.Redirect("articulos.aspx");


                }
                else Label1.Text = "No tienes permiso para eliminar este artículo.";
            }
            catch (Exception ex)
            {
                Label1.Text = "No tienes permiso para eliminar este artículo.";
                Console.WriteLine("No tienes permiso para eliminar este artículo.", ex.Message);
            }
        }




    }
}