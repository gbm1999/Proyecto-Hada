using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HadaPopWeb
{
	public partial class Profile : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Butt_Env.Visible = false;

			TBNombre.Disabled = true;
			TBEmail.Disabled = true;
			TBNif.Disabled = true;		//Textboxes No-Editables
			TBEdad.Disabled = true;
			TBTelefono.Disabled = true;

			//NumCompras = 
			
		}
		protected void Enviar(object sender, EventArgs e)
		{
			Butt_Env.Visible = false;
			Butt_Edit.Enabled = true;
			SwitchEditable(true);

		}
		protected void Editar(object sender, EventArgs e)
		{
			Butt_Env.Visible = true;
			Butt_Edit.Enabled = false;
			SwitchEditable(false);
		}

		void SwitchEditable(bool editable)
        {
			TBNombre.Disabled = editable;
			TBEmail.Disabled = editable;
			TBNif.Disabled = editable;
			TBEdad.Disabled = editable;
			TBTelefono.Disabled = editable;
		}
	}
}