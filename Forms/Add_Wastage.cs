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
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class Add_Wastage : Form
    {
        DB_Connection_class DbObject = new DB_Connection_class();
        decimal small = 0;
        decimal medium = 0;
        decimal large = 0;
        string type = null;
        double amount= 0;
        string category = null;
        public string wastage_id = null;
        private static ArrayList List_String_ID = new ArrayList();
        DashBoard_form d_form = new DashBoard_form();

        public Add_Wastage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Wastage_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxDate = DateTime.Today;
            monthCalendar1.MinDate = DateTime.Now.Date.AddDays(-7);
            radio_food.Checked = true;

        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (measure_box.SelectedItem.ToString() == "head" || radio_food.Checked == true)
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }


        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (txt_amount.Visible == true && txt_amount.Text != null)
            {
                txt_cost.Text = (decimal.Parse(txt_amount.Text) * decimal.Parse(txt_unit_price.Text)).ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            radio_selection();
          
            calculateamount();
            categorySelection();
            try
            {

                if (name_box.SelectedIndex == -1 || txt_ID.Text == null || type == null || amount == 0 || monthCalendar1.SelectionStart.Date == null || measure_box.SelectedIndex == -1 || txt_cost.Text == null || txt_unit_price.Text == null || txt_reason.Text == null)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (type == radio_food.Text && cathegory_box.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DbObject.OpenConnection();
                    string query = "UPDATE wastage SET  date = '" + monthCalendar1.SelectionStart.Date.ToShortDateString() + "', selection= '" + type + "', cathegory= '" + category + "', name = '" + name_box.SelectedItem.ToString() + "', measurement= '" + measure_box.SelectedItem.ToString() + "', unit_price= '" +decimal.Parse(txt_unit_price.Text) + "', wastage_amount= '" + amount + "', cost= '" + decimal.Parse(txt_cost.Text) + "', reason= '" + txt_reason.Text + "', employee= '" + Properties.Settings.Default.username + "', added_on = '" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "' WHERE wastage_id = '" + wastage_id + "'";
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

        private void txt_reason_TextChanged(object sender, EventArgs e)
        {

        }

        private void radio_raw_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_raw.Checked == true)
            {
                lbl_food_cathegory.Visible = false;
                cathegory_box.Visible = false;
            }
            else
            {
                lbl_food_cathegory.Visible = true;
                cathegory_box.Visible = true;
            }
        }

        private void cathegory_box_Click(object sender, EventArgs e)
        {

            loadCathegory();
        }
        public void loadCathegory()
        {
            cathegory_box.Items.Clear();
            
            string query = "select name FROM cathegory";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(query);
            while (drd.Read())
            {
                cathegory_box.Items.Add(drd["name"].ToString());
            }
            DbObject.CloseConnection();
        }

        private void name_box_Click(object sender, EventArgs e)
        {
            loadNameBox();
        }
        public void loadNameBox()
        {
            if (radio_food.Checked == true)
            {
                if (cathegory_box.SelectedItem.ToString() != null)
                {
                    name_box.Items.Clear();

                    string query = "select food_name FROM food_management WHERE cathegory = '" + cathegory_box.SelectedItem.ToString() + "'";
                    DbObject.OpenConnection();
                    MySqlDataReader drd = DbObject.DataReader(query);
                    while (drd.Read())
                    {
                        name_box.Items.Add(drd["food_name"].ToString());
                    }
                    DbObject.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Please Select Category", "Invalid", MessageBoxButtons.OK);
                }

            }
            if (radio_raw.Checked == true)
            {
                name_box.Items.Clear();
                string query = "select Name FROM stock ";
                DbObject.OpenConnection();
                MySqlDataReader drd = DbObject.DataReader(query);
                while (drd.Read())
                {
                    name_box.Items.Add(drd["Name"].ToString());
                }
                DbObject.CloseConnection();
            }

        }

        private void measure_box_Click(object sender, EventArgs e)
        {
            measure_box.Items.Clear();
            loadMeasurement();
        }
        public void loadMeasurement()
        {
            if (radio_food.Checked == true)
            {
                if (name_box.SelectedItem.ToString() != null)
                {
                    DbObject.OpenConnection();
                    string str_small = "select * from food_management where food_name ='" + name_box.SelectedItem.ToString() + "'";
                    MySqlDataReader drd = DbObject.DataReader(str_small);
                    if (drd.Read())
                    {
                        small = ((decimal)drd["small"]);
                        if (small != 0)
                        {
                            measure_box.Items.Add("Small Boxs");
                        }

                        medium = ((decimal)drd["medium"]);
                        if (medium != 0)
                        {
                            measure_box.Items.Add("Medium Boxs");
                        }
                        large = ((decimal)drd["large"]);
                        if (large != 0)
                        {
                            measure_box.Items.Add("Large Boxs");
                        }
                        if (large == 0 && medium == 0 && small == 0)
                        {
                            measure_box.Items.Add("Head");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Food Name", "Invalid", MessageBoxButtons.OK);
                }
            }
            if (radio_raw.Checked == true)
            {
                if (name_box.SelectedItem.ToString() != null)
                {
                    DbObject.OpenConnection();
                    string str_small = "select Measurement from stock WHERE Name = '" + name_box.SelectedItem.ToString() + "'";
                    MySqlDataReader drd = DbObject.DataReader(str_small);
                    if (drd.Read())
                    {
                        measure_box.Items.Add(drd["Measurement"].ToString());
                    }
                   
                  
                    
                }
                else
                {
                    MessageBox.Show("Please Select  Name", "Invalid", MessageBoxButtons.OK);
                }
            }
        }

        private void measure_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (radio_food.Checked == true)
            {
                if (name_box.SelectedItem.ToString() != null)
                {
                    if (measure_box.SelectedItem.ToString() == "Small Boxs")
                    {
                        txt_unit_price.Text = small.ToString();
                    }
                    if (measure_box.SelectedItem.ToString() == "Medium Boxs")
                    {
                        txt_unit_price.Text = medium.ToString();
                    }
                    if (measure_box.SelectedItem.ToString() == "Large Boxs")
                    {
                        txt_unit_price.Text = large.ToString();
                    }
                    if (measure_box.SelectedItem.ToString() == "N/A")
                    {
                        txt_unit_price.Text = small.ToString();
                    }
                }
            }
            if(radio_raw.Checked == true)
            {
                if (name_box.SelectedItem.ToString() != null)
                {
                    string str = "select Unit_price from stock WHERE Name = '" + name_box.SelectedItem.ToString() + "'";
                    decimal price = DbObject.unit_price(str);

                    txt_unit_price.Text = price.ToString();
                }
            }

            visiblitityChange();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            getNo();
            radio_selection();          
            calculateamount();
            categorySelection();
            try
            {

                if (name_box.SelectedIndex == -1 || txt_ID.Text == null || type == null || amount == 0 || monthCalendar1.SelectionStart.Date == null || measure_box.SelectedIndex == -1 || txt_cost.Text == null || txt_unit_price.Text == null || txt_reason.Text == null)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (type == radio_food.Text && cathegory_box.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    string query = "INSERT INTO wastage VALUES('" + txt_ID.Text + "','" + monthCalendar1.SelectionStart.Date.ToShortDateString() + "','" + type + "','" + category  + "','" + name_box.SelectedItem.ToString() + "','" + measure_box.SelectedItem.ToString() + "', '" + decimal.Parse(txt_unit_price.Text) + "', '" + amount + "', '" + decimal.Parse(txt_cost.Text) + "', '" + txt_reason.Text + "', '" + Properties.Settings.Default.username + "', '" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "')";

                    DbObject.OpenConnection();
                    DbObject.ExecuteQueries(query);
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    DbObject.CloseConnection();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void radio_selection()
        {

            if (radio_food.Checked == true)
            {
                type = radio_food.Text;
            }
            if (radio_raw.Checked == true)
            {
                type = radio_raw.Text;
            }

        }
        private void reset()
        {
            txt_ID.Clear();
            monthCalendar1.SelectionStart = DateTime.Now.Date;
            monthCalendar1.SelectionEnd = DateTime.Now.Date;
            radio_food.Checked = true;
            radio_raw.Checked = false;
            cathegory_box.SelectedIndex = -1;
            name_box.SelectedIndex = -1;
            measure_box.SelectedIndex = -1;
            txt_unit_price.Clear();
            txt_reason.Clear();
            txt_cost.Clear();
            unit_box.Value = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void getNo()
        {

            var NumberList = new List<int>();
            string qry = "SELECT wastage_id FROM wastage ";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(qry);
            while (drd.Read())
            {
                List_String_ID.Add(drd["wastage_id"].ToString());

            }
            DbObject.CloseConnection();
            for (int i = 0; i < List_String_ID.Count; i++)
            {
                NumberList.Add(Convert.ToInt32(List_String_ID[i].ToString().Substring(2, (List_String_ID[i].ToString().Length - 2))));
            }
            int max_no = NumberList.Max();


            max_no++;
            txt_ID.Text = "W/" + max_no;
            List_String_ID.Clear();


        }
        private void calculateamount()
        {
            if(unit_box.Visible == true && unit_box.Value != 0)
            {
                amount = double.Parse(unit_box.Value.ToString());
            }
            if(txt_amount.Visible == true && txt_amount.Text != null)
            {
                amount = double.Parse(txt_amount.Text);
            }
        }
        private void categorySelection()
        {
            if (cathegory_box.SelectedIndex != -1)
            {
                category = cathegory_box.SelectedItem.ToString();
            }
            else
            {
                category = "N/A";
            }
        }

        private void unit_box_ValueChanged(object sender, EventArgs e)
        {
            if(unit_box.Visible == true && unit_box.Value != 0)
            {
                txt_cost.Text = (decimal.Parse(unit_box.Value.ToString()) * decimal.Parse(txt_unit_price.Text)).ToString();
            }
        }
        private void visiblitityChange()
        {
            if (radio_food.Checked == true || measure_box.SelectedItem.ToString() == "Head")
            {
                unit_box.Visible = true;
                txt_amount.Visible = false;
            }
            else
            {
                unit_box.Visible = false;
                txt_amount.Visible = true;
            }
        }
    }
}
