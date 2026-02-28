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
    public partial class View_Order : Form
    {
        private static ArrayList List_ID = new ArrayList();
        private static ArrayList List_Name = new ArrayList();
        private static ArrayList List_Size = new ArrayList();
        private static ArrayList List_Quantity = new ArrayList();
        private static ArrayList List_Amount = new ArrayList();
        public  string order_id = " ";
        DB_Connection_class DbObject = new DB_Connection_class();
        public View_Order()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Order_Load(object sender, EventArgs e)
        {
            loadData();
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
            List_Quantity.Clear();
            List_Amount.Clear();
        }
        public void GetFoodData()
        {
            try
            {
                DbObject.OpenConnection();
                string query = "select * from billing WHERE bill_id = '" + order_id + "'";

                MySqlDataReader row;
                row = DbObject.DataReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        List_ID.Add(row["bill_id"].ToString());
                        List_Name.Add(row["food_name"].ToString());
                        List_Size.Add(row["size"].ToString());
                        List_Quantity.Add(row["quantity"].ToString());
                        List_Amount.Add(row["amount"].ToString());
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
            order_grid.Rows.Clear();
            for (int i = 0; i < List_ID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(order_grid);
                newRow.Cells[0].Value = List_ID[i];
                newRow.Cells[1].Value = List_Name[i];
                newRow.Cells[2].Value = List_Size[i];
                newRow.Cells[3].Value = List_Quantity[i];
                newRow.Cells[4].Value = List_Amount[i];
                order_grid.Rows.Add(newRow);
            }
        }

        private void order_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < order_grid.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    order_grid.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }

          
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
