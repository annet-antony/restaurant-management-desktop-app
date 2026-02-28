using DbConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class change_username : Form
    {
        DB_Connection_class DbObject = new DB_Connection_class();
        public string id = null;
        public change_username()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string old_password = null;
            string query = "select password FROM employee WHERE e_id = '" + id + "'";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(query);
            while (drd.Read())
            {
                old_password = drd["password"].ToString();
            }
            if (txt_user.Text == null || txt_old.Text == null || txt_new.Text == null || txt_confirm.Text == null)
            {
                MessageBox.Show("Empty Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
           
            else if(txt_new.Text != txt_confirm.Text)
            {
                MessageBox.Show("Password is Mismatch!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_confirm.Clear();
            }
            else if(old_password == txt_new.Text)
            {
                MessageBox.Show("Old Password Can't be a new password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (old_password != txt_old.Text)
            {
                MessageBox.Show("Password is not Correct!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DbObject.OpenConnection();
                string qry = "UPDATE employee SET  user_name = '" + txt_user.Text + "', password= '" + txt_new.Text + "', edited_on = '" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "', edited_by= '" + txt_user.Text + "' WHERE e_id = '" + id + "'";
                DbObject.ExecuteQueries(qry);
                MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DbObject.CloseConnection();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_new.Clear();
            txt_confirm.Clear();
            txt_old.Clear();
            password_erro_lbl.Visible = false;
        }

        private void txt_new_TextChanged(object sender, EventArgs e)
        {
            bool validated = ValidatePassword(txt_new.Text);
            if (validated == false)
            {
                password_erro_lbl.Visible = true;
                password_erro_lbl.Text = "Invalid password";
            }
            else
            {
                password_erro_lbl.Visible = false;
            }
        }
        static bool ValidatePassword(string passWord)
        {
            int validConditions = 0;
            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' };
                if (passWord.IndexOfAny(special) == -1) return false;
            }
            return true;
        }

    }
}
