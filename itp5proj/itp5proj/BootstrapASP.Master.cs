using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace itp5proj
{
        public partial class BootstrapASP : System.Web.UI.MasterPage
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                HttpCookie nc = Request.Cookies["logincookie"];
                if (nc != null)
                {
                    logintext.Text = "Logged in as " + nc["nickname"];
                    logintext.Visible = true;
                    LogoutKlick.Visible = true;
                }
            }

            protected void Button1_Click(object sender, EventArgs e)//Login
            {
                UserDB ins=new UserDB();
                crypt c = new crypt();
                List<String> ret = ins.Read_Login(lname.Text, c.GetMd5Hash(pwd.Text));
                
                    if (ret.Count != 0)
                    {
                        logintext.Text = "Logged in as " + ret[0].Split(((char)007))[1];
                        logintext.Visible = true;
                        LogoutKlick.Visible = true;

                        HttpCookie nc = new HttpCookie("logincookie");
                        nc.Values.Add("nickname", ret[0].Split(((char)007))[1]);
                        nc.Values.Add("id", ret[0].Split(((char)007))[0]);
                        nc.Values.Add("type", ret[0].Split(((char)007))[2]);
                        nc.Expires = DateTime.Now.AddMinutes(15);
                        Response.Cookies.Add(nc);
                    }
                    else
                    {
                        logintext.Text = "Invalid login data";
                        logintext.Visible = true;
                    }
                }

            protected void LogoutKlick_Click(object sender, EventArgs e)
            {
                LogoutKlick.Visible = false;
                HttpCookie nc = Request.Cookies["logincookie"];
                try
                {
                    nc.Expires = DateTime.Now.AddDays(-1d);
                }
                catch (NullReferenceException) { }
                Response.Cookies.Add(nc);
                logintext.Visible = false;

            }
       }
}
    
