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
    public partial class View_Bill : Form
    {
        private static ArrayList List_billID = new ArrayList();
        private static ArrayList List_cusID = new ArrayList();
        private static ArrayList List_items = new ArrayList();
        private static ArrayList List_total = new ArrayList();
        private static ArrayList List_discount = new ArrayList();
        private static ArrayList List_payable = new ArrayList();
        private static ArrayList List_paid = new ArrayList();
        private static ArrayList List_balance = new ArrayList();
        private static ArrayList List_name = new ArrayList();
        private static ArrayList List_date= new ArrayList();
        private static ArrayList List_time = new ArrayList();
        public string Bill_id = null;
        DB_Connection_class DbObject = new DB_Connection_class();
        public View_Bill()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            View_Order form1 = new View_Order();
            if(Bill_id != null)
            {
                form1.order_id = Bill_id;
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select row ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
           
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
           
            app.Visible = true;
            worksheet = workbook.ActiveSheet; 
            for (int i = 1; i < Bill_Grid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Bill_Grid.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < Bill_Grid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Bill_Grid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Bill_Grid.Rows[i].Cells[j].Value.ToString();
                }
            }
            app.Quit();
        }

        private void View_Bill_Load(object sender, EventArgs e)
        {
            loadData();
            date_picker.MaxDate = DateTime.Now.Date;
            date_picker.Format = DateTimePickerFormat.Custom;
            date_picker.CustomFormat = "MM/dd/yyyy";
        }
        public void loadData()
        {
            array_clear();
            string query = "select * from invoices ORDER BY entered_on ";
            GetFoodData(query);

            if (List_billID.Count > 0)
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
        List_billID.Clear();
        List_cusID.Clear(); 
        List_items.Clear(); 
        List_total.Clear(); 
        List_discount.Clear(); 
        List_payable.Clear();
        List_paid.Clear();
        List_balance.Clear(); 
        List_name.Clear(); 
        List_date.Clear();
        List_time.Clear();
        }
        public void GetFoodData(string qry)
        {
            try
            {
                DbObject.OpenConnection();
                string query = qry;

                MySqlDataReader row;
                row = DbObject.DataReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        List_billID.Add(row["bill_id"].ToString());
                        List_cusID.Add(row["cus_id"].ToString());
                        List_items.Add(row["purchased_items"].ToString());
                        List_total.Add(row["total_price"].ToString());
                        List_discount.Add(row["discount"].ToString());
                        List_payable.Add(row["amount_pay"].ToString());
                        List_paid.Add(row["paid_amount"].ToString());
                        List_balance.Add(row["balance"].ToString());
                        List_name.Add(row["name"].ToString());
                        List_date.Add(row["entered_on"].ToString());
                        List_time.Add(row["time"].ToString());
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
            Bill_Grid.Rows.Clear();
            for (int i = 0; i < List_billID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(Bill_Grid);
                newRow.Cells[0].Value = List_billID[i];
                newRow.Cells[1].Value = List_cusID[i];
                newRow.Cells[2].Value = List_items[i];
                newRow.Cells[3].Value = List_total[i];
                newRow.Cells[4].Value = List_discount[i];
                newRow.Cells[5].Value = List_payable[i];
                newRow.Cells[6].Value = List_paid[i];
                newRow.Cells[7].Value = List_balance[i];
                newRow.Cells[8].Value = List_name[i];
                newRow.Cells[9].Value = List_date[i];
                newRow.Cells[10].Value = List_time[i];

                Bill_Grid.Rows.Add(newRow);
            }
        }

        private void Bill_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Bill_Grid.Rows[e.RowIndex];
                Bill_id = row.Cells[0].Value.ToString();
                

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Bill_Grid.Rows.Count > 0)
            {
                string str = "DELETE from invoices WHERE bill_id = '" + Bill_id + "'";
                string query = "DELETE from billing WHERE bill_id = '" + Bill_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(query);
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bill_Grid.Rows.RemoveAt(Bill_Grid.SelectedRows[i].Index);

                    DbObject.CloseConnection();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM invoices WHERE entered_on = '"+ date_picker.Text+ "' ORDER BY bill_id";
            array_clear();
            GetFoodData(query);

            if (List_billID.Count > 0)
            {
                updateFoodDataGridView();
            }
           
        }

        private void Bill_Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < Bill_Grid.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    Bill_Grid.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }

        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
