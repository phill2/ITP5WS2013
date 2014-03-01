using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace itp5proj
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie nc = Request.Cookies["logincookie"];
            if (nc != null)
            {
                reg.Visible = true;
                if (nc["type"] == "moderator" || nc["type"] == "admin") mod.Visible = true;
                if(nc["type"] == "admin")adm.Visible = true;
            }
        }
    }
}