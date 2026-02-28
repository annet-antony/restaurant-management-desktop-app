using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DbConnection;
using MySql.Data.MySqlClient;

namespace Restaurant_Project
{
    public partial class View_Employee : Form
    {
        
        string employeegrid_id = null;
        string id = null;
        DB_Connection_class DbObject = new DB_Connection_class();
        public View_Employee()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            Add_Employee form1 = new Add_Employee();

            form1.register_button.Visible = true;
            form1.btn_update.Visible = false;
            form1.ShowDialog();
        }

        private void View_Employee_Load(object sender, EventArgs e)
        {
            DisplayData();
        }


        private void DisplayData()
        {
            string query = "select e_id, fname, lname, nic_no, gender, age, date_join, s_name, t_name, district, email, mobile, position, role, edited_on, edited_by  from employee";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            employee_grid.DataSource = dt;
            this.employee_grid.Columns["e_id"].Visible = false;
            this.employee_grid.Columns["e_id"].Name = "ID_Column";
            employee_grid.Columns["fname"].HeaderText = "First Name";
            employee_grid.Columns["lname"].HeaderText = "Last Name";
            employee_grid.Columns["fname"].Width = 200;
            employee_grid.Columns["lname"].Width = 200;
            employee_grid.Columns["nic_no"].HeaderText = "NIC";
            employee_grid.Columns["gender"].HeaderText = "Gender";
            employee_grid.Columns["age"].HeaderText = "Age";
            employee_grid.Columns["date_join"].HeaderText = "Date Joined";
            employee_grid.Columns["date_join"].Width = 200;
            employee_grid.Columns["s_name"].HeaderText = "Street";
            employee_grid.Columns["t_name"].HeaderText = "Town";
            employee_grid.Columns["district"].HeaderText = "District";
            employee_grid.Columns["email"].HeaderText = "Email";
            employee_grid.Columns["mobile"].HeaderText = "Mobile";
            employee_grid.Columns["position"].HeaderText = "Position";
            employee_grid.Columns["role"].HeaderText = "Role";
            employee_grid.Columns["edited_on"].HeaderText = "Edited On";
            employee_grid.Columns["edited_by"].HeaderText = "Edited By";
        }

            private void employee_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (employee_grid.Rows.Count > 0)
            {
                string str = "DELETE from food_management WHERE food_id = '" + employeegrid_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    employee_grid.Rows.RemoveAt(employee_grid.SelectedRows[i].Index);


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

        private void employee_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = employee_grid.Rows[e.RowIndex];
                employeegrid_id = row.Cells[0].Value.ToString();
                id = employee_grid.Rows[e.RowIndex].Cells["ID_Column"].Value.ToString();

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Add_Employee form = new Add_Employee();
            form.register_button.Visible = false;
            form.btn_update.Visible = true;
            form.reset_button.Visible = false;
            form.txt_ID.Text = employee_grid.CurrentRow.Cells[0].Value.ToString();
            form.fname_txt.Text = employee_grid.CurrentRow.Cells[1].Value.ToString();
            form.lname_txt.Text = employee_grid.CurrentRow.Cells[2].Value.ToString();
            form.nic_txt.Text = employee_grid.CurrentRow.Cells[3].Value.ToString();
            string gender = employee_grid.CurrentRow.Cells[4].Value.ToString();
            if(gender == form.female_select.Text)
            {
                form.female_select.Checked = true;
            }
            else
            {

                form.radio_male.Checked = true;
            }
            CultureInfo provider = CultureInfo.InvariantCulture;
            form.age_txt.Text = employee_grid.CurrentRow.Cells[5].Value.ToString();
            //form.dateTimePicker1.Text = (DateTime.ParseExact((string)employee_grid.CurrentRow.Cells[6].Value, "MM/dd/yyyy", provider, DateTimeStyles.None)).ToString();
            form.street_txt.Text = employee_grid.CurrentRow.Cells[7].Value.ToString();
            form.town_txt.Text = employee_grid.CurrentRow.Cells[8].Value.ToString();
            form.district_box.SelectedItem = employee_grid.CurrentRow.Cells[9].Value.ToString();

            form.email_txt.Text = employee_grid.CurrentRow.Cells[10].Value.ToString();
            form.mobile_txt.Text = employee_grid.CurrentRow.Cells[11].Value.ToString();
            form.position_box.SelectedItem = employee_grid.CurrentRow.Cells[12].Value.ToString();
            string role = employee_grid.CurrentRow.Cells[13].Value.ToString();
            if(role == "N/A")
            {
                form.system_userbox.Enabled = true;
            }
            else
            {
                form.system_userbox.Enabled = false;
               
            }
            form.e_id = id;
            form.ShowDialog();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string query = "select * from employee WHERE role = '" + comboBox2.SelectedItem.ToString() + "'";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            employee_grid.DataSource = dt;
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string query = "select e_id, fname, lname, nic_no, gender, age, date_join, s_name, t_name, district, email, mobile, position, role, edited_on, edited_by  from employee";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            employee_grid.DataSource = dt;
        }

        private void employee_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < employee_grid.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    employee_grid.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }

           
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
