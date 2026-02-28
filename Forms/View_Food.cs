using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DbConnection;
using MySql.Data.MySqlClient;

namespace Restaurant_Project
{
    public partial class view_food : Form
    {

        string foodgrid_id = null;
        public string id;
        DB_Connection_class DbObject = new DB_Connection_class();
        Add_Food form1 = new Add_Food();

        public view_food()
        {
            InitializeComponent();
        }

        private void View_Food_Load(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            string query = "select * from food_management";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);           
            FoodGridView.DataSource = dt;
            
                this.FoodGridView.Columns["food_id"].Visible = false;
                this.FoodGridView.Columns["food_id"].Name = "ID_Column";
                this.FoodGridView.Columns["cathegory"].HeaderText = "Category";
                this.FoodGridView.Columns["cathegory"].Width = 250;
                this.FoodGridView.Columns["food_name"].Width = 250;
                this.FoodGridView.Columns["ingredients"].Width = 250;
                this.FoodGridView.Columns["description"].Width = 250;
                this.FoodGridView.Columns["ingredient_available"].Width = 250;
                this.FoodGridView.ColumnHeadersHeight = 100;
            this.FoodGridView.Columns["food_name"].HeaderText = "Food Name";
            this.FoodGridView.Columns["ingredient_available"].HeaderText = "Available Ingredient";
            this.FoodGridView.Columns["ingredients"].HeaderText = "Ingredients";
            this.FoodGridView.Columns["small"].HeaderText = "Small";
            this.FoodGridView.Columns["medium"].HeaderText = "Medium";
            this.FoodGridView.Columns["large"].HeaderText = "Large";
            this.FoodGridView.Columns["description"].HeaderText = "Description";
            this.FoodGridView.Columns["added_by"].HeaderText = "Added By";
        }

        private void cathegory_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FoodGridView_Click(object sender, EventArgs e)
        {

        }

        private void FoodGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            form1.add_food_button.Visible = true;
            form1.btn_update.Hide();
            form1.ShowDialog();
        }     
        private void cathegory_box_Click(object sender, EventArgs e)
        {
            cathegory_box.Items.Clear();
            loadcategory();



        }
        private void loadcategory()
        {
            string query = "select name FROM cathegory";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(query);
            while (drd.Read())
            {
                cathegory_box.Items.Add(drd["name"].ToString());
            }
            DbObject.CloseConnection();
        }
        

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int i = 0;
            if (FoodGridView.Rows.Count > 0)
            {
                string str = "DELETE from food_management WHERE food_id = '" + foodgrid_id + "'";
                DbObject.OpenConnection();

                DialogResult dialogResult = MessageBox.Show("Do you want to DELETE the record ", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DbObject.ExecuteQueries(str);
                    MessageBox.Show("Deleted Sucessfully", "DELETED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FoodGridView.Rows.RemoveAt(FoodGridView.SelectedRows[i].Index);


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

        private void FoodGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }    
        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string query = "select * from food_management";

            DataTable dt = new DataTable();
            MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
            ada.Fill(dt);
            FoodGridView.DataSource = dt;
        }

        private void FoodGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            form1.add_food_button.Visible = false;
            form1.btn_reset.Visible = false;
            form1.btn_update.Show();
            form1.loadCathegory();
            form1.cathegory_box.SelectedItem = FoodGridView.CurrentRow.Cells[1].Value.ToString();
            form1.food_name.Text = FoodGridView.CurrentRow.Cells[2].Value.ToString();
            string ingre_available = FoodGridView.CurrentRow.Cells[3].Value.ToString();
            if (ingre_available == form1.ingredient_y.Text)
            {
                form1.ingredient_y.Checked = true;
            }
            else
            {
                form1.ingredient_n.Checked = true;
            }
            form1.ingredients_txt.Text = FoodGridView.CurrentRow.Cells[4].Value.ToString();
            string food_type = FoodGridView.CurrentRow.Cells[5].Value.ToString();

            if (food_type == form1.veg_select.Text)
            {
                form1.veg_select.Checked = true;

            }
            else
            {
                form1.nonveg_select.Checked = true;
            }
            decimal small = (decimal)FoodGridView.CurrentRow.Cells[6].Value;
            if (small != 0)
            {
                form1.small_size.Checked = true;
                form1.small_price.Visible = true;
                form1.price_of_small = small;
            }
            else
            {
                form1.small_size.Checked = false;
                form1.small_price.Visible = false;

            }
            decimal medium = (decimal)FoodGridView.CurrentRow.Cells[7].Value;
            if (medium != 0)
            {
                form1.medium_size.Checked = true;
                form1.medium_price.Visible = true;
                form1.price_of_medium = medium;
            }
            else
            {
                form1.medium_size.Checked = false;
                form1.medium_price.Visible = false;

            }
            decimal large = (decimal)FoodGridView.CurrentRow.Cells[8].Value;
            if (large != 0)
            {
                form1.large_size.Checked = true;
                form1.large_price.Visible = true;
                form1.price_of_large =large;
            }
            else
            {
                form1.large_size.Checked = false;
                form1.large_price.Visible = false;

            }
            form1.description_txt.Text = FoodGridView.CurrentRow.Cells[9].Value.ToString();
            form1.id_txt.Text = id;
            form1.ShowDialog();
        }

        private void food_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoodGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = FoodGridView.Rows[e.RowIndex];
                foodgrid_id = row.Cells[0].Value.ToString();
                id = FoodGridView.Rows[e.RowIndex].Cells["ID_Column"].Value.ToString();
            }
        }

        private void cathegory_box_SelectionChangeCommitted(object sender, EventArgs e)
        {

           
                string query = "select * from food_management WHERE cathegory = '" + cathegory_box.SelectedItem.ToString() + "'";

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = (MySqlDataAdapter)DbObject.ShowDataInGridView(query);
                ada.Fill(dt);
            FoodGridView.DataSource = dt;
            }

        private void FoodGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < FoodGridView.Rows.Count; i++)
            {
                if (IsOdd(i))
                {

                    FoodGridView.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }

            
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
 }

