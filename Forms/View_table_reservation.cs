using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DbConnection;
using MySql.Data.MySqlClient;

namespace Restaurant_Project
{
    public partial class View_table_reservation : Form
    {
        
        string booking_id = null;
        string id = null;
        public View_table_reservation()
        {
            InitializeComponent();
           
        }
        DB_Connection_class DbObject = new DB_Connection_class(); 

        private void View_table_reservation_Load(object sender, EventArgs e)
        {
            displaydata();
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(2);
            booking_view.Columns["cus_name"].HeaderText = "Customer";
            booking_view.Columns["no_person"].HeaderText = "No of people";
            booking_view.Columns["table_size"].HeaderText = "Size";
            booking_view.Columns["date"].HeaderText = "Date";
            booking_view.Columns["s_time"].HeaderText = "Start Time";
            booking_view.Columns["e_time"].HeaderText = "End Time";
            booking_view.Columns["table_no"].HeaderText = "Table No";
            booking_view.Columns["address"].HeaderText = "Address";
            booking_view.Columns["mobile"].HeaderText = "Mobile No";
            booking_view.Columns["email"].HeaderText = "Email";
            booking_view.Columns["comment"].HeaderText = "Comments";
            booking_view.Columns["payment"].HeaderText = "Payment";
            booking_view.Columns["loyalty_points"].HeaderText = "Loyalty Points";
            booking_view.Columns["cus_name"].Width = 200;
            booking_view.Columns["table_size"].Width = 200;
            booking_view.Columns["no_person"].Width = 250;
            booking_view.Columns["date"].Width = 250;
            booking_view.Columns["address"].Width = 200;
            booking_view.Columns["mobile"].Width = 250;
            booking_view.Columns["loyalty_points"].Width = 250;
         

        }
        private void displaydata()
        {
            string query = "select * from booking ORDER BY booking_id";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            booking_view.DataSource = dt;
            this.booking_view.Columns["booking_id"].Visible = false;
        }



        private void add_button_Click(object sender, EventArgs e)
        {
           
            Add_Table_reservation form = new Add_Table_reservation();
            form.btn_update.Visible = false;
            form.btn_add.Visible = true;
            form.DateValidation();
            form.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
       
        private void delete_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (booking_view.Rows.Count > 0)
            {
                string str = "DELETE from booking WHERE booking_id = '" + booking_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    booking_view.Rows.RemoveAt(booking_view.SelectedRows[i].Index);


                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("BACK TO THE FORM", "RETURN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Please Select the row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

           
            Billing_Form bill_form = new Billing_Form();
            
            decimal payment = (decimal)booking_view.CurrentRow.Cells[12].Value;
            decimal points = (decimal)booking_view.CurrentRow.Cells[13].Value;
            bill_form.discount = (payment + points);
            bill_form.txt_cus.Text = id;
            bill_form.cus_name = booking_view.CurrentRow.Cells[1].Value.ToString();
            bill_form.mobile = booking_view.CurrentRow.Cells[9].Value.ToString();
            bill_form.btn_back.Visible = true;
            bill_form.ShowDialog();

        }

        private void booking_view_Click(object sender, EventArgs e)
        {
        }
       
        private void booking_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = booking_view.Rows[e.RowIndex];
                booking_id = row.Cells[0].Value.ToString();
                id= booking_view.Rows[e.RowIndex].Cells["booking_id"].Value.ToString();
            }
           

        }

        private void booking_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void booking_view_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void booking_view_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void view_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Add_Table_reservation form = new Add_Table_reservation();
            form.cus_name.Text = booking_view.CurrentRow.Cells[1].Value.ToString();
            form.size.Value = int.Parse(booking_view.CurrentRow.Cells[2].Value.ToString());
            string t_size = booking_view.CurrentRow.Cells[3].Value.ToString();

            if (t_size == "small")
            {
                form.small.Checked = true;
                form.small.Enabled = true;
                form.medium.Enabled = false;
                form.big.Enabled = false;
                form.large.Enabled = false;
                form.ex_large.Enabled = false;
            }
            if (t_size == "medium")
            {
                form.medium.Checked = true;
                form.medium.Enabled = true;
                form.small.Enabled = false;
                form.big.Enabled = false;
                form.large.Enabled = false;
                form.ex_large.Enabled = false;
            }
            if (t_size == "big")
            {
                form.big.Checked = true;
                form.big.Enabled = true;
                form.medium.Enabled = false;
                form.small.Enabled = false;
                form.large.Enabled = false;
                form.ex_large.Enabled = false;
            }
            if (t_size == "large")
            {
                form.large.Checked = true;
                form.large.Enabled = true;
                form.medium.Enabled = false;
                form.small.Enabled = false;
                form.big.Enabled = false;
                form.ex_large.Enabled = false;
            }
            if (t_size == "ex_large")
            {
                form.ex_large.Checked = true;
                form.ex_large.Enabled = true;
                form.medium.Enabled = false;
                form.small.Enabled = false;
                form.big.Enabled = false;
                form.large.Enabled = false;

            }
            form.monthCalendar1.Visible = true;
            form.monthCalendar1.SelectionStart = DateTime.Parse(booking_view.CurrentRow.Cells[4].Value.ToString());
            form.monthCalendar1.SelectionEnd = DateTime.Parse(booking_view.CurrentRow.Cells[4].Value.ToString());
            form.start_picker.Enabled = true;
            form.end_picker.Enabled = true;
            form.start_picker.Text = booking_view.CurrentRow.Cells[5].Value.ToString();
            form.end_picker.Text = booking_view.CurrentRow.Cells[6].Value.ToString();
            form.table_box.Enabled = false;
            form.btn_check.Visible = true;
            form.btn_check.Enabled = true;
            form.load_comboBox();

            form.table_box.SelectedItem = booking_view.CurrentRow.Cells[7].Value.ToString();
            form.address_txt.Text = booking_view.CurrentRow.Cells[8].Value.ToString();
            form.mobile_txt.Text = booking_view.CurrentRow.Cells[9].Value.ToString();
            form.email_txt.Text = booking_view.CurrentRow.Cells[10].Value.ToString();
            form.comment_txt.Text = booking_view.CurrentRow.Cells[11].Value.ToString();
            form.price_txt.Text = booking_view.CurrentRow.Cells[12].Value.ToString();
            form.point_txt.Text = booking_view.CurrentRow.Cells[13].Value.ToString();
            form.btn_update.Visible = true;
            form.btn_add.Visible = false;
            form.btn_reset.Visible = false;
            form.reservation_id = id;
            form.ShowDialog();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM booking WHERE date = '" + dateTimePicker1.Text + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            booking_view.DataSource = dt;
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string query = "select * from booking";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            booking_view.DataSource = dt;
        }

        private void booking_view_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < booking_view.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    booking_view.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }

        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
