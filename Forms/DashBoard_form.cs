using System;
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
    public partial class DashBoard_form : Form
    {
     
        public string role = null;
        public string id = null;
        DB_Connection_class DbObject = new DB_Connection_class();
        public DashBoard_form()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_menu.Text;
            view_food form1 = new view_food();
            form1.TopLevel = false;
            form1.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
            form1.Show();

        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_reservation.Text;
            View_table_reservation form6 = new View_table_reservation();
            form6.TopLevel = false;
            form6.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form6);
            form6.Dock = DockStyle.Fill;
            form6.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_order.Text;
            Billing_Form form2 = new Billing_Form();
            form2.TopLevel = false;
            form2.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form2);
            form2.Dock = DockStyle.Fill;
            form2.Show();
        }
        private void delivery_order_Click(object sender, EventArgs e)
        {
            lbl_head.Text = delivery_order.Text;
            Online_Order form3 = new Online_Order();
            form3.TopLevel = false;
            form3.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form3);
            form3.Dock = DockStyle.Fill;
            form3.Show();
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_table.Text;
            View_Table form4 = new View_Table();
            form4.TopLevel = false;
            form4.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form4);
            form4.Dock = DockStyle.Fill;
            form4.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exit_form form = new Exit_form();
            form.ShowDialog();
        


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_form_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Today.ToShortDateString();
            lbl_name.Text = Properties.Settings.Default.username;
            lbl_role.Text = role;
            getEmployeeName();
            if (lbl_role.Text == "User")
            {
                btn_table.Visible = false;
                table_panel.Visible = false;
                btn_Stock.Visible = false;
                stock_panel.Visible = false;
                btn_employee.Visible = false;
                employee_panel.Visible = false;
                btn_supplier.Visible = false;
                supplier_panel.Visible = false;
                btn_invoice.Visible = false;
                invoice_panel.Visible = false;
                discount_panel.Visible = false;
                btn_discount.Visible = false;
            }
            if (lbl_role.Text == "Inventory Manager")
            {
                btn_menu.Visible = false;
                menu_panel.Visible = false;
                btn_order.Visible = false;
                order_panel.Visible = false;
                btn_delivery.Visible = false;
                delivery_panel.Visible = false;
                btn_reservation.Visible = false;
                reservation_panel.Visible = false;
                btn_employee.Visible = false;
                employee_panel.Visible = false;
                btn_supplier.Visible = false;
                supplier_panel.Visible = false;
                btn_invoice.Visible = false;
                invoice_panel.Visible = false;
                discount_panel.Visible = false;
                btn_discount.Visible = false;
                online_panel.Visible = false;
                delivery_order.Visible = false;
            }
            DbObject.OpenConnection();
            string qry1 = "SELECT COUNT(booking_id) FROM booking";
            lbl_bookings.Text = DbObject.CountData(qry1).ToString();
            string qry2 = "SELECT COUNT(id) FROM billing";
            lbl_orders.Text = DbObject.CountData(qry2).ToString();
            string qry3 = "SELECT COUNT(measurement) FROM wastage WHERE measurement LIKE 'Small%'";
            int q1 = DbObject.CountData(qry3);
            string qry4 = "SELECT COUNT(measurement) FROM wastage WHERE measurement LIKE 'Medium%'";
            int q2 = DbObject.CountData(qry4);
            string qry5 = "SELECT COUNT(measurement) FROM wastage WHERE measurement LIKE 'Large%'";
            int q3 = DbObject.CountData(qry5);
            int total = q1 * 1 + q2 * 2 + q3 * 3;
            lbl_wastages.Text = total.ToString() + " Kg ";
            string query = " SELECT COUNT(cus_id) FROM invoices WHERE cus_id LIKE 'BC%'";
            string qry = " SELECT COUNT(cus_id) FROM invoices WHERE cus_id LIKE 'NBC%'";
           
            int booking = DbObject.CountData(query);
            int non_booking = DbObject.CountData(qry);
            lbl_book.Text = booking.ToString();
            lbl_non_book.Text = non_booking.ToString();
            lbl_total_customer.Text = (booking + non_booking).ToString();

            string emp_qry = "SELECT COUNT(e_id) FROM employee";
            string manager_qry = "SELECT COUNT(e_id) FROM employee WHERE role LIKE 'Management'";
            int tot_emp = DbObject.CountData(emp_qry);
            lbl_total_staff.Text = tot_emp.ToString();
            int manager_emp = DbObject.CountData(manager_qry);
            lbl_managers.Text = manager_emp.ToString();

            string available_stock_qry = "SELECT COUNT(code) FROM stock WHERE Status LIKE 'Available'";
            string emergency_stock_qry = "SELECT COUNT(code) FROM stock WHERE Status LIKE 'Emerge%'";
            string total_stock_qry = "SELECT COUNT(code) FROM stock";

            int avilable = DbObject.CountData(available_stock_qry);
            lbl_available_stock.Text = avilable.ToString();
            int emergency = DbObject.CountData(emergency_stock_qry);
            lbl_emergency_stock.Text = emergency.ToString();
            int total_stock = DbObject.CountData(total_stock_qry);
            lbl_total_stock.Text = total_stock.ToString();
            DbObject.CloseConnection();
           


            Today_Discount form_today = new Today_Discount();
            form_today.load_Today_discount();
            if (form_today.count !=0)
            {
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.BalloonTipText = "You have " + form_today.count + " Discounts today";
                notifyIcon1.ShowBalloonTip(1000);
                notifyIcon1.BalloonTipTitle = "Available";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_tim.Text = DateTime.Now.ToShortTimeString();
        }

        private void people_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void people_box_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            View_Discount form7 = new View_Discount();
            form7.TopLevel = false;
            form7.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form7);
            form7.Dock = DockStyle.Fill;
            form7.Show();
        }

        private void btn_wastage_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_wastage.Text;
            view_wastage form5 = new view_wastage();
            form5.TopLevel = false;
            form5.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form5);
            form5.Dock = DockStyle.Fill;
            form5.Show();
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_invoice.Text;
            View_Bill form8 = new View_Bill();
            form8.TopLevel = false;
            form8.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form8);
            form8.Dock = DockStyle.Fill;
            form8.Show();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_Stock.Text;
            View_Stock form9 = new View_Stock();
            form9.TopLevel = false;
            form9.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form9);
            form9.Dock = DockStyle.Fill;
            form9.Show();
        }



        private void btn_employee_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_employee.Text;
            View_Employee form10 = new View_Employee();
            form10.TopLevel = false;
            form10.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form10);
            form10.Dock = DockStyle.Fill;
            form10.Show();

        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            lbl_head.Text = btn_supplier.Text;
            View_Suppliers form11 = new View_Suppliers();
            form11.TopLevel = false;
            form11.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form11);
            form11.Dock = DockStyle.Fill;
            form11.Show();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            View_cathegory form1 = new View_cathegory();
            form1.TopLevel = false;
            form1.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            
        }

        
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void winChartViewer1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            lbl_head.Text = "Home";


            this.main_panel.Controls.Clear();


            this.main_panel.Controls.Add(this.dash_board_panel);



        }

        private void btn_myprofile_Click(object sender, EventArgs e)
        {
            lbl_head.Text = "My Profile";


            this.main_panel.Controls.Clear();
            Add_Employee form = new Add_Employee();

            string query = "select * FROM employee WHERE e_id = '"+ id +"'";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(query);
            while (drd.Read())
            {
                form.txt_ID.Text = drd["e_id"].ToString();
                form.fname_txt.Text = drd["fname"].ToString();
                form.lname_txt.Text = drd["lname"].ToString();
                form.nic_txt.Text = drd["nic_no"].ToString();
                string gender =   drd["gender"].ToString();
                if(gender == form.radio_male.Text)
                {
                    form.radio_male.Checked = true;
                }
                else
                {
                    form.female_select.Checked = true;
                }
                form.age_txt.Text = drd["age"].ToString();
                //form.dateTimePicker1.Text = drd["date_join"].ToString();
                form.street_txt.Text = drd["s_name"].ToString();
                form.town_txt.Text = drd["t_name"].ToString();
                form.district_box.SelectedItem = drd["district"].ToString();
                form.email_txt.Text = drd["email"].ToString();
                form.mobile_txt.Text = drd["mobile"].ToString();
                form.position_box.SelectedItem = drd["position"].ToString();
                form.user_txt.Text = drd["user_name"].ToString();
                form.password_txt.Text = drd["password"].ToString();
                form.roleBox.SelectedItem = drd["role"].ToString();
              

            }
            DbObject.CloseConnection();

            this.main_panel.Controls.Add(form.main_panel);
            form.main_panel.Anchor = AnchorStyles.Top;
            form.main_panel.Anchor = AnchorStyles.Left;
            form.main_panel.Anchor = AnchorStyles.Right;
            form.main_panel.Anchor = AnchorStyles.Bottom;
            form.main_panel.Dock = DockStyle.Fill;
            form.btn_update.Visible = true;
            form.register_button.Visible = false;
            form.back_btn.Visible = false;
            form.main_panel.AutoScroll = true;
            form.position_box.Enabled = false;
            form.system_userbox.Visible = false;
            form.user_grp.Visible = true;
            form.txt_ID.Visible = false;
            form.fname_txt.ReadOnly = true;
            form.lname_txt.ReadOnly = true;
            form.nic_txt.ReadOnly = true;
            form.age_txt.ReadOnly = true;
            form.street_txt.ReadOnly = true;
            form.mobile_txt.ReadOnly = true;
            form.town_txt.ReadOnly = true;
            form.email_txt.ReadOnly = true;
            form.age_txt.ReadOnly = true;
            form.radio_male.Enabled = false;
            form.female_select.Enabled = false;
            form.district_box.Enabled = false;
            form.email_txt.ReadOnly = false;
            form.dateTimePicker1.Enabled = false;
            form.dateTimePicker1.Enabled = false;
            form.system_userbox.Checked = true;
            form.system_userbox.Enabled = false;
            form.txt_code.Visible = false;
            form.reset_button.Visible = false;
            form.btn_update.Visible = false;
            form.lbl_code.Visible = false;
            form.lbl_confirm.Visible = false;
            form.btn_change.Visible = true;
            form.password_txt.Enabled = false;
            form.user_txt.Enabled = false;
            form.btn_change.Visible = true;
            form.confirm_txt.Visible = false;
        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            View_cathegory form1 = new View_cathegory();
            form1.TopLevel = false;
            form1.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }
        public string getEmployeeName()
        {                
            return this.lbl_name.Text;
            
        }
        public string getDate()
        {
            return this.lbl_date.Text;
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            Email_Form email = new Email_Form();
            email.ShowDialog();
        }

        private void btn_discount_Click_1(object sender, EventArgs e)
        {
            lbl_head.Text = btn_discount.Text;
            View_Discount form9 = new View_Discount();
            form9.TopLevel = false;
            form9.TopMost = true;
            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(form9);
            form9.Dock = DockStyle.Fill;
            form9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Today_Discount today = new Today_Discount();
            today.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dash_board_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lbl_expired_stock_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
