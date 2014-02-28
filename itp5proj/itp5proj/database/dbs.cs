using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace itp5proj
{
    public class dbs
    {
        public dbs()
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["mobile"].ConnectionString);
        }

        void Create()
        {
            con.Open();
            SqlCommand nc = new SqlCommand("INSERT INTO ... VALUES");
            nc.ExecuteNonQuery();
        }

        void Read()
        {
            con.Open();
            SqlCommand nc = new SqlCommand("SELECT ... FROM");
        }

        void Update()
        {
            con.Open();
            SqlCommand nc = new SqlCommand("UPDATE TABLE ");
            nc.ExecuteNonQuery();
        }

        void Delete()
        {
            con.Open();
            SqlCommand nc = new SqlCommand("DELETE");
            nc.ExecuteNonQuery();
        }

        private SqlConnection con;
    }
}