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
        public dbc(SqlCommand st)
        {
            statement=st;
            st.Connection=con;
        }

        public List<String> r(int cols)
        {
            List<String> rt = new List<String>();
            using (con)
            {
                con.Open();
                SqlDataReader rd = statement.ExecuteReader();
                
                while(rd.Read())
                {
                    if (cols > 1)
                    {
                        String row;
                        try
                        {
                            row = rd.GetString(0);
                        }
                        catch(InvalidCastException)
                        {
                            row = rd.GetInt32(0).ToString();
                        }
                        for (int i = 1; i < cols; i++)
                        {
                            try
                            {
                                row = row + ((char)007) +rd.GetString(i);
                            }
                            catch (InvalidCastException)
                            {
                                row = row + ((char)007) + rd.GetInt32(i);
                            }
                        }
                        rt.Add(row);
                    }
                    else
                    {
                        try
                        {
                            rt.Add(rd.GetString(0));
                        }
                        catch (InvalidCastException)
                        {
                            rt.Add(rd.GetInt32(0).ToString());
                        }
                    }
                }
                con.Close();
            }
            return rt;
        }

        public void cud()
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

    public class UserDB
    {
        public void Create_New_User(List<String> pms)
        {
            SqlCommand st = new SqlCommand("INSERT INTO Users (id, username, password, acctype, email) VALUES (@id, @un, @pwd, 'regular', @mail)");
            st.Parameters.Add(new SqlParameter("un", pms[0]));
            st.Parameters.Add(new SqlParameter("pwd", pms[1]));
            st.Parameters.Add(new SqlParameter("mail", pms[2]));
            st.Parameters.Add(new SqlParameter("id", Convert.ToInt32(Read_Max()[0])+1));
            dbc c = new dbc(st);
            c.cud();
            //new SqlCommand("SELECT count(id) FROM Users", myConnection)
        }

        public List<String> Read_Login(String usr, String pwd)
        {
            SqlCommand st = new SqlCommand("SELECT id, username, acctype FROM Users WHERE username=@una AND password=@pwd");
            st.Parameters.Add(new SqlParameter("una", usr));
            st.Parameters.Add(new SqlParameter("pwd", pwd));
            dbc c = new dbc(st);
            return c.r(3);
        }

        private List<String> Read_Max()
        {
            dbc c = new dbc(new SqlCommand("SELECT max(id) FROM Users"));
            return c.r(1);
        }

        public List<String> Read_Users()
        {
            SqlCommand st = new SqlCommand("SELECT username, email, id, acctype FROM Users");
            dbc c = new dbc(st);
            return c.r(4);
        }

        public void Update_User(String uid, String type)
        {
            SqlCommand st = new SqlCommand("UPDATE Users SET acctype=@type WHERE id=@uid");
            st.Parameters.Add(new SqlParameter("uid", Convert.ToInt32(uid)));
            st.Parameters.Add(new SqlParameter("type", type));
            dbc c = new dbc(st);
            c.cud();
        }

        public void Update_Password(String un, String pwd, String pwd2)
        {
            SqlCommand st = new SqlCommand("UPDATE Users SET password=@pwd2 WHERE username=@un AND password=@pwd");
            st.Parameters.Add(new SqlParameter("un", un));
            st.Parameters.Add(new SqlParameter("pwd", pwd));
            st.Parameters.Add(new SqlParameter("pwd", pwd2));
            dbc c = new dbc(st);
            c.cud();
        }

        public void Delete_User(String uid)
        {
            SqlCommand st = new SqlCommand("DELETE FROM Users WHERE id=@uid");
            st.Parameters.Add(new SqlParameter("uid", Convert.ToInt32(uid)));
            dbc c = new dbc(st);
            c.cud();
        }
    }

    public class GamesDB 
    {
        public void Create_New_Game(List<String> pms)
        {
            SqlCommand st = new SqlCommand("INSERT INTO Games VALUES(@id, @tit, @desc, @kat, @cov)");
            st.Parameters.Add(new SqlParameter("tit", pms[0]));
            st.Parameters.Add(new SqlParameter("desc", pms[1]));
            st.Parameters.Add(new SqlParameter("kat", pms[2]));
            st.Parameters.Add(new SqlParameter("cov", pms[3]));
            st.Parameters.Add(new SqlParameter("id", Convert.ToInt32(Read_Max()[0])+1));
            dbc c = new dbc(st);
            c.cud();
        }

        public List<String> Read_Category(String kat)
        {
            SqlCommand st = new SqlCommand("SELECT * FROM Games WHERE kategorie=@kat");
            st.Parameters.Add(new SqlParameter("kat", kat));
            dbc c = new dbc(st);
            return c.r(5);
        }

        private List<String> Read_Max()
        {
            dbc c = new dbc(new SqlCommand("SELECT max(id) FROM Games"));
            return c.r(1);
        }

        public void Update()
        {

        }

        public void Delete()
        {
        }
    }

    public class CommentsDB
    {
        public void Create_New_Comment(List<String> pms)
        {
            SqlCommand st = new SqlCommand("INSERT INTO Comments (id, body, uid, gid) VALUES (@id, @body, @uid, @gid)");
            st.Parameters.Add(new SqlParameter("body", pms[0]));
            st.Parameters.Add(new SqlParameter("uid", pms[1]));
            st.Parameters.Add(new SqlParameter("gid", pms[2]));
            st.Parameters.Add(new SqlParameter("id", Convert.ToInt32(Read_Max()[0])+1));
            dbc c = new dbc(st);
            c.cud();
        }

        public List<String> Read_Comments()
        {
            SqlCommand st = new SqlCommand("SELECT body, gid, Users.username FROM Comments JOIN Users ON Comments.uid=Users.id");// JOIN Games ON Comments.gid=Games.id");

            dbc c = new dbc(st);
            return c.r(3);
        }

        private List<String> Read_Max()
        {
            dbc c = new dbc(new SqlCommand("SELECT max(id) FROM Comments"));
            return c.r(1);
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }
}