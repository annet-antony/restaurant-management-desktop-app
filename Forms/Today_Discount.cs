using DbConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class Today_Discount : Form
    {
        DB_Connection_class DbObject = new DB_Connection_class();
        public int count = 0;
        private static ArrayList List_S_Date = new ArrayList();
        private static ArrayList List_E_Date = new ArrayList();
        private static ArrayList List_ID = new ArrayList();
        public Today_Discount()
        {
            InitializeComponent();
        }

        private void Today_Discount_Load(object sender, EventArgs e)
        {
            load_Today_discount();
        }
        public void load_Today_discount()
        {
            string query = "SELECT start_from, end_on, discount_id FROM discount ";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(query);
            List_ID.Clear();
            List_E_Date.Clear();
            List_S_Date.Clear();

            while (drd.Read())
            {
                List_S_Date.Add(drd["start_from"].ToString());
                List_E_Date.Add(drd["end_on"].ToString());
                List_ID.Add(drd["discount_id"].ToString());

            }
            DbObject.CloseConnection();

            DateTime t1 = DateTime.Parse(DateTime.Now.ToShortDateString());
             
            for (int i = 0; i < List_ID.Count; i++)
            {
                DateTime t2 = DateTime.Parse(List_S_Date[i].ToString());
                DateTime t3 = DateTime.Parse(List_E_Date[i].ToString());

                count = 0;

                if (t1 >= t2 && t1 <= t3)
                {
                    count++;
                    DbObject.OpenConnection();
                    DataTable dt = new DataTable();
                    string qry = "select category, food_name, dis_percent, fixed_price, deduct_price, current_price from discount WHERE discount_id = '" + List_ID[i] + "'";
                    MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(qry);
                    ada.Fill(dt);
                    today_discount_grid.DataSource = dt;
                    DbObject.CloseConnection();
                }

            }
            if (count == 0)
            {
                MessageBox.Show("No Discounts For Today!!!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void today_discount_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < today_discount_grid.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    today_discount_grid.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
