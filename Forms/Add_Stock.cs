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
    public partial class Add_Stock : Form
    {
        Validation_Class vObject = new Validation_Class();
        DB_Connection_class Dbobject = new DB_Connection_class();
        DashBoard_form d_form = new DashBoard_form();
        string date = "N/A";
        decimal count;
        public string stock_id = " ";
        public Add_Stock()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            lbl_error_description.Visible = false;
            bool verify = vObject.validattion(txt_description.Text);

            if (verify == false)
            {
                lbl_error_description.Visible = true;
                lbl_error_description.Text = "! Invalid";
                txt_description.Clear();
            }
            else
            {
                lbl_error_description.Visible = false;
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void measurement_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void measurement_box_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (measurement_box.SelectedItem.ToString() == "head")
            {
                count_value.Visible = true;
                txt_count.Visible = false;
                count_value.Increment = 1;
            }
            else
            {
                count_value.Visible = false;
                txt_count.Visible = true;
            }

        }

        private void txt_manufacturer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Add_Stock_Load(object sender, EventArgs e)
        {

            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MaxDate = DateTime.Today.AddYears(10);
            if (txt_count.Text == " ")
            {
                txt_count.Text = "0";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cathegory_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string radio_selection()
        {
            string val = null;
            if (expiry_y.Checked == true)
            {
                val = expiry_y.Text;
                monthCalendar1.Visible = true;
            }
            if (expiry_n.Checked == true)
            {
                val = expiry_n.Text;
                monthCalendar1.Visible = false;
            }

            return val;
        }

        private void expiry_y_CheckedChanged(object sender, EventArgs e)
        {
            radio_selection();
        }

        private void expiry_n_CheckedChanged(object sender, EventArgs e)
        {
            radio_selection();
        }

        private void count_value_ValueChanged(object sender, EventArgs e)
        {
            decimal u_price = decimal.Parse(txt_price.Text);
            count = (decimal)count_value.Value;
            txt_cost.Text = (u_price * count).ToString();
        }

        private void txt_count_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txt_count_TextChanged(object sender, EventArgs e)
        {
            
            decimal u_price = decimal.Parse(txt_price.Text);
            count = decimal.Parse(txt_count.Text);
            txt_cost.Text = (u_price * count).ToString();
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            Add_Supplier form = new Add_Supplier();
            form.btn_update.Visible = false;
            form.ShowDialog();
        }

        private void txt_count_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void cathegory_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cathegory_box.SelectedItem.ToString() == "Kitchen Appliances")
            {
                lbl_date_selection.Text = "Has Warranty   :";
                lbl_date.Text = "Warranty Date :";
                measurement_box.SelectedItem = "head";
                measurement_box.Enabled = false;
                count_value.Visible = true;
                txt_count.Visible = false;
                txt_price.MaxLength = 6;
                count = (decimal)count_value.Value;
            }

            if (cathegory_box.SelectedItem.ToString() == "Raw Materials")
            {
                lbl_date_selection.Text = "Has Expiry   :";
                lbl_date.Text = "Expiry Date   :";
                txt_price.MaxLength = 4;
                measurement_box.Enabled = true;
                measurement_box.SelectedIndex = -1;
                count_value.Visible = false;
                txt_count.Visible = true;
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            ExpirySelection();

            string date_selection = radio_selection();
            bool nameexists = Dbobject.checkExistence("select count(*) from stock where name='" + txt_name.Text + "'");

            try
            {
                if (cathegory_box.SelectedIndex == -1 || txt_name.Text == null || txt_description.Text == null || measurement_box.SelectedIndex == -1 || (count_value.Value == 0 && txt_count.Text == null) || txt_price.Text == null || txt_cost.Text == null || status_box.SelectedIndex == -1 || store_value.Value == 0 || shelf_value.Value == 0 || supplier_box.SelectedIndex == -1 || txt_manufacturer.Text == null)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (nameexists == true)
                {
                    MessageBox.Show("Name is Already Exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_name.Clear();
                }
                else if (expiry_y.Checked == true && date == "N/A")
                {
                    MessageBox.Show("Select the Date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                else
                {
                    string query = "INSERT INTO stock(Category, Name, Description, Measurement, Unit_price, Count, Cost, Status, Has_expiry, Expiry_Date, Store_No, Shelf_No, Supplier, Manufacturer, Edited_By, Edited_On)VALUES" +
                        "('" + cathegory_box.SelectedItem.ToString() + "', '" + txt_name.Text + "', '" + txt_description.Text + "','" + measurement_box.SelectedItem.ToString() + "', '" + decimal.Parse(txt_price.Text) + "','" + count + "','" + decimal.Parse(txt_cost.Text) + "','" + status_box.SelectedItem.ToString() + "', '" + date_selection + "', '" + date + "', '" + store_value.Value + "', '" + shelf_value.Value + "', '" + supplier_box.SelectedItem.ToString() + "', '" + txt_manufacturer.Text + "', '" + Properties.Settings.Default.username + "', '" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "')";

                    Dbobject.OpenConnection();
                    Dbobject.ExecuteQueries(query);
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dbobject.CloseConnection();
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExpirySelection()
        {
            if (monthCalendar1.Visible == true)
            {
                date = monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd");
            }
        }
        private void reset()
        {
            cathegory_box.SelectedIndex = -1;
            txt_name.Clear();
            txt_description.Clear();
            txt_code.Clear();
            measurement_box.SelectedIndex = -1;
            txt_price.Clear();
            //count_value.Value = 0;
            txt_count.Clear();
            txt_count.Visible = false;
            count_value.Visible = false;
            txt_cost.Clear();
            status_box.SelectedIndex = -1;
            expiry_y.Checked = false;
            expiry_n.Checked = true;
           // monthCalendar1.SelectionStart = DateTime.Now.Date;
           // monthCalendar1.SelectionEnd = DateTime.Now.Date;
           // store_value.Value = 0;
           // shelf_value.Value = 0;
            supplier_box.SelectedIndex = -1;
            txt_manufacturer.Clear();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ExpirySelection();

            string date_selection = radio_selection();
            try
            {
                if (cathegory_box.SelectedIndex == -1 || txt_name.Text == null || txt_description.Text == null || measurement_box.SelectedIndex == -1 || (count_value.Value == 0 && txt_count.Text == null) || txt_price.Text == null || txt_cost.Text == null || status_box.SelectedIndex == -1 || store_value.Value == 0 || shelf_value.Value == 0 || supplier_box.SelectedIndex == -1 || txt_manufacturer.Text == null)
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (expiry_y.Checked == true && date == "N/A")
                {
                    MessageBox.Show("Select the Date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Dbobject.OpenConnection();
                    string query = "UPDATE stock SET  Category = '" + cathegory_box.SelectedItem.ToString() + "', Name= '" + txt_name.Text + "', Description = '" + txt_description.Text + "', Measurement = '" + measurement_box.SelectedItem.ToString() + "', Unit_price= '" + decimal.Parse(txt_price.Text) + "', Count= '" + count+ "', Cost= '" + decimal.Parse(txt_cost.Text) + "', Status= '" + status_box.SelectedItem.ToString() + "', Has_expiry= '" + date_selection + "', Expiry_Date= '" + date + "', Store_No= '" + store_value + "', Shelf_No= '" + shelf_value + "',Supplier= '" + supplier_box.SelectedItem.ToString()+ "', Manufacturer= '" + txt_manufacturer.Text + "', Edited_By= '" + Properties.Settings.Default.username + "', Edited_On = '" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "' WHERE Code = '" + stock_id + "'";
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

        private void supplier_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void supplier_box_Click(object sender, EventArgs e)
        {
            supplier_box.Items.Clear();
            loadSupplier();
        }
        public void loadSupplier()
        {
            string query = "select name FROM supplier";
            Dbobject.OpenConnection();
            MySqlDataReader drd = Dbobject.DataReader(query);
            while (drd.Read())
            {
                supplier_box.Items.Add(drd["name"].ToString());
            }
            Dbobject.CloseConnection();
        }

        private void supplier_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

