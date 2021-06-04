using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace HadaPopWeb
{
	public partial class Profile : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ENUsuario user = obtencionNif();

			if (user.readUsuario())
			{
				if(!IsPostBack)
                {
					Session["contador"] = 0;
				}

				actualizaFoto(user);
				cargarArticulos((int)Session["contador"], user);
				NumVenta.Text = user.CountSales().ToString();
				NumCompra.Text = user.CountBuys().ToString();

				ENComentario comentario = new ENComentario();

				comentario.NifUsuario = user.NIFUsuario;

				if(comentario.NifUsuario != null)
                {
					ArrayList comentarios = comentario.findComentarios();

					Comentarios.DataSource = comentarios;
					Comentarios.DataBind();
				}
				ArrayList lista = new ArrayList();
				ENArticulo arti = new ENArticulo();
				lista = arti.showArticlesFromUser(user);
				String articles = "";
				for(int i = 0;i < lista.Count; i++)
                {
					arti = (ENArticulo)lista[i];
					if (arti.compradorArticulo != null)
					{
						articles += "[" + arti.nombreArticulo + "]";
						if (arti.descripcionArticulo != null)
						{
							articles += " (" + arti.descripcionArticulo + ") ";
						}
						articles += '\n';
					}
                }
				//articulos.Text = articles; 
			}
			else
            {
				string urlImage = "images/sinperfil.png";
				ImageUser.ImageUrl = urlImage;
				PopupNoLogin.Show();
			}

			Butt_Env.Visible = false;

			if(!IsPostBack)
            {
				TBNombre.Text = user.nombreUsuario;
				TBEmail.Text = user.emailUsuario;
				TBNif.Text = user.NIFUsuario;
				TBEdad.Text = user.edadUsuario.ToString();
				TBTelefono.Text = user.telefonoUsuario.ToString();
			}

			TBNombre.ReadOnly = true;
			TBEmail.ReadOnly = true;
			TBNif.ReadOnly = true;		//Textboxes No-Editables
			TBEdad.ReadOnly = true;
			TBTelefono.ReadOnly = true;
			photo.Enabled = false;

			Cambiacolor(System.Drawing.Color.LightGray);
		}
		protected ENUsuario obtencionNif()
		{
			ENUsuario user = new ENUsuario();

			user.NIFUsuario = (string)Session["nif"];

			return (user);
		}

		protected void actualizaFoto(ENUsuario user)
        {
			string urlImage;
			if (user.imagenUsuario != null)
			{
				urlImage = "data:image/jpg;base64," + Convert.ToBase64String(user.imagenUsuario);
			}
			else
			{
				urlImage = "images/sinperfil.png";
			}

			ImageUser.ImageUrl = urlImage;
		}
		protected void actualizaFotoArticulo(ENArticulo articulo)
		{
			string urlImage;
			if (articulo.imagenArticulo != null)
			{
				urlImage = "data:image/jpg;base64," + Convert.ToBase64String(articulo.imagenArticulo);
			}
			else
			{
				urlImage = "images/depositphotos_324611040-stock-illustration-no-image-vector-icon-no.jpg";
			}

			Articulo.ImageUrl = urlImage;
		}
		protected void Enviar(object sender, EventArgs e)
		{
			Butt_Env.Visible = false;
			Butt_Edit.Enabled = true;
			SwitchRead(true);
			Cambiacolor(System.Drawing.Color.LightGray);
			int numero = 0;

			ENUsuario user = obtencionNif();

			if(user.readUsuario())
            {
				if(TBNombre.Text == "")
                {
					TBNombre.Text = user.nombreUsuario;
                }
				else
                {
					user.nombreUsuario = TBNombre.Text;
				}

				if (TBEmail.Text == "")
                {
					TBEmail.Text = user.emailUsuario;
                }
				else
                {
					user.emailUsuario = TBEmail.Text;
				}				

				if(TBNif.Text.Length > 9)
                {
					ErrorNif.Visible = true;
					ErrorNif.Text = "Este campo tiene que tener menos de 9 caracteres.";
					TBNif.Text = user.NIFUsuario;
				}
				else if (TBEdad.Text == "")
				{
					TBNif.Text = user.NIFUsuario;
				}
				else
                {
					user.NIFUsuario = TBNif.Text;
					ErrorNif.Visible = false;
				}

				if (!int.TryParse(TBEdad.Text, out numero))
				{
					ErrorEdad.Visible = true;
					ErrorEdad.Text = "Solo son validos numero.";
					TBEdad.Text = user.edadUsuario.ToString();
				}
				else if (int.Parse(TBEdad.Text) < 0)
                {
					ErrorEdad.Visible = true;
					ErrorEdad.Text = "La edad no puede ser negativa.";
					TBEdad.Text = user.edadUsuario.ToString();
				}
				else if(int.Parse(TBEdad.Text) > 120)
                {
					ErrorEdad.Visible = true;
					ErrorEdad.Text = "La edad no puede ser superior a 120 años.";
					TBEdad.Text = user.edadUsuario.ToString();
				}
				else if (TBEdad.Text == "")
				{
					TBEdad.Text = user.edadUsuario.ToString();
				}
				else
                {
					user.edadUsuario = int.Parse(TBEdad.Text);
					ErrorEdad.Visible = false;
				}

				if(!int.TryParse(TBTelefono.Text, out numero))
                {
					ErrorTelefono.Visible = true;
					ErrorTelefono.Text = "Solo son validos numero.";
					TBTelefono.Text = user.telefonoUsuario.ToString();
				}
				else if(TBTelefono.Text == "")
                {
					TBTelefono.Text = user.telefonoUsuario.ToString();
				}
				else
                {
					user.telefonoUsuario = int.Parse(TBTelefono.Text);
					ErrorTelefono.Visible = false;
				}

				// Obtener Imagen
				if (photo.PostedFile.ContentLength > 0)
				{
					int tamanio = photo.PostedFile.ContentLength; //Obtenemos el tamano de la imagen
					byte[] ImagenOriginal = new byte[tamanio];          //Creo una imagen vacia con el tamano de la imagen importada
					photo.PostedFile.InputStream.Read(ImagenOriginal, 0, tamanio);    //Introducimos la imagen importada en la imagen local
					user.imagenUsuario = ImagenOriginal;
				}

				user.updateUsuario();

				actualizaFoto(user);
			}
		}
		protected void Editar(object sender, EventArgs e)
		{
			Butt_Env.Visible = true;
			Butt_Edit.Enabled = false;
			SwitchRead(false);
			Cambiacolor(System.Drawing.Color.White);
			photo.Enabled = true;
		}

		void SwitchRead(bool editable)
        {
			TBNombre.ReadOnly = editable;
			TBEmail.ReadOnly = editable;
			TBNif.ReadOnly = editable;
			TBEdad.ReadOnly = editable;
			TBTelefono.ReadOnly = editable;
		}
		void Cambiacolor(System.Drawing.Color c)
        {
			TBNombre.BackColor = c;
			TBEmail.BackColor = c;
			TBNif.BackColor = c;
			TBEdad.BackColor = c;
			TBTelefono.BackColor = c; 
		}

		protected void cargarArticulos(int i, ENUsuario user)
        {
			ENArticulo articulo = new ENArticulo();
			ArrayList lista = articulo.showArticlesFromUser(user);

			if(lista.Count != 0 && (i >= 0 && i < lista.Count) )
            {
				LabelArticulo1.Visible = true;
				Articulo.Visible = true;
				NextButton.Visible = true;
				PrevButton.Visible = true;

				ENArticulo artiAux = (ENArticulo)lista[i];

				actualizaFotoArticulo(artiAux);
				LabelArticulo1.Text = artiAux.nombreArticulo;
			}
			else
            {
				Articulo.Visible = false;
				LabelArticulo1.Visible = false;
				NextButton.Visible = false;
				PrevButton.Visible = false;
			}
        }

		protected void PopUpLogin(object sender, EventArgs e)
		{
			Response.Redirect("Login.aspx");
		}
        protected void imgArticle1_Click(object sender, ImageClickEventArgs e)
        {
			Response.Redirect("ShowArticle.aspx?Value=" + LabelArticulo1.Text);
		}

        protected void Prev_Click(object sender, EventArgs e)
        {
			if ((int)Session["contador"] > 0)
			{
				Session["contador"] = (int)Session["contador"] - 1;
			}
		}

        protected void Next_Click(object sender, EventArgs e)
        {
			ENUsuario user = obtencionNif();
			ENArticulo articulo = new ENArticulo();
			ArrayList lista = articulo.showArticlesFromUser(user);

			if (lista.Count > (int)Session["contador"])
			{
				Session["contador"] = (int)Session["contador"] + 1;
			}
		}
    }
}