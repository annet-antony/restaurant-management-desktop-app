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
    public partial class View_Stock : Form
    {
        DB_Connection_class DbObject = new DB_Connection_class();
        public string stock_id = null;
        string id;
        public View_Stock()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Stock form1 = new Add_Stock();

          
            form1.ShowDialog();
        }

        private void View_Stock_Load(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            string query = "select * from stock ORDER BY code";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            stock_grid.DataSource = dt;
            this.stock_grid.Columns["Code"].Visible = false;
            this.stock_grid.Columns["Category"].Width = 200;
            this.stock_grid.Columns["Name"].Width = 200;
            this.stock_grid.Columns["Description"].Width = 250;
            this.stock_grid.Columns["Measurement"].Width = 230;
            this.stock_grid.Columns["Unit_Price"].Width = 200;
            this.stock_grid.Columns["Count"].Width = 200;
            this.stock_grid.Columns["Cost"].Width = 200;
            this.stock_grid.Columns["Status"].Width = 200;
            this.stock_grid.Columns["Has_Expiry"].Width = 250;
            this.stock_grid.Columns["Expiry_Date"].Width = 250;
            this.stock_grid.Columns["Store_No"].Width = 200;
            this.stock_grid.Columns["Shelf_No"].Width = 200;
            this.stock_grid.Columns["Supplier"].Width = 200;
            this.stock_grid.Columns["Manufacturer"].Width = 250;
            this.stock_grid.Columns["Edited_By"].Width = 200;
            this.stock_grid.Columns["Edited_On"].Width = 200;
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (stock_grid.Rows.Count > 0)
            {
                string str = "DELETE from stock WHERE Code = '" + stock_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stock_grid.Rows.RemoveAt(stock_grid.SelectedRows[i].Index);


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

        private void btn_update_Click(object sender, EventArgs e)
        {
            Add_Stock form = new Add_Stock();

            form.btn_add.Visible = false;
            form.btn_update.Show();
            form.btn_reset.Hide();

            form.txt_code.Text = stock_grid.CurrentRow.Cells[0].Value.ToString();
            form.cathegory_box.SelectedItem = stock_grid.CurrentRow.Cells[1].Value.ToString();
            form.txt_name.Text = stock_grid.CurrentRow.Cells[2].Value.ToString();
            form.txt_description.Text = stock_grid.CurrentRow.Cells[3].Value.ToString();
            form.measurement_box.SelectedItem = stock_grid.CurrentRow.Cells[4].Value.ToString();
            form.txt_price.Text = stock_grid.CurrentRow.Cells[5].Value.ToString();

            if (form.cathegory_box.SelectedItem.ToString() == "Kitchen Appliances")
            {
                form.count_value.Visible = true;
                form.count_value.Value =Convert.ToInt32(stock_grid.CurrentRow.Cells[6].Value);
                form.txt_count.Visible = false;
            }
            else
            {
                form.count_value.Visible = false;
                form.txt_count.Text = stock_grid.CurrentRow.Cells[6].Value.ToString();
                form.txt_count.Visible = true;
            }
            form.txt_cost.Text = stock_grid.CurrentRow.Cells[7].Value.ToString();
            form.status_box.SelectedItem = stock_grid.CurrentRow.Cells[8].Value.ToString();

            string selection = stock_grid.CurrentRow.Cells[9].Value.ToString();

            if (selection == form.expiry_y.Text)
            {
                form.expiry_y.Checked = true;
                form.monthCalendar1.Visible = true;
            }
            else
            {
                form.expiry_n.Checked = true;
                form.monthCalendar1.Visible = false;

            }
            if(form.monthCalendar1.Visible == true)
            {
                form.monthCalendar1.SelectionStart = DateTime.Parse(stock_grid.CurrentRow.Cells[10].Value.ToString());
                form.monthCalendar1.SelectionEnd = DateTime.Parse(stock_grid.CurrentRow.Cells[10].Value.ToString());
            }
            form.store_value.Value = (int)stock_grid.CurrentRow.Cells[11].Value;
            form.shelf_value.Value = (int)stock_grid.CurrentRow.Cells[12].Value;
            form.loadSupplier();
            form.supplier_box.SelectedItem = stock_grid.CurrentRow.Cells[13].Value.ToString();
            form.txt_manufacturer.Text = stock_grid.CurrentRow.Cells[14].Value.ToString();            
            form.stock_id = id;
            form.ShowDialog();
        }

        private void stock_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = stock_grid.Rows[e.RowIndex];
                stock_id = row.Cells[0].Value.ToString();
                id = stock_grid.Rows[e.RowIndex].Cells["Code"].Value.ToString();

            }
        }

        private void cathegory_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cathegory_box.SelectedItem.ToString() == "All")
            {
                
                displaydata();
            }
            else
            {               
                string query = "select * from stock WHERE category = '"+cathegory_box.SelectedItem.ToString()+"'";

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
                ada.Fill(dt);
                stock_grid.DataSource = dt;
                
            }
            
        }

        private void cathegory_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

