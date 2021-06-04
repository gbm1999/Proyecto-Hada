using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HadaPopWeb
{
    public partial class Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Facebook_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.facebook.com/HadaPop-110052567942091");
        }
    }
}