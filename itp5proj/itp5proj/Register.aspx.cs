using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
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
            UserDB ins=new UserDB();
            List<String> ls = ins.Read_Users();
            for (int i = 1; i < ls.Count;i++ )
            {
                if (user.Text == ls[i].Split(((char)007))[0] || email.Text == ls[i].Split(((char)007))[1])
                {
                    if (user.Text == ls[i].Split(((char)007))[0])
                    {
                        warn.Text = "Chosen username already in use. Please choose a different username.";
                    }
                    else
                    {
                        warn.Text = "Chosen email already in use. Please choose a different email.";
                    }
                    warn.Visible = true;
                    break;
                }
                else if(i + 1 == ls.Count)
                {
                    ls = new List<String>();
                    ls.Add(user.Text);
                    crypt c = new crypt();
                    ls.Add(c.GetMd5Hash(pwd.Text));
                    ls.Add(email.Text);
                    ins.Create_New_User(ls);

                    MailMessage nm = new MailMessage();
                    nm.From = new MailAddress("philipp.langer2@google.com");
                    nm.To.Add(new MailAddress(email.Text));
                    nm.Subject = "Your new ITP5-Gaming-Website Account";
                    nm.Body = "Your new account has been created. Your Username is " + user.Text + " and your password is " + pwd.Text + " Greetings, The Website-Team";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Credentials = new System.Net.NetworkCredential("itp5projgw@gmail.com", "project5SMTP");
                    smtp.EnableSsl = true;
                    smtp.Send(nm);

                    warn.Text = "Your account was successfully created. Check your email address for your username and password.";
                    warn.Visible = true;
                }
            }
        }
    }
}