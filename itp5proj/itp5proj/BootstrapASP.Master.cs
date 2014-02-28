using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace itp5proj
{

    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Web;
    using System.Web.Configuration;
    using System.Web.UI;
    using System.Web.UI.WebControls;

        public partial class BootstrapASP : System.Web.UI.MasterPage
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                HttpCookie nc = Request.Cookies["logincookie"];
                if (nc != null)
                {
                    logintext.Text = "Logged in as " + nc.Value;
                    logintext.Visible = true;
                    LogoutKlick.Visible = true;
                }
            }

            protected void Item_Click(object sender, EventArgs e)
            {
                //ifr.Src = Menu.SelectedValue + ".aspx";
                
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                String conn = WebConfigurationManager.ConnectionStrings["mobile"].ConnectionString;
                using (SqlConnection myConnection = new SqlConnection(conn))
                {
                    myConnection.Open();
                    SqlCommand comm = new SqlCommand("SELECT id, username, acctype FROM Users WHERE username=@una AND password=@pwd", myConnection);
                    comm.Parameters.Add(new SqlParameter("una", lname.Text));
                    comm.Parameters.Add(new SqlParameter("pwd", pwd.Text));
                    SqlDataReader reader = comm.ExecuteReader();
                    reader.Read();
                    if (reader.GetString(1) == lname.Text)
                    {
                        logintext.Text = "Logged in as " + reader.GetString(1);
                        logintext.Visible = true;
                        LogoutKlick.Visible = true;

                        HttpCookie nc = new HttpCookie("logincookie");
                        nc.Value = reader.GetString(1);
                        nc.Expires = DateTime.Now.AddMinutes(15);
                        Response.Cookies.Add(nc);
                        HttpCookie ic = new HttpCookie("idval");
                        ic.Value = reader.GetInt32(0).ToString();
                        nc.Expires = DateTime.Now.AddMinutes(15);
                        Response.Cookies.Add(ic);
                        if (reader.GetString(2) == "admin")
                        {
                            //MenuItem mi = new MenuItem();
                            //mi.Text = "Admin Panel";
                            //mi.Value = "Admin";
                            //Menu.Items.Add(mi);
                        }
                    }
                    else
                    {
                        logintext.Text = "Invalid login data";
                        logintext.Visible = true;
                    }
                    reader.Close();
                    myConnection.Close();
                }
            }

            protected void LogoutKlick_Click(object sender, EventArgs e)
            {
                LogoutKlick.Visible = false;
                HttpCookie nc = Request.Cookies["logincookie"];
                nc.Expires = DateTime.Now;
                Response.Cookies.Add(nc);
                nc = Request.Cookies["idval"];
                nc.Expires = DateTime.Now;
                Response.Cookies.Add(nc);
                logintext.Visible = false;

            }
        }
    }
