using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DbConnection;
using MySql.Data.MySqlClient;

namespace Restaurant_Project
{
    public partial class Add_Food : Form
    {
        DB_Connection_class Dbobject = new DB_Connection_class();
        public decimal price_of_small = 0;
        public decimal price_of_medium = 0;
        public decimal price_of_large = 0;
        public string food_id = "";
        string ingredients = "NOT AVAILABLE";
        string description = "NOT AVAILABLE";
     

        Validation_Class vObject = new Validation_Class();

        public Add_Food()
        {
            InitializeComponent();
        }
        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Close();
           
        }

        private void Add_Food_Load(object sender, EventArgs e)
        {
            small_price.Text = price_of_small.ToString();
            medium_price.Text = price_of_medium.ToString();
            large_price.Text = price_of_large.ToString();
        }
        public string choice_selection()
        {
            string choice = null;

            if (ingredient_y.Checked)
            {
                choice = ingredient_y.Text;
                ingredients_txt.Visible = true;
            }
            else
            {
                choice = ingredient_n.Text;
                ingredients_txt.Visible = false;
            }
            return choice;
        }
        public string foodtype_selection()
        {
            string food_type = null;

            if (veg_select.Checked)
            {
                food_type = veg_select.Text;

            }
            if (nonveg_select.Checked)
            {
                food_type = nonveg_select.Text;
            }
            return food_type;
        }

        private void add_food_button_Click(object sender, EventArgs e)
        {
            string food_type = foodtype_selection();
            string choice = choice_selection();
           
            try
            {
                if (cathegory_box.SelectedIndex == -1 || food_name.Text == null || (ingredient_y.Checked == false && ingredient_n.Checked == false) || (veg_select.Checked == false && nonveg_select.Checked == false))
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               else if (ingredient_y.Checked == true && ingredients_txt.Text == null)
                {
                    MessageBox.Show("Please Add Ingredients!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
               else if ((small_size.Checked == true && small_price.Text == null) || (medium_size.Checked == true && medium_price.Text == null) || (large_size.Checked == true && large_price.Text == null))
                {
                    MessageBox.Show("Please Input the price!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    Dbobject.OpenConnection();
                    string query = "INSERT INTO food_management(cathegory, food_name, ingredient_available, ingredients, food_type, small, medium, large, description,added_by)VALUES('" + cathegory_box.SelectedItem + "','" + food_name.Text + "','" + choice + "','" + ingredients + "','" + food_type + "','" + price_of_small + "','" + price_of_medium + "','" + price_of_large + "','" + description + "','" + Properties.Settings.Default.username + "')";
                   
                    Dbobject.ExecuteQueries(query);
                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dbobject.CloseConnection();
                   
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void small_size_CheckedChanged(object sender, EventArgs e)
        {
            
            if (small_size.Checked == true)
            {
                if ((medium_price.Text == " " && medium_size.Checked) || (large_price.Text == " " && large_size.Checked))
                {
                    small_price.Visible = false;
                    price_of_small = 0;
                    price_lbl.Visible = true; ;
                }
                else
                {
                    price_lbl.Show();
                    small_price.Visible = true;
                    price_of_small = 0;
                }
                             
            }
           
            else
            {
                if ((medium_price.Text == " " && medium_size.Checked) || (large_price.Text == " " && large_size.Checked))
                {
                    small_price.Visible = false;
                    price_lbl.Show();
                    price_of_small = 0;
                }
                else
                {
                    small_price.Visible = false;
                    price_lbl.Hide();
                    price_of_small = 0;
                }
               
            }
           
        }        
        private void medium_size_CheckedChanged(object sender, EventArgs e)
        {
            if (medium_size.Checked == true)
            {
                price_lbl.Visible = true;
                medium_price.Visible = true;
                price_of_medium = 0;
            }
            else if ((small_price.Text == null && small_size.Checked == true) || (large_price.Text == null && large_size.Checked == true))
            {
                medium_price.Visible = false;
                price_lbl.Visible = true;
                price_of_medium = 0;
            }
            else
            {               
                   medium_price.Visible = false;
                    price_lbl.Visible = false;
                price_of_medium = 0;
            }

        }
        private void large_size_CheckedChanged(object sender, EventArgs e)
        {
            if (large_size.Checked)
            {
                price_lbl.Visible = true;
                large_price.Visible = true;
                price_of_large = 0;
            }
            else if ((medium_price.Text == null && medium_size.Checked == true) || (small_price.Text == null && small_size.Checked == true))
            {
                large_price.Visible = false;
                price_lbl.Visible = true;
                price_of_large = 0;
            }

            else
                {
                  large_price.Visible = false;
                  price_lbl.Visible = false;
                  price_of_large = 0;
            }
        }

        private void small_price_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((string)small_price.Text))
            {
                small_price.Text = 0.ToString();
            }
            else
            {
                price_lbl.Visible = false;
                price_of_small = decimal.Parse(small_price.Text);
            }
            
        }

        private void medium_price_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((string)medium_price.Text))
            {
                medium_price.Text = 0.ToString();
            }
            else
            {
                price_lbl.Visible = false;
                price_of_medium = decimal.Parse(medium_price.Text);
                
            }
           
        }

        private void large_price_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((string)large_price.Text))
            {
                large_price.Text = 0.ToString();
            }
            else
            {
                price_lbl.Visible = false;
                price_of_large = decimal.Parse(large_price.Text);
               

            }
           
        }

        private void ingredient_y_CheckedChanged(object sender, EventArgs e)
        {
            ingredients_txt.Visible = true;
        }

        private void ingredient_n_CheckedChanged(object sender, EventArgs e)
        {
            ingredients_txt.Visible = false;
            ingredients_txt.Text = ingredients;
        }

        private void ingredients_txt_TextChanged(object sender, EventArgs e)
        {
            ingredients = ingredients_txt.Text;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (cathegory_box.SelectedItem == null || food_name.Text == null  || (ingredient_y.Checked == false && ingredient_n.Checked == false) || (small_size.Checked == false && medium_size.Checked == false && large_size.Checked == false ) || 
                     (veg_select.Checked == false && nonveg_select.Checked == false))
                {
                    MessageBox.Show("Please Fill Empty Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                }
                if (ingredient_y.Checked == true && ingredients_txt.Text == null)
                {
                    MessageBox.Show("Please Add Ingredients!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                if ((small_size.Checked == true && small_price.Text == null) || (medium_size.Checked == true && medium_price.Text == null) || (large_size.Checked == true && large_price.Text == null))
                {
                    MessageBox.Show("Please Input the price!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                else
                {

                    string food_type = foodtype_selection();
                    string choice = choice_selection();
                    Dbobject.OpenConnection();
                    string query = "UPDATE food_management SET cathegory ='" + cathegory_box.SelectedItem.ToString() + "', food_name = '" + food_name.Text + "', ingredient_available= '" + choice + "', ingredients= '" + ingredients_txt.Text + "', food_type= '" + food_type + "', small= '" + price_of_small + "', medium= '" + price_of_medium + "', large=  '" + price_of_large + "', description= '" + description + "', added_by = '" + Properties.Settings.Default.username + "'  WHERE food_id = '" + Convert.ToInt32(id_txt.Text) + "' ";
                    Dbobject.ExecuteQueries(query);
                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    Dbobject.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
            lbl_error.Visible = false;
        }
        private void reset()
        {
            cathegory_box.SelectedIndex = -1;
            food_name.Clear();
            lbl_error.Visible = false;

            ingredient_y.Checked = false;
            ingredient_n.Checked = false;
            ingredients_txt.Clear();
            veg_select.Checked = false;
            nonveg_select.Checked = false;
            small_size.Checked = false;
            small_price.Visible = false;
            medium_size.Checked = false;
            medium_price.Visible = false;
            large_size.Checked = false;
            large_price.Visible = false;
            price_lbl.Visible = false;
            if(description_txt.Text != null)
            {
                description_txt.Clear();
            }
           
        }

        private void btn_cathegory_add_Click(object sender, EventArgs e)
        {
           
            Add_Cathegory form = new Add_Cathegory();
            form.btn_cathegory_update.Visible = false;
            form.ShowDialog();
        }
        public void loadCathegory()
        {
            string query = "select name FROM cathegory";
            Dbobject.OpenConnection();
            MySqlDataReader drd = Dbobject.DataReader(query);
            while (drd.Read())
            {
                cathegory_box.Items.Add(drd["name"].ToString());
            }
            Dbobject.CloseConnection();
        }

        private void cathegory_box_Click(object sender, EventArgs e)
        {
            cathegory_box.Items.Clear();
            loadCathegory();
        }

        private void cathegory_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cathegory_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            noSizePrice();
        }
        public  void noSizePrice()
        {
            string size = null;
            string type = null;
            string query = "select size_available, type_available FROM cathegory WHERE name = '" + cathegory_box.SelectedItem.ToString() + "'";
            Dbobject.OpenConnection();
            MySqlDataReader drd = Dbobject.DataReader(query);
            while (drd.Read())
            {
                size = drd["size_available"].ToString();
                type = drd["type_available"].ToString();
            }
            if (size == "No")
            {
                size_grp.Visible = false;
                txt_price.Visible = true;
                lbl_main_price.Text = "Price";

            }
            if (size == "Yes")
            {
                size_grp.Visible = true;
                txt_price.Visible = false;
                

            }
            if (type == "No")
            {
                type_grp.Visible = false;
            }
            if (type == "Yes")
            {
                type_grp.Visible = true;
            }
        }

        private void food_name_TextChanged(object sender, EventArgs e)
        {
            if(food_name.Text == null)
            {
                lbl_error.Visible = false;

            }
            lbl_error.Visible = false;

            bool verify = vObject.validattion(food_name.Text);

            if (verify == false)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "! Invalid input";
                food_name.Clear();
            }
            else
            {
                lbl_error.Visible = false;
            }
        }

        private void small_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
          
        }

        private void medium_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
          
        }

        private void large_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
          
        }

        private void description_txt_TextChanged(object sender, EventArgs e)
        {
            description = description_txt.Text ;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((string)txt_price.Text))
            {
                txt_price.Text = 0.ToString();
            }
            else
            {
                price_lbl.Visible = false;
                price_of_small = decimal.Parse(txt_price.Text);


            }
        }
    }
}
