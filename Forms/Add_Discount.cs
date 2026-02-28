using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DbConnection;
using MySql.Data.MySqlClient;

namespace Restaurant_Project
{
    public partial class Add_Discount : Form
    {
        public decimal f_price = 0;
        public  decimal d_amount = 0;
        public decimal c_amount = 0;
        DB_Connection_class Dbobject = new DB_Connection_class();
        private static ArrayList List_String_ID = new ArrayList();
        decimal small;
        decimal medium;
        decimal large;
       
        public string discount_id = "";
        DashBoard_form d_form = new DashBoard_form();


        public Add_Discount()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Discount_Load(object sender, EventArgs e)
        {
            txt_fixed.Text = f_price.ToString();
            txt_current.Text = c_amount.ToString();
            txt_deducted.Text = d_amount.ToString();

        }
        public void add_Validations()
        {
            start_calender.MinDate = DateTime.Today;
            start_calender.MaxDate = DateTime.Today.AddMonths(1);
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cathegory_box_SelectionChangeCommitted(object sender, EventArgs e)
        {

            loadFood();



        }
        public void loadFood()
        {

            name_box.Enabled = true;
            name_box.Items.Clear();
            string str_menu = "select DISTINCT food_name from food_management where cathegory=  '" + cathegory_box.SelectedItem.ToString() + "'";
            Dbobject.OpenConnection();
            MySqlDataReader drd = Dbobject.DataReader(str_menu);
            while (drd.Read())
            {
                name_box.Items.Add(drd["food_name"].ToString());
            }
        }

        private void status_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (status_box.SelectedItem.ToString() == "Cancelled" || status_box.SelectedItem.ToString() == "Expired")
            {
                discount_value.Value = 0;
            }
        }

        private void status_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void discount_value_ValueChanged(object sender, EventArgs e)
        {
            f_price = decimal.Parse(txt_fixed.Text);
            txt_deducted.Text = ((((decimal)discount_value.Value) / 100) * f_price).ToString("#,#.00");
        }

        

        private void cathegory_box_Click(object sender, EventArgs e)
        {
            cathegory_box.Items.Clear();
            loadCathegory();
        }
        public void loadCathegory()
        {
            string query = "select name FROM cathegory";
            Dbobject.OpenConnection();
            MySqlDataReader drd = Dbobject.DataReader(query);
            while (drd.Read())
            {
                cathegory_box.Items.Add(drd["name"].ToString());
            }
            Dbobject.CloseConnection();
        }

        private void name_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string qry = "SELECT food_id FROM food_management WHERE food_name = '"+name_box.SelectedItem.ToString()+"'";

            int food_id = Dbobject.discount_No(qry);
            txt_food_id.Text = food_id.ToString();
         

        }
        private void size_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (size_box.SelectedItem.ToString() == "S")
            {
                txt_fixed.Text = small.ToString();
            }
            if (size_box.SelectedItem.ToString() == "M")
            {
                txt_fixed.Text = medium.ToString();
            }
            if (size_box.SelectedItem.ToString() == "L")
            {
                txt_fixed.Text = large.ToString();
            }
            if (size_box.SelectedItem.ToString() == "N/A")
            {
                txt_fixed.Text = small.ToString();
            }
        }

        private void size_box_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_deducted_TextChanged(object sender, EventArgs e)
        {
            d_amount = decimal.Parse(txt_deducted.Text);
            txt_current.Text = (f_price - d_amount).ToString("#,#.00");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            getDiscountlNo();
            try
            {
                if (cathegory_box.SelectedIndex == -1 || name_box.SelectedIndex == -1 || status_box.SelectedIndex == -1  || discount_value.Value == 0 || start_calender.SelectionStart.Date == null || end_calender.SelectionStart.Date == null)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
                else
                {
                    string query = "INSERT INTO discount (discount_id, category, food_name, food_id, status, selection, dis_percent, fixed_price, deduct_price, current_price, start_from, end_on, added_by, added_on) VALUES('" + txt_ID.Text + "','" + cathegory_box.SelectedItem.ToString() + "','" + name_box.SelectedItem.ToString()+ "','" + txt_food_id.Text + "', '" + status_box.SelectedItem.ToString() + "', '" + size_box.SelectedItem.ToString() + "', '" + (int)discount_value.Value + "', '" + decimal.Parse(txt_fixed.Text) + "', '" + decimal.Parse(txt_deducted.Text) + "', '" + decimal.Parse(txt_current.Text) + "', '" + start_calender.SelectionStart.Date.ToShortDateString() + "', '" + end_calender.SelectionStart.Date.ToShortDateString() + "', '" + Properties.Settings.Default.username + "', '" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "')";

                    Dbobject.OpenConnection();
                    Dbobject.ExecuteQueries(query);
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   reset();
                    Dbobject.CloseConnection();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getDiscountlNo()
        {            
            var NumberList = new List<int>();
            string qry = "SELECT discount_id FROM discount ";
            Dbobject.OpenConnection();
            MySqlDataReader drd = Dbobject.DataReader(qry);
            while (drd.Read())
            {
                List_String_ID.Add(drd["discount_id"].ToString());

            }
            Dbobject.CloseConnection();
            for (int i = 0; i < List_String_ID.Count; i++)
            {
                NumberList.Add(Convert.ToInt32(List_String_ID[i].ToString().Substring(2, (List_String_ID[i].ToString().Length - 2))));
            }
            int max_no = NumberList.Max();
            max_no++;
            txt_ID.Text = "D/" + max_no;
            List_String_ID.Clear();
        }
        
        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            txt_food_id.Clear();
            cathegory_box.SelectedIndex = -1;
            name_box.SelectedIndex = -1;
           size_box.SelectedIndex = -1;
            status_box.SelectedIndex = -1;
            // discount_value.Value = 0;
            f_price = 0;
            c_amount = 0;
            d_amount = 0;
            txt_fixed.Text = f_price.ToString();
            txt_current.Text = c_amount.ToString();
            txt_deducted.Text = d_amount.ToString();
            end_calender.Enabled = false;
            start_calender.SelectionStart = DateTime.Today.Date;
            start_calender.SelectionEnd = DateTime.Today.Date;
            end_calender.SelectionStart = DateTime.Today.Date;
            end_calender.SelectionEnd = DateTime.Today.Date;

        }

        private void cathegory_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
                    
            try
            {
                if (cathegory_box.SelectedIndex == -1 || name_box.SelectedIndex == -1 || status_box.SelectedIndex == -1  || discount_value.Value == 0 || start_calender.SelectionStart.Date == null || end_calender.SelectionStart.Date == null)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               

                else
                {
                    Dbobject.OpenConnection();
                    string query = "UPDATE discount SET  category = '" + cathegory_box.SelectedItem.ToString() + "', food_name= '" + name_box.SelectedItem.ToString() + "', food_id= '" + txt_food_id.Text + "', status= '" + status_box.SelectedItem.ToString() + "',  selection= '" + size_box.SelectedItem.ToString() + "', dis_percent= '" + discount_value.Value + "', fixed_price= '" + decimal.Parse(txt_fixed.Text )+ "', deduct_price= '" + decimal.Parse(txt_deducted.Text) + "', current_price= '" +decimal.Parse(txt_current.Text) + "', start_from= '" + start_calender.SelectionStart.ToShortDateString() + "', end_on= '" + end_calender.SelectionStart.ToShortDateString() + "', added_by= '" + d_form.lbl_name.Text + "', added_on = '" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "' WHERE discount_id = '" + discount_id + "'";
                    Dbobject.ExecuteQueries(query);
                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dbobject.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void size_box_Click(object sender, EventArgs e)
        {
            size_box.Items.Clear();
            loadsizes();
        }
        public void loadsizes()
        {
            Dbobject.OpenConnection();
            string str_small = "select * from food_management where food_name ='" + name_box.SelectedItem.ToString() + "'";
            MySqlDataReader drd = Dbobject.DataReader(str_small);
            if (drd.Read())
            {
                small = ((decimal)drd["small"]);
                if (small != 0)
                {
                    size_box.Items.Add("S");
                }

                medium = ((decimal)drd["medium"]);
                if (medium != 0)
                {
                    size_box.Items.Add("M");
                }
                large = ((decimal)drd["large"]);
                if (large != 0)
                {
                    size_box.Items.Add("L");
                }

                if (large == 0 && medium == 0 && small == 0)
                {
                    size_box.Items.Add("N/A");
                }

            }
            Dbobject.CloseConnection();
        }

        private void start_calender_DateSelected(object sender, DateRangeEventArgs e)
        {
            end_calender.Enabled = true;
            end_calender.MinDate = DateTime.Parse(start_calender.SelectionStart.Date.ToShortDateString());

           end_calender.MaxDate = DateTime.Parse(start_calender.SelectionStart.Date.ToShortDateString()).AddMonths(1);

        }
    }
}
