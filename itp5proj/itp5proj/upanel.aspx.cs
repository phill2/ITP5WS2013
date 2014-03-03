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
                paneltext.Visible = false;
                reg.Visible = true;
                if (nc["type"] == "moderator" || nc["type"] == "admin") mod.Visible = true;
                if (nc["type"] == "admin")
                {
                    adm.Visible = true;
                    UserDB ins = new UserDB();
                    List<String> ls = ins.Read_Users();
                    for (int i = 0; i < ls.Count; i++)
                    {
                        if (ls[i].Split(((char)007))[0] != nc["nickname"])
                        {
                            uss.Items.Add(new ListItem(ls[i].Split(((char)007))[0] + " is " + ls[i].Split(((char)007))[3], ls[i].Split(((char)007))[2]));
                        }
                    }
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            UserDB ins=new UserDB();
            crypt c = new crypt();
            List<String> ret = ins.Read_Login(Request.Cookies["logincookie"]["nickname"], c.GetMd5Hash(cp.Text));
            if (ret.Count != 0)
            {
                if (np.Text != npc.Text)
                {
                    warn.Text = "New Password and Confirmation must match!";
                    warn.Visible = true;
                }
                else
                {
                    ret = new List<String>();
                    ret.Add(Request.Cookies["logincookie"]["nickname"]);
                    ret.Add(c.GetMd5Hash(cp.Text));
                    ret.Add(c.GetMd5Hash(np.Text));
                    ins.Update_Password(ret);
                }
            }
            else
            {
                warn.Text = "Current password incorrect!";
                warn.Visible = true;
            }
        }

        protected void usc(object sender, EventArgs e)
        {
            UserDB ins = new UserDB();
            if (ca.SelectedValue != "3")
            {
                if (ca.SelectedValue == "2") ins.Update_User(uss.SelectedValue, "moderator");
                else ins.Update_User(uss.SelectedValue, "regular");
            }
            else
            {
                ins.Delete_User(uss.SelectedValue);
            }
        }

        protected void addgame(object sender, EventArgs e)
        {
            GamesDB ins = new GamesDB();
            List<String> ls = new List<String>();
            ls.Add(gt.Text);
            ls.Add(gd.Text);
            ls.Add(cc.Text);
            ls.Add(cl.Text);
            ins.Create_New_Game(ls);
        }
    }
}