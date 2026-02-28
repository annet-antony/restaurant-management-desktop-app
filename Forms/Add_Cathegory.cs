using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DbConnection;
namespace Restaurant_Project
{
    public partial class Add_Cathegory : Form
    {
        DB_Connection_class Dbobject = new DB_Connection_class();
        Validation_Class vObject = new Validation_Class();
        View_cathegory form = new View_cathegory();
        public string cathegory_id = "";
       

        public Add_Cathegory()
        {
            InitializeComponent();
        }

        private void btn_cathegory_add_Click(object sender, EventArgs e)
        {
            string type = type_selection();
            string size = size_selection();
            try
            {
                if (String.IsNullOrEmpty(txt_cathegory.Text))
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
                else
                {
                    string query = "INSERT INTO cathegory(name, size_available, type_available)VALUES('" + txt_cathegory.Text + "','" + size + "', '" + type + "')";

                    Dbobject.OpenConnection();
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
        private void reset()
        {
            txt_cathegory.Clear();
            size_y.Checked = true;
            size_n.Checked = false;
            type_y.Checked = true;
            type_n.Checked = false;
        }
        public string type_selection()
        {
            string type = null;
            if (type_y.Checked == true)
            {
                type = "Yes";
            }
            if (type_n.Checked == true)
            {
                type = "No";
            }
            return type;
        }
        public string size_selection()
        {
            string size = null;
            if (size_y.Checked == true)
            {
                size = "Yes";
            }
            if (size_n.Checked == true)
            {
                size = "No";
            }
            return size;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        private void Add_Cathegory_Load(object sender, EventArgs e)
        {
          
        }

        private void txt_cathegory_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }     
        private void btn_cathegory_update_Click(object sender, EventArgs e)
        {
            string type = type_selection();
            string size = size_selection();
            try
            {
                if (String.IsNullOrEmpty(txt_cathegory.Text))
                {
                    MessageBox.Show("Please Fill Mandotory Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                else
                {                   
                    Dbobject.OpenConnection();
                    string query = "UPDATE cathegory SET name ='" + txt_cathegory.Text+ "', size_available = '" + size + "', type_available= '" + type + "' WHERE cathegory_id = '" + cathegory_id + "'";
                    Dbobject.ExecuteQueries(query);
                    MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.loadData();
                    Dbobject.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_cathegory_TextChanged(object sender, EventArgs e)
        {

        }

        private void size_y_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
