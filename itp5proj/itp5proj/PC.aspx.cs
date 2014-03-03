using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace itp5proj
{
    public partial class PC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GamesDB ins = new GamesDB();
            List<String> glist = ins.Read_Category("PC");
            CommentsDB ins2=new CommentsDB();
            List<String> clist = ins2.Read_Comments();
            ScoresDB ins3 = new ScoresDB();
            List<String> slist = ins3.Read_Scores();
            for (int i=0; i < glist.Count;i++ )
            {
                ddl.Items.Add(new ListItem(glist[i].Split(((char)007))[1], glist[i].Split(((char)007))[0]));
                ddl2.Items.Add(new ListItem(glist[i].Split(((char)007))[1], glist[i].Split(((char)007))[0]));
                TableCell tc1 = new TableCell();
                tc1.Text = "<b>" + glist[i].Split(((char)007))[1] + "</b><br/>" + glist[i].Split(((char)007))[2];
                TableCell tc2 = new TableCell();
                //tc2.Text = "<asp:Image ImageUrl=\"" + glist[i].Split(((char)007))[4] + "\" runat=\"server\"/>";
                tc2.Text = "<img src=\"" + glist[i].Split(((char)007))[4] + "\" width=\"150\" height=\"200\">";
                TableRow tr = new TableRow();
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                gc.Rows.Add(tr);
                for (int j=0; j < clist.Count ;j++ )
                {
                    if (glist[i].Split(((char)007))[0] == clist[j].Split(((char)007))[1])
                    {
                        TableCell ntc1 = new TableCell();
                        ntc1.Text = "<b>Comment by " + clist[j].Split(((char)007))[2] + "</b><br/>" + clist[j].Split(((char)007))[0];
                        TableRow ntr = new TableRow();
                        ntr.Cells.Add(ntc1);
                        gc.Rows.Add(ntr);
                        //TableCell ntc2 = new TableCell();
                        //ntc2.Text = clist[j].Split(((char)007))[0];
                    }
                }
            }

            HttpCookie nc = Request.Cookies["logincookie"];
            if (nc != null)
            {
                scom.Enabled = true;
                sr.Enabled = true;
                clo.Visible = false;
            }
        }

        protected void scom_Click(object sender, EventArgs e)
        {
            CommentsDB ins = new CommentsDB();
            List<String> ls = new List<String>();
            ls.Add(commt.Text);
            ls.Add(Request.Cookies["logincookie"]["id"]);
            ls.Add(ddl.SelectedItem.Value);
            ins.Create_New_Comment(ls);
                /*SqlCommand comm = new SqlCommand("INSERT INTO Comments (id, body, uid, gid) VALUES (@id, @body, @uid, @gid)", myConnection);
                SqlDataReader rd = new SqlCommand("SELECT count(id) FROM Comments", myConnection).ExecuteReader();
                comm.Parameters.Add(new SqlParameter("id", rd.GetInt32(0) + 1));
                comm.Parameters.Add(new SqlParameter("body", commt.Text));
                comm.Parameters.Add(new SqlParameter("uid", Request.Cookies["logincookie"]["nickname"]));
                comm.Parameters.Add(new SqlParameter("gid", ddl.SelectedItem.Value));*/
                

         }

        protected void sr_Click(object sender, EventArgs e)
        {
            ScoresDB ins = new ScoresDB();
            List<String> ls = new List<String>();
            ls.Add(score.Text);
            ls.Add(Request.Cookies["logincookie"]["id"]);
            ls.Add(ddl2.SelectedItem.Value);
            ins.Create_New_Score(ls);
        }
    }
}