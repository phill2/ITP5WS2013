using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace itp5proj
{
    public class dbc
    {
        public dbc(String st)
        {
            statement=new SqlCommand(st, con);
        }

        void r()
        {
            using (SqlConnection myConnection = con)
            {
                con.Open();
                SqlDataReader rd = statement.ExecuteReader();
                while(rd.Read())
                {

                }
                con.Close();
            }
        }

        void cud()
        {
            using (con)
            {
                con.Open();
                statement.ExecuteNonQuery();
                con.Close();
            }
        }

        private SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["mobile"].ConnectionString);
        private SqlCommand statement{ get; set; }
    }

    public interface BaseDB
    {
        void Create();
        void Read();
        void Update();
        void Delete(); 
    }

    public class UserDB : BaseDB
    {
        public void Create()
        {
            String st = "INSERT INTO Users (username, password, acctype, email) VALUES (@uname, @pwd, 'regular', @email)";
        }

        public void Read()
        {
            String st = "SELECT id, username, acctype FROM Users WHERE username=@una AND password=@pwd";
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }

    public class GamesDB : BaseDB 
    {
        public void Create()
        {
        }

        public void Read()
        {
            String st="SELECT * FROM Games WHERE kategorie=@kat";
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }

    public class CommentsDB : BaseDB
    {
        public void Create()
        {
        }

        public void Read()
        {
            String st="SELECT body, title FROM Comments JOIN Games ON Comments.gid=Games.id";
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }

    /*public class dbs
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

    public class Users
    {
        public int Id { get; set; }
        public string username { get; set; }
    }

    public class Games
    {
    }

    public class Posts
    {
    }*/
}