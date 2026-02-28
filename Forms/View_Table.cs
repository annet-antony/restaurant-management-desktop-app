using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DbConnection;


namespace Restaurant_Project
{
    public partial class View_Table : Form
    {
       
        string tablegrid_id = null;
        DB_Connection_class DbObject = new DB_Connection_class();
        string id = "";

        public View_Table()
        {
            InitializeComponent();
        }

        private void View_Table_Load(object sender, EventArgs e)
        {

            DisplayData();
        }
        private void DisplayData()
        {
            string query = "select * from table_reservation ORDER BY table_id";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            TableGridView.DataSource = dt;
            this.TableGridView.Columns["table_id"].Visible = false;
            this.TableGridView.Columns["table_id"].Name = "ID_Column";
            TableGridView.Columns["table_size"].HeaderText = "Size";
            TableGridView.Columns["table_no"].HeaderText = "Table No";
            TableGridView.Columns["table_shape"].HeaderText = "Shape";
            TableGridView.Columns["table_condition"].HeaderText = "Condition";
         
            TableGridView.Columns["no_of_people"].HeaderText = "Capacity";
            TableGridView.Columns["reservation_price"].HeaderText = "Reservation Price";
            TableGridView.Columns["table_manufacturer"].HeaderText = "Manufacturer";
            TableGridView.Columns["table_date_purchase"].HeaderText = "Purchase Date";
            this.TableGridView.Columns["table_size"].Width = 150;
            TableGridView.Columns["table_no"].Width = 200;
            TableGridView.Columns["table_shape"].Width = 200;
            TableGridView.Columns["table_condition"].Width = 200;
          
            TableGridView.Columns["no_of_people"].Width = 200;
            TableGridView.Columns["reservation_price"].Width = 200;
            TableGridView.Columns["table_manufacturer"].Width = 200;
            TableGridView.Columns["table_date_purchase"].Width = 200;


        }


        private void delete_button_Click(object sender, EventArgs e)
        {

            int i = 0;
            if (TableGridView.Rows.Count > 0 )
            {
                string str = "DELETE from table_reservation WHERE table_id = '" + tablegrid_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TableGridView.Rows.RemoveAt(TableGridView.SelectedRows[i].Index);


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

        private void add_button_Click(object sender, EventArgs e)
        {
            Add_Tables table = new Add_Tables();
            table.btn_add.Visible = true;
            table.btn_update.Hide();
           
            table.ShowDialog();
           
        }
       
        private void update_button_Click(object sender, EventArgs e)
        {
            Add_Tables table = new Add_Tables();
           
            table.btn_add.Visible = false;
            table.btn_update.Show();
            table.btn_reset.Hide();

            table.size_box.SelectedItem = TableGridView.CurrentRow.Cells[1].Value.ToString();
            table.loadComboBox();

            table.table_no.Value = int.Parse(TableGridView.CurrentRow.Cells[2].Value.ToString());
            table.shape_box.SelectedItem = TableGridView.CurrentRow.Cells[3].Value.ToString();
            table.condition_box.SelectedItem = TableGridView.CurrentRow.Cells[4].Value.ToString();
            table.people_txt.Text = TableGridView.CurrentRow.Cells[5].Value.ToString();
            table.price_txt.Text = TableGridView.CurrentRow.Cells[6].Value.ToString();
            table.txt_manufacturer.Text = TableGridView.CurrentRow.Cells[7].Value.ToString();
            table.monthCalendar1.SelectionStart = DateTime.Parse(TableGridView.CurrentRow.Cells[8].Value.ToString());
            table.monthCalendar1.SelectionEnd = DateTime.Parse(TableGridView.CurrentRow.Cells[8].Value.ToString());
            table.table_id = id;
            table.ShowDialog();

        }

       

        private void TableGridView_DoubleClick(object sender, EventArgs e)
        {
          

        }

        private void TableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void TableGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void TableGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = TableGridView.Rows[e.RowIndex];
                tablegrid_id = row.Cells[0].Value.ToString();
                id = TableGridView.Rows[e.RowIndex].Cells["ID_Column"].Value.ToString();
            }
        }

        private void TableGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < TableGridView.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    TableGridView.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
    
}
