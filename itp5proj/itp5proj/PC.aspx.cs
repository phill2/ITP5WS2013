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
            String conn = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(conn))
            {
                myConnection.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Games WHERE kategorie='PC'", myConnection);
                SqlDataReader reader = comm.ExecuteReader();
                posts.DataSource = reader;
                posts.DataBind();
                reader.Close();
                reader = comm.ExecuteReader();
                while(reader.Read()){
                    ddl.Items.Add(reader.GetString(1));
                    ddl.SelectedItem.Value = Convert.ToString(reader.GetInt32(0));
                }
                reader.Close();
                myConnection.Close();
            }
        }

        protected void scom_Click(object sender, EventArgs e)
        {
            String conn = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(conn))
            {
                myConnection.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Comments (id, body, uid, gid) VALUES (@id, @body, @uid, @gid)", myConnection);
                SqlDataReader rd = new SqlCommand("SELECT sum(id) FROM Comments", myConnection).ExecuteReader();
                rd.Read();
                comm.Parameters.Add(new SqlParameter("id", rd.GetInt32(0)+1));
                comm.Parameters.Add(new SqlParameter("body", commt.Text));
                comm.Parameters.Add(new SqlParameter("uid", Convert.ToInt32(Request.Cookies["idval"].Value)));
                comm.Parameters.Add(new SqlParameter("gid", ddl.SelectedItem.Value));
                rd.Close();
                myConnection.Close();
            }
        }
    }
}