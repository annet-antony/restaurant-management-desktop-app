using DbConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class Add_Supplier : Form
    {
        static Regex validate_emailaddress = email_validation();
        Validation_Class vObject = new Validation_Class();
        DB_Connection_class DbObject = new DB_Connection_class();
        public string supplier_id = null;
        private static ArrayList List_String_ID = new ArrayList();
        DashBoard_form d_form = new DashBoard_form();

        public Add_Supplier()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
              + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
              + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Add_Supplier_Load(object sender, EventArgs e)
        {
            monthCalendar.SelectionStart.Date.ToString("yyyy-MM-dd ");
        }
        public void add_date_validations()
        {
            monthCalendar.MaxDate = DateTime.Today.Date;
        }
        private void getIDNo()
        {
            var NumberList = new List<int>();
            string qry = "SELECT supplier_id FROM supplier ";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(qry);
            while (drd.Read())
            {
                List_String_ID.Add(drd["supplier_id"].ToString());

            }
            DbObject.CloseConnection();
            for (int i = 0; i < List_String_ID.Count; i++)
            {
                NumberList.Add(Convert.ToInt32(List_String_ID[i].ToString().Substring(2, (List_String_ID[i].ToString().Length - 2))));
            }
            int max_no = NumberList.Max();
            max_no++;
            txt_ID.Text = "S/" + max_no;
            List_String_ID.Clear();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool emailexists = DbObject.checkExistence("select count(*) from supplier where email='" + txt_email.Text + "'");
            bool nameexists = DbObject.checkExistence("select count(*) from supplier where name='" + txt_name.Text + "'");
            
            getIDNo();
            if (validate_emailaddress.IsMatch(txt_email.Text) != true)
            {
                lbl_error_email.Visible = true;
                txt_email.Focus();
                txt_email.Clear();
                return;
            }
            else
            {
                lbl_error_email.Visible = false;

            }
            try
            {
                if (txt_ID.Text == null || txt_name.Text == null || txt_address.Text == null || txt_mobile.Text == null)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (nameexists == true)
                {
                    MessageBox.Show("Name is Already Exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_name.Clear();
                }
                else if (emailexists == true)
                {
                    MessageBox.Show("Email is Already Exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_email.Clear();
                }
                else
                {
                    string query = "INSERT INTO supplier(supplier_id, name, address, mobile, email, supplied_from, edit_by, edit_on)VALUES('" + txt_ID.Text + "','" + txt_name.Text + "', '" + txt_address.Text + "', '" + txt_mobile.Text + "','" + txt_email.Text + "', '" + monthCalendar.SelectionStart.ToShortDateString() + "','" + Properties.Settings.Default.username + "','" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "')";

                    DbObject.OpenConnection();
                    DbObject.ExecuteQueries(query);
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DbObject.CloseConnection();
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
          private void reset()
          {
                txt_ID.Clear();
                txt_name.Clear();
                txt_address.Clear();
                txt_mobile.Clear();
                txt_email.Clear();
                monthCalendar.SelectionStart = DateTime.Now.Date;
                monthCalendar.SelectionEnd = DateTime.Now.Date;
          }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txt_ID.Text == null || txt_name.Text == null || txt_address.Text == null || txt_mobile.Text == null)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DbObject.OpenConnection();
                    string query = "UPDATE supplier SET  name = '" + txt_name.Text + "', address= '" + txt_address.Text + "', mobile = '" + txt_mobile.Text + "', email= '" + txt_email.Text + "', supplied_from = '" + monthCalendar.SelectionStart.ToShortDateString() + "', edit_by= '" + Properties.Settings.Default.username + "', edit_on = '" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "' WHERE supplier_id = '" + txt_ID.Text + "'";
                    DbObject.ExecuteQueries(query);
                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DbObject.CloseConnection();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
