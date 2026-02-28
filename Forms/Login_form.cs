using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DbConnection;
namespace Restaurant_Project
{
    public partial class Login_form : Form
    {
        DB_Connection_class DbObject = new DB_Connection_class();
        public Login_form()
        {
            InitializeComponent();
        }

        string myconnectionstring = "server=localhost;user id=root;database=restaurant";


        private void login_button_MouseLeave(object sender, EventArgs e)
        {
            login_button.BackgroundImage = null;
            login_button.BackColor = SystemColors.ButtonHighlight;
            login_button.ForeColor = Color.Maroon;
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {
            cancel.BackgroundImage = null;
            cancel.BackColor = SystemColors.ButtonHighlight;
            cancel.ForeColor = Color.Maroon;
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
           
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            user_password.PasswordChar = show_password.Checked ? '\0' : '*';

        }


        private void login_button_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(myconnectionstring);
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM employee WHERE user_name = '" + user_txt.Text + "' AND password ='" + user_password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            try
            {

                if (user_txt.Text == null || user_password.Text == null)
                {
                    MessageBox.Show("Please Fill Empty Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    DashBoard_form dh = new DashBoard_form();

                    string query = "SELECT e_id, user_name , role FROM employee WHERE user_name = '" + user_txt.Text + "' AND password ='" + user_password.Text + "'";

                   
                    MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
                    DataTable login = new DataTable();
                    ada.Fill(login);
                    dh.id   = login.Rows[0][0].ToString();
                    Properties.Settings.Default.username = login.Rows[0][1].ToString();
                    dh.role = login.Rows[0][2].ToString();
                   
                    dh.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Invalid Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    user_txt.Clear();
                    user_password.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
    }
}
