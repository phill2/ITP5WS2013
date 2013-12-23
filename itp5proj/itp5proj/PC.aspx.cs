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
                myConnection.Close();
            }
        }
    }
}