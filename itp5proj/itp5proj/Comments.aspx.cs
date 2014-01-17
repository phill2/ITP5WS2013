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
    public partial class Comments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String conn = WebConfigurationManager.ConnectionStrings["mobile"].ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(conn))
            {
                myConnection.Open();
                SqlCommand comm = new SqlCommand("SELECT body, title FROM Comments JOIN Games ON Comments.gid=Games.id", myConnection);
                SqlDataReader reader = comm.ExecuteReader();
                commies.DataSource = reader;
                commies.DataBind();
                reader.Read();
                reader.Close();
                myConnection.Close();
            }
        }
    }
}