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
    public partial class View_Discount : Form
    {
       
        public string discount_id = null;
        string id;
        DB_Connection_class DbObject = new DB_Connection_class();
        private static ArrayList List_Date = new ArrayList();
        private static ArrayList List_Status = new ArrayList();
        private static ArrayList List_ID = new ArrayList();
        public View_Discount()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Discount form1 = new Add_Discount();
            form1.ShowDialog();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (discount_grid.Rows.Count > 0)
            {
                string str = "DELETE from discount WHERE discount_id = '" + discount_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    discount_grid.Rows.RemoveAt(discount_grid.SelectedRows[i].Index);


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

        private void View_Discount_Load(object sender, EventArgs e)
        {
            changeStatus();
            displaydata();
          


        }
        private void displaydata()
        {
            string query = "select * from discount ORDER BY discount_id";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
           discount_grid.DataSource = dt;
            this.discount_grid.Columns["discount_id"].Visible = false;
            this.discount_grid.Columns["food_id"].Visible = false;
            discount_grid.Columns["category"].HeaderText = "Category";
            discount_grid.Columns["food_name"].HeaderText = "Food Name";
            discount_grid.Columns["status"].HeaderText = "Status";
            discount_grid.Columns["selection"].HeaderText = "Selection";
            discount_grid.Columns["dis_percent"].HeaderText = "Discount percent";
            discount_grid.Columns["fixed_price"].HeaderText = "Fixed Price";
            discount_grid.Columns["deduct_price"].HeaderText = "Deduct Price";
            discount_grid.Columns["current_price"].HeaderText = "Current Price";
            discount_grid.Columns["start_from"].HeaderText = "Start From";
            discount_grid.Columns["end_on"].HeaderText = "End On";
            discount_grid.Columns["added_by"].HeaderText = "Added By";
            discount_grid.Columns["added_on"].HeaderText = "Added On";
            discount_grid.Columns["selection"].Width = 250;
            discount_grid.Columns["fixed_price"].Width = 200;
            discount_grid.Columns["deduct_price"].Width = 200;
            discount_grid.Columns["current_price"].Width = 200;

        }


        private void discount_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = discount_grid.Rows[e.RowIndex];
                discount_id = row.Cells[0].Value.ToString();
                id = discount_grid.Rows[e.RowIndex].Cells["discount_id"].Value.ToString();

            }
        }

        private void status_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "select * from discount WHERE status = '"+status_box.SelectedItem.ToString()+"'";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            discount_grid.DataSource = dt;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Add_Discount form = new Add_Discount();

            form.btn_add.Visible = false;
            form.btn_update.Show();
            form.btn_reset.Hide();

            form.txt_ID.Text = discount_grid.CurrentRow.Cells[0].Value.ToString();
            form.loadCathegory();
            form.cathegory_box.SelectedItem = discount_grid.CurrentRow.Cells[1].Value.ToString();
            form.loadFood();
            form.name_box.SelectedItem = discount_grid.CurrentRow.Cells[2].Value.ToString();
           
            form.txt_food_id.Text = discount_grid.CurrentRow.Cells[3].Value.ToString();
            form.status_box.SelectedItem = discount_grid.CurrentRow.Cells[4].Value.ToString();
            form.loadsizes();
            form.size_box.SelectedItem = discount_grid.CurrentRow.Cells[5].Value.ToString();
            /*form.discount_value.Value = int.Parse(discount_grid.CurrentRow.Cells[6].Value.ToString());*/
           
            form.f_price = decimal.Parse(discount_grid.CurrentRow.Cells[7].Value.ToString());
            form.d_amount = decimal.Parse(discount_grid.CurrentRow.Cells[8].Value.ToString());
            form.c_amount = decimal.Parse(discount_grid.CurrentRow.Cells[9].Value.ToString());
            form.start_calender.SelectionStart = DateTime.Parse(discount_grid.CurrentRow.Cells[10].Value.ToString());
            form.start_calender.SelectionEnd = DateTime.Parse(discount_grid.CurrentRow.Cells[10].Value.ToString());
            form.end_calender.SelectionStart = DateTime.Parse(discount_grid.CurrentRow.Cells[11].Value.ToString());
            form.end_calender.SelectionEnd = DateTime.Parse(discount_grid.CurrentRow.Cells[11].Value.ToString());
            form.discount_id = id;
            form.ShowDialog();
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string query = "select * from discount";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            discount_grid.DataSource = dt;
           
        }
        public void changeStatus()
        {
            string query = "SELECT end_on, status, discount_id FROM discount ";
            
          
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(query);
            while (drd.Read())
            {
                List_Date.Add(drd["end_on"].ToString());
                List_Status.Add(drd["status"].ToString());
                List_ID.Add(drd["discount_id"].ToString());

            }
            DbObject.CloseConnection();

            DateTime t1 = DateTime.Parse(DateTime.Now.ToShortDateString());
         
            for (int i = 0; i < List_ID.Count; i++)
            {
                DateTime t2 = DateTime.Parse(List_Date[i].ToString());
               // int compared_start = TimeSpan.Compare(t1.TimeOfDay, t2.TimeOfDay);
                string status = "Expired";
                if (t1>t2)
                {
                    DbObject.OpenConnection();
                    string qry = "UPDATE discount SET  status = '" + status + "' WHERE discount_id = '" + List_ID[i].ToString() + "'";
                    DbObject.ExecuteQueries(qry);
                    DbObject.CloseConnection();
                }
            }

               

          
        }

        private void discount_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < discount_grid.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    discount_grid.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }

        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
