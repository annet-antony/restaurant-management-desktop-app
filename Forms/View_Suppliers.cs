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
    public partial class View_Suppliers : Form
    {
        DB_Connection_class DbObject = new DB_Connection_class();
        public string supplier_id = null;
        string id;
        public View_Suppliers()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          Add_Supplier form1 = new Add_Supplier();

            form1.btn_add.Visible = true;
            form1.add_date_validations();
            form1.ShowDialog();
        }

        private void View_Suppliers_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (supplier_grid.Rows.Count > 0)
            {
                string str = "DELETE from supplier WHERE supplier_id = '" + supplier_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    supplier_grid.Rows.RemoveAt(supplier_grid.SelectedRows[i].Index);


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

        private void supplier_grid_Click(object sender, EventArgs e)
        {
        }

        private void supplier_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = supplier_grid.Rows[e.RowIndex];
                supplier_id = row.Cells[0].Value.ToString();
                id = supplier_grid.Rows[e.RowIndex].Cells["ID_Column"].Value.ToString();

            }
        }
        private void DisplayData()
        {         
            string query = "select * from supplier ORDER BY supplier_id ";
           
            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            supplier_grid.DataSource = dt;
            this.supplier_grid.Columns["supplier_id"].Visible = false;
            this.supplier_grid.Columns["name"].Width = 200;
            this.supplier_grid.Columns["address"].Width = 300;
            this.supplier_grid.Columns["email"].Width = 250;
            this.supplier_grid.Columns["edit_by"].Width = 200;
            this.supplier_grid.Columns["edit_on"].Width = 200;
            this.supplier_grid.Columns["supplied_from"].Width = 250;
            this.supplier_grid.Columns["supplier_id"].Name = "ID_Column";
            this.supplier_grid.Columns["name"].HeaderText = "Name";
            this.supplier_grid.Columns["address"].HeaderText = "Address";
            this.supplier_grid.Columns["email"].HeaderText = "Email";
            this.supplier_grid.Columns["supplied_from"].HeaderText = "Supplied From";
            this.supplier_grid.Columns["edit_by"].HeaderText = "Added By";
            this.supplier_grid.Columns["edit_on"].HeaderText = "Added On";
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Add_Supplier form = new Add_Supplier();
            form.btn_add.Visible = false;
            form.btn_update.Visible = true;
            form.btn_reset.Visible = false;
            form.txt_ID.Text = supplier_grid.CurrentRow.Cells[0].Value.ToString();
            form.txt_name.Text = supplier_grid.CurrentRow.Cells[1].Value.ToString();
            form.txt_address.Text = supplier_grid.CurrentRow.Cells[2].Value.ToString();
            form.txt_mobile.Text = supplier_grid.CurrentRow.Cells[3].Value.ToString();
            form.txt_email.Text = supplier_grid.CurrentRow.Cells[4].Value.ToString();
            form.monthCalendar.SelectionStart = DateTime.Parse(supplier_grid.CurrentRow.Cells[5].Value.ToString());
            form.monthCalendar.SelectionEnd = DateTime.Parse(supplier_grid.CurrentRow.Cells[5].Value.ToString());
            form.txt_ID.Text = id;
            form.ShowDialog();
        }

        private void supplier_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < supplier_grid.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    supplier_grid.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
