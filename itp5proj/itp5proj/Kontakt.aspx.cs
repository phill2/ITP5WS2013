using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace itp5proj
{
    public partial class Kontakt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reset_Click(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            MailMessage nm = new MailMessage();
            nm.From = new MailAddress(mail.Text);
            nm.To.Add(new MailAddress("philipp.langer2@google.com"));
            nm.Subject = "Kontaktierung";
            nm.Body = "Message from " + vname.Text + " " + nname.Text + ": " + message.Text;
            SmtpClient smtp = new SmtpClient("smtp.technikum-wien.at");
            smtp.Send(nm);
        }
    }
}