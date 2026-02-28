using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Restaurant_Project { 
    public partial class Email_Form : Form
    {

        static Regex validate_emailaddress = email_validation();
        MailMessage mail_message  = new MailMessage();
        SmtpClient s_client;
        public Email_Form()
        {
            InitializeComponent();
        }
        public static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
              + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
              + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }


        private void button1_Click(object sender, EventArgs e)
        {
         
                if (validate_emailaddress.IsMatch(txt_receiver.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_receiver.Focus();
                txt_receiver.Clear();

                    return;
                }

            else
            {
                try

                {

                    mail_message.To.Add(txt_receiver.Text);
                    mail_message.Subject = txt_subject.Text;

                    mail_message.From = new MailAddress("tasteelitejaffna@gmail.com");

                    mail_message.Body = txt_body.Text;

                    s_client = new SmtpClient("smtp.gmail.com");

                    s_client.Port = 587;

                    s_client.EnableSsl = true;

                    s_client.Credentials = new NetworkCredential("tasteelitejaffna@gmail.com", "Elite@1234");

                    s_client.SendAsync(mail_message, mail_message.Subject);


                    MessageBox.Show("Email sent sucessfully!","Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    MessageBox.Show(ex.Message);

                }

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
