using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace PingPong.Forms
{
    public partial class Feedback : Form
    {
        SmtpClient client = new SmtpClient();
        public Feedback()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(textBox2.Text.Trim(), textBox3.Text.Trim());

            MailAddress from = new MailAddress(textBox2.Text);
            MailAddress to = new MailAddress("aminmirzaei.og@gmail.com");
            MailMessage message = new MailMessage(from, to);
            message.Body = textBox1.Text;
            message.BodyEncoding = Encoding.UTF8;
            if (this.radioButton1.Checked)
                message.Subject = "Feedback";
            else
                message.Subject = "Report";

            message.SubjectEncoding = Encoding.UTF8;
            client.Send(message);
            message.Dispose();
            MessageBox.Show("E-Mail Sent!");
        }
    }
}
