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
			}
			else
            {
				string urlImage = "images/sinperfil.png";
				ImageUser.ImageUrl = urlImage;
				PopupNoLogin.Show();
			}

			Butt_Env.Visible = false;

			TBNombre.ReadOnly = true;
			TBEmail.ReadOnly = true;
			TBNif.ReadOnly = true;		//Textboxes No-Editables
			TBEdad.ReadOnly = true;
			TBTelefono.ReadOnly = true;

			Cambiacolor(System.Drawing.Color.LightGray);
		}
		protected ENUsuario obtencionNif()
		{
			ENUsuario user = new ENUsuario();

			user.NIFUsuario = (string)Session["nif"];

			return (user);
		}
		protected void Enviar(object sender, EventArgs e)
		{
			Butt_Env.Visible = false;
			Butt_Edit.Enabled = true;
			SwitchRead(true);
			Cambiacolor(System.Drawing.Color.LightGray);

			ENUsuario user = obtencionNif();

			user.nombreUsuario = TBNombre.Text;
			user.emailUsuario = TBEmail.Text;
			user.NIFUsuario = TBNif.Text;
			user.edadUsuario = int.Parse(TBEdad.Text);
			user.telefonoUsuario = int.Parse(TBTelefono.Text);

			user.updateUsuario();
		}
		protected void Editar(object sender, EventArgs e)
		{
			Butt_Env.Visible = true;
			Butt_Edit.Enabled = false;
			SwitchRead(false);
			Cambiacolor(System.Drawing.Color.White);
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

		protected void PopUpLogin(object sender, EventArgs e)
		{
			Response.Redirect("Login.aspx");
		}
	}
}