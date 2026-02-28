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
    public partial class view_wastage : Form
    {
        public string wastage_id = null;
        string id;
        DB_Connection_class DbObject = new DB_Connection_class();
        public view_wastage()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Wastage form1 = new Add_Wastage();

            form1.btn_add.Visible = true;

            form1.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (wastage_grid.Rows.Count > 0)
            {
                string str = "DELETE from wastage WHERE wastage_id = '" + wastage_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wastage_grid.Rows.RemoveAt(wastage_grid.SelectedRows[i].Index);


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

        private void view_wastage_Load(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            string query = "select * from wastage ORDER BY wastage_id ";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            wastage_grid.DataSource = dt;
            this.wastage_grid.Columns["wastage_id"].Visible = false;
            wastage_grid.Columns["date"].HeaderText = "Date";
            wastage_grid.Columns["selection"].HeaderText = "Selection";
            wastage_grid.Columns["cathegory"].HeaderText = "Category";
            wastage_grid.Columns["name"].HeaderText = "Name";
            wastage_grid.Columns["measurement"].HeaderText = "Measurement";
            wastage_grid.Columns["unit_price"].HeaderText = "Unit Price";
            wastage_grid.Columns["wastage_amount"].HeaderText = "Waste Amount";
            wastage_grid.Columns["cost"].HeaderText = "Total Cost";
            wastage_grid.Columns["reason"].HeaderText = "Reason";
            wastage_grid.Columns["employee"].HeaderText = "Added By";
            wastage_grid.Columns["added_on"].HeaderText = "Added On";
            wastage_grid.Columns["date"].Width = 200;
            wastage_grid.Columns["selection"].Width = 200;
            wastage_grid.Columns["cathegory"].Width = 250;
            wastage_grid.Columns["name"].Width = 200;
            wastage_grid.Columns["measurement"].Width =250;
            wastage_grid.Columns["unit_price"].Width = 200;
            wastage_grid.Columns["wastage_amount"].Width = 250;
            wastage_grid.Columns["cost"].Width = 250;
            wastage_grid.Columns["reason"].Width = 200;
            wastage_grid.Columns["employee"].Width = 200;
            wastage_grid.Columns["added_on"].Width = 200;
        }

        private void wastage_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = wastage_grid.Rows[e.RowIndex];
                wastage_id = row.Cells[0].Value.ToString();
                id = wastage_grid.Rows[e.RowIndex].Cells["wastage_id"].Value.ToString();

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Add_Wastage form = new Add_Wastage();

            form.btn_add.Visible = false;
            form.btn_update.Show();
            form.btn_reset.Hide();

            form.txt_ID.Text = wastage_grid.CurrentRow.Cells[0].Value.ToString();
            form.monthCalendar1.SelectionStart = DateTime.Parse(wastage_grid.CurrentRow.Cells[1].Value.ToString());
            form.monthCalendar1.SelectionEnd = DateTime.Parse(wastage_grid.CurrentRow.Cells[1].Value.ToString());
            string type = wastage_grid.CurrentRow.Cells[2].Value.ToString();
            if(type == form.radio_food.Text)
            {
                form.radio_food.Checked = true;
                form.cathegory_box.Visible = true;
                form.loadCathegory();
                form.cathegory_box.SelectedItem = wastage_grid.CurrentRow.Cells[3].Value.ToString();

            }
            else
            {
                form.radio_raw.Checked = true;
                form.cathegory_box.Visible = false;
            }
            form.loadNameBox();
            form.name_box.SelectedItem = wastage_grid.CurrentRow.Cells[4].Value.ToString();
            form.loadMeasurement();
            form.measure_box.SelectedItem = wastage_grid.CurrentRow.Cells[5].Value.ToString();
            form.txt_unit_price.Text = wastage_grid.CurrentRow.Cells[6].Value.ToString();
            if (form.radio_food.Checked ==  true || form.measure_box.SelectedItem.ToString() == "Head")
            {
                form.unit_box.Visible = true;
                form.unit_box.Value = Convert.ToInt32(wastage_grid.CurrentRow.Cells[7].Value);
            }
            else
            {
                form.txt_amount.Visible = true;
                form.txt_amount.Text = wastage_grid.CurrentRow.Cells[7].Value.ToString();
            }
            
            form.txt_cost.Text = wastage_grid.CurrentRow.Cells[8].Value.ToString();
            form.txt_reason.Text = wastage_grid.CurrentRow.Cells[9].Value.ToString();
            form.wastage_id = id;
            form.ShowDialog();
        }

        private void cathegory_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cathegory_box.SelectedItem.ToString() == "All")
            {
             
                displaydata();
            }
            else
            {
              
                string query = "select * from wastage WHERE selection = '" + cathegory_box.SelectedItem.ToString() + "'";

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
                ada.Fill(dt);
                wastage_grid.DataSource = dt;
                
            }
        }

        private void cathegory_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wastage_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < wastage_grid.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    wastage_grid.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
