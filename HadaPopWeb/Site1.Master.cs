using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace HadaPopWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario user = obtencionNif();

			if(user.readUsuario())
            {
				actualizaFoto(user);
			}
        }

		protected ENUsuario obtencionNif()
		{
			ENUsuario user = new ENUsuario();

			user.NIFUsuario = (string)Session["nif"];

			return (user);
		}

		public void actualizaFoto(ENUsuario user)
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

			if (user.nombreUsuario == null)
			{
				NombreUser.Text = "Usuario no logeado";
			}
			else
			{
				NombreUser.Text = user.nombreUsuario;
			}
		}

		protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}