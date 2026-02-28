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
    public partial class View_cathegory : Form
    {
        private static ArrayList List_ID= new ArrayList();
        private static ArrayList List_Name = new ArrayList();
        private static ArrayList List_Size = new ArrayList();
        private static ArrayList List_Type = new ArrayList();
        
        public  string  cathegory_id = null;
        public static  string id = " ";
        DB_Connection_class DbObject = new DB_Connection_class();
        public View_cathegory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cathegory_add_Click(object sender, EventArgs e)
        {

            Add_Cathegory form = new Add_Cathegory();
            form.btn_cathegory_update.Visible = false;
            form.ShowDialog();

        }

        private void cathegory_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
      

        private void View_cathegory_Load(object sender, EventArgs e)
        {
            loadData();

           
        }
       
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (cathegory_grid.Rows.Count > 0)
            {
                string str = "DELETE from cathegory WHERE cathegory_id = '" + cathegory_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cathegory_grid.Rows.RemoveAt(cathegory_grid.SelectedRows[i].Index);


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

        private void cathegory_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = cathegory_grid.Rows[e.RowIndex];
                cathegory_id = row.Cells[1].Value.ToString();
                id= cathegory_grid.Rows[e.RowIndex].Cells["ID_column"].Value.ToString();
               
            }
           
        }

        private void cathegory_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Add_Cathegory form1 = new Add_Cathegory();
            form1.btn_cathegory_add.Visible = false;
            form1.btn_reset.Visible = false;
            form1.btn_cathegory_update.Show();


            form1.txt_cathegory.Text = cathegory_grid.CurrentRow.Cells[2].Value.ToString();
            string size = cathegory_grid.CurrentRow.Cells[3].Value.ToString();

            if (size == "Yes")
            {
                form1.size_y.Checked = true;
            }
            else
            {
                form1.size_n.Checked = true;
            }
            string type = cathegory_grid.CurrentRow.Cells[4].Value.ToString();

            if (type == "Yes")
            {
                form1.type_y.Checked = true;
            }
            else
            {
                form1.type_n.Checked = true;
            }
        }

        private void btn_cathegory_update_Click(object sender, EventArgs e)
        {
            Add_Cathegory form = new Add_Cathegory();

            form.btn_cathegory_add.Visible = false;
            form.btn_cathegory_update.Show();
            form.btn_reset.Hide();

            form.txt_cathegory.Text = cathegory_grid.CurrentRow.Cells[2].Value.ToString();
           
            string size =  cathegory_grid.CurrentRow.Cells[3].Value.ToString();
            if(size == form.size_y.Text)
            {
                form.size_y.Checked = true;
            }
            else
            {
                form.size_n.Checked = true;

            }
            string type = cathegory_grid.CurrentRow.Cells[4].Value.ToString();
            if (type == form.type_y.Text)
            {
                form.type_y.Checked = true;
            }
            else
            {
                form.type_n.Checked = true;

            }
            form.cathegory_id = id;
            form.ShowDialog();
        }

        private void cathegory_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cathegory_grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.cathegory_grid.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        public void loadData()
        {
            array_clear();
            GetFoodData();

            if (List_ID.Count > 0)
            {
                updateFoodDataGridView();
            }
            else
            {
                MessageBox.Show("Data Not Found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void array_clear()
        {
            List_ID.Clear();
            List_Name.Clear();
            List_Size.Clear();
            List_Type.Clear();
        }

        public void GetFoodData()
        {
            try
            {
                DbObject.OpenConnection();
                string query = "select * from cathegory ";

                MySqlDataReader row;
                row = DbObject.DataReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        List_ID.Add(row["cathegory_id"].ToString());
                        List_Name.Add(row["name"].ToString());
                        List_Size.Add(row["size_available"].ToString());
                        List_Type.Add(row["type_available"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Data Not Found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                DbObject.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        private void updateFoodDataGridView()
        {
            cathegory_grid.Rows.Clear();
            for (int i = 0; i < List_ID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(cathegory_grid);
                newRow.Cells[1].Value = List_ID[i];
                newRow.Cells[2].Value = List_Name[i];
                newRow.Cells[3].Value = List_Size[i];
                newRow.Cells[4].Value = List_Type[i];
                cathegory_grid.Rows.Add(newRow);
            }
        }

        private void cathegory_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < cathegory_grid.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    cathegory_grid.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }

        
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}