using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class Exit_form : Form
    {
        public Exit_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard_form d_form = new DashBoard_form();
            d_form.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
         
            DashBoard_form d_form = new DashBoard_form();
            d_form.Dispose();
            Today_Discount form_today = new Today_Discount();
            form_today.count = 0;
            Login_form form = new Login_form();
            form.ShowDialog();
            
        }
    }
}
