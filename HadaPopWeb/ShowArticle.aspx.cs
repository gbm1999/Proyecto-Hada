﻿using System;
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

            Precio.ReadOnly=false;
            articulo.nombreArticulo= Request.QueryString["Value"];
            articulo=articulo.showOneArticle();
            mostrarArticulo(articulo);
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
            bool updated = false;
            articulo.ciudadArticulo = Ciudad.Text;
            articulo.nombreArticulo = nombre.Text;
            articulo.precioArticulo = (float)Convert.ToDouble(Precio.Text);
            articulo.vendedorArticulo = vendedor.Text;
            articulo.descripcionArticulo = Descripcion.Text;
            updated = articulo.updateArticulo();  //No coge el texto nuevo de los textbox, si no el antiguo

            if (updated)
            {
                articulo = articulo.showOneArticle();

                Label1.Text = "El artículo se ha modificado correctamente.";

            }
            else
            {
                Label1.Text = "El artículo no se ha podido modificar.";
            }
            mostrarArticulo(articulo);

        }

    }
}