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
    public partial class Add_Tables : Form
    {
        DB_Connection_class DbObject = new DB_Connection_class();
        View_Table vt = new View_Table();
        DashBoard_form db = new DashBoard_form();
        Validation_Class vObject = new Validation_Class();
        public string table_id;

        public Add_Tables()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void size_box_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (size_box.SelectedItem.ToString() == "Select" || table_no.Value == 0 || shape_box.SelectedIndex == -1 || condition_box.SelectedIndex == -1  || people_txt.Text == null || txt_manufacturer.Text == null)
                {
                    MessageBox.Show("Please Fill Empty Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {

                    DbObject.OpenConnection();
                    DbObject.ExecuteQueries("insert into table_reservation (table_size, table_no, table_shape, table_condition, no_of_people, reservation_price, table_manufacturer, table_date_purchase) " +
                        "Values('" + size_box.SelectedItem.ToString() + "','" + table_no.Value + "','" + shape_box.SelectedItem.ToString() + "','" + condition_box.SelectedItem.ToString() + "','" + people_txt.Text + "','" + decimal.Parse(price_txt.Text) + "','" + txt_manufacturer.Text+ "','" + monthCalendar1.SelectionRange.Start.ToShortDateString() + "')");
                    DbObject.CloseConnection();
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                   
                    resetFields();
                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //checkTableNo();
            try
                {
                    if (size_box.SelectedItem.ToString() == "Select" || table_no.Value == 0 || shape_box.SelectedIndex == -1 || condition_box.SelectedIndex == -1  || people_txt.Text == null || txt_manufacturer.Text == null)
                    {
                        MessageBox.Show("Please Fill Empty Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
              
                    else
                    {                     
                        DbObject.OpenConnection();
                        string query = "UPDATE table_reservation SET table_size ='" + size_box.SelectedItem.ToString() + "', table_no = '" + table_no.Value + "', table_shape= '" + shape_box.SelectedItem.ToString()+ "',table_condition = '" + condition_box.SelectedItem.ToString() + "'," +
                        " no_of_people= '" + people_txt.Text + "', reservation_price= '" +decimal.Parse(price_txt.Text) + "', table_manufacturer= '" + txt_manufacturer.Text + "', table_date_purchase =  '" + monthCalendar1.SelectionStart.ToString() + "' WHERE table_id = '" + table_id + "' ";
                        DbObject.ExecuteQueries(query);
                        MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vt.TableGridView.Update();
                        vt.TableGridView.Refresh();
                        resetFields();

                    DbObject.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        private void resetFields()
            {
            size_box.SelectedItem = "Select";
            table_no.Value = 0;
            shape_box.SelectedIndex = -1;
            condition_box.SelectedIndex = -1;
            people_txt.Clear();
            price_txt.Clear();
            txt_manufacturer.Clear();
            
            monthCalendar1.SelectionStart = DateTime.Now.Date;
            monthCalendar1.SelectionEnd = DateTime.Now.Date;

        }

            private void Manage_Tables_Load(object sender, EventArgs e)
            {
                monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd ");
            monthCalendar1.MaxDate = DateTime.Now.Date;
           
            }

     
        private void shape_box_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void shape_box_Click(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
           

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetFields();
        }
        private void checkTableNo()
        {

            string query = "select DISTINCT table_no from table_reservation WHERE table_size = '" + size_box.SelectedItem.ToString() + "' AND table_no = '" + table_no.Value + "' ";
            bool check = DbObject.checkExistence(query);

            if (check == true)
            {
                MessageBox.Show("Table No relavant to the cathegory is already exists.", "Try Another", MessageBoxButtons.OK, MessageBoxIcon.Error);
                table_no.Value = 0;
                table_no.Focus();
            }
        }

        private void size_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            table_no.Value = 0;
            shape_box.Items.Clear();
           
            loadComboBox();

        }
        public void loadComboBox()
        {
          
            if (size_box.SelectedItem.ToString() == "small")
            {
                table_no.Maximum = 15;

                shape_box.Items.Add("round");
                shape_box.Items.Add("square");
               

                people_txt.Text = "1-3";
                price_txt.Text = 100.ToString();
            }
            if (size_box.SelectedItem.ToString() == "medium")
            {
                table_no.Maximum = 12;
                shape_box.Items.Add("round");
                shape_box.Items.Add("square");
                shape_box.Items.Add("rectangle");
               

                people_txt.Text = "4-6";
                price_txt.Text = 200.ToString(); 
            }
            if (size_box.SelectedItem.ToString() == "big")
            {
                table_no.Maximum = 10;

                shape_box.Items.Add("round");
                shape_box.Items.Add("Square");
                shape_box.Items.Add("rectangle");
                

                people_txt.Text = "6-10";
                price_txt.Text = 300.ToString();
            }
            if (size_box.SelectedItem.ToString() == "large")
            {
                table_no.Maximum = 6;

                shape_box.Items.Add("oval");
                shape_box.Items.Add("rectangle");
              

                people_txt.Text = "10-15";
                price_txt.Text = 400.ToString();
            }

            if (size_box.SelectedItem.ToString() == "ex_large")
            {
                table_no.Maximum = 3;
                shape_box.Items.Add("oval");
                shape_box.Items.Add("rectangle");
               
                people_txt.Text = "15-20";
                price_txt.Text = 600.ToString();
            }

        }

        private void shape_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            checkTableNo();
        }

        private void txt_manufacturer_TextChanged(object sender, EventArgs e)
        {
            lbl_error_manufacturer.Visible = false;
            bool verify = vObject.validattion(txt_manufacturer.Text);

            if (verify == false)
            {
                lbl_error_manufacturer.Visible = true;
                lbl_error_manufacturer.Text = "! Invalid";
                txt_manufacturer.Clear();
            }
            else
            {
                lbl_error_manufacturer.Visible = false;
            }
        }
    }
   
}
