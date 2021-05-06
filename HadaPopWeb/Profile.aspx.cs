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

			TBNombre.ReadOnly = true;
			TBEmail.ReadOnly = true;
			TBNif.ReadOnly = true;		//Textboxes No-Editables
			TBEdad.ReadOnly = true;
			TBTelefono.ReadOnly = true;

			Cambiacolor(System.Drawing.Color.LightGray);

			//NumCompras = 

		}
		protected void Enviar(object sender, EventArgs e)
		{
			Butt_Env.Visible = false;
			Butt_Edit.Enabled = true;
			SwitchRead(true);
			Cambiacolor(System.Drawing.Color.LightGray);


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

	}
}