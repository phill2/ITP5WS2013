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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            String conn = WebConfigurationManager.ConnectionStrings["mobile"].ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(conn))
            {
                myConnection.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO Users (id, username, password, acctype, email) VALUES (@id, @un, @pwd, 'regular', @mail)", myConnection);
                SqlDataReader rd = new SqlCommand("SELECT count(id) FROM Users", myConnection).ExecuteReader();
                rd.Read();
                comm.Parameters.Add(new SqlParameter("id", (rd.GetInt32(0)+1)));
                comm.Parameters.Add(new SqlParameter("un", user.Text));
                comm.Parameters.Add(new SqlParameter("pwd", pwd.Text));
                comm.Parameters.Add(new SqlParameter("mail", email.Text));
                rd.Close();
                comm.ExecuteNonQuery();
                myConnection.Close();
            }
        }
    }
}