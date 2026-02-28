using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DbConnection;
using MySql.Data.MySqlClient;

namespace Restaurant_Project
{
    public partial class Billing_Form : Form
    {
        DashBoard_form d_form = new DashBoard_form();
        DB_Connection_class DbObject = new DB_Connection_class();
        int i = 0;
        decimal small;
        decimal medium;
        decimal large;
        decimal total = 0;
        public decimal discount = 0;
        decimal pay = 0;
        decimal balance = 0;
        public string e_name = " ";
        private static ArrayList List_String_ID = new ArrayList();
       
        public string cus_name = "N/A";
        public string mobile = "N/A";
        public string cus_id = "NBC/";
        string dateValue;
        public Billing_Form()
        {
            InitializeComponent();
        }
        private void Billing_Form_Load(object sender, EventArgs e)
        {
            main_flow.AutoScroll = true;
            main_flow.WrapContents = false;
            txt_total.Text = total.ToString();
           
            txt_pay.Text = pay.ToString();
            txt_balance.Text = balance.ToString();
            e_name = d_form.getEmployeeName();
            txt_discount.Text = discount.ToString();


            dateValue = DateTime.Now.ToString();



        }

        private void cathegory_box_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cathegory_box.Enabled = false;
            i++;
            FlowLayoutPanel flowpanels = new FlowLayoutPanel();
            
            flowpanels.Size = new Size(1159, 40);
            flowpanels.Name = "panel" + i.ToString();
           
            flowpanels.FlowDirection = FlowDirection.LeftToRight;
            flowpanels.BorderStyle = BorderStyle.FixedSingle;
            flowpanels.HorizontalScroll.Visible = false;
            main_flow.Controls.Add(flowpanels);
         
            ComboBox menubox = new ComboBox();
            menubox.Name = "menu_box"+ i.ToString();
            menubox.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboBox sizebox = new ComboBox();
            sizebox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizebox.Name = "size_box" + i.ToString();

            Label price_lbl = new Label();
            price_lbl.Name = "price"+i.ToString();

            NumericUpDown quantity = new NumericUpDown();
            quantity.Name = "quantity"+i.ToString();
            quantity.Value = 1;
            quantity.Maximum = 100;

            Label amount = new Label();
            amount.Name = "amount"+i.ToString();

            Button rem_bt = new Button();
            rem_bt.Text = "X";
            rem_bt.Size = new Size(46, 46);
            rem_bt.Name = "remove"+i.ToString();


            flowpanels.FlowDirection = FlowDirection.LeftToRight;
            flowpanels.WrapContents = false;
            menubox.Size = new Size(255, 56);
            sizebox.Size = new Size(91, 56);
            price_lbl.Size = new Size(130, 56);
            quantity.Size = new Size(130, 56);
            amount.Size = new Size(130, 56);

            flowpanels.Controls.Add(menubox);
            flowpanels.Controls.Add(sizebox);
            flowpanels.Controls.Add(price_lbl);
            flowpanels.Controls.Add(quantity);
            flowpanels.Controls.Add(amount);
            flowpanels.Controls.Add(rem_bt);

            string str_menu = "select DISTINCT food_name from food_management where cathegory=  '" + cathegory_box.SelectedItem.ToString() + "'";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(str_menu);
            while (drd.Read())
            {
                menubox.Items.Add(drd["food_name"].ToString());
            }
            menubox.SelectedIndexChanged += name_IndexChanged;
            sizebox.SelectedIndexChanged += size_IndexChanged;
            quantity.ValueChanged += quantity_ValueChanged;
            rem_bt.Click += remove_button_Click;
            amount.TextChanged += amount_TextChanged;
         
        }
        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown n1 = this.Controls.Find("quantity"+i, true).First() as NumericUpDown;
            Label lb2 = this.Controls.Find("price"+i, true).First() as Label;
            Label lb3 = this.Controls.Find("amount"+i, true).First() as Label;

            decimal l2_val = decimal.Parse(lb2.Text);
            decimal l3_val = (decimal)(l2_val * (n1.Value));
            lb3.Text =  l3_val.ToString();
            
        }
        private void name_IndexChanged(object sender, EventArgs e)
        {
            
           ComboBox menu = this.Controls.Find("menu_box"+i,true).First() as ComboBox;
            ComboBox size = this.Controls.Find("size_box" + i, true).First() as ComboBox;
            Label price_lb = this.Controls.Find("price" + i, true).First() as Label;
            Label amount_lb = this.Controls.Find("amount" + i, true).First() as Label;
            price_lb.Text = "";
            size.Items.Clear();
            amount_lb.Text = "";

            DbObject.OpenConnection();
            string str_small = "select * from food_management where food_name ='" + menu.SelectedItem.ToString() + "'";
            MySqlDataReader drd = DbObject.DataReader(str_small);
            if (drd.Read())
            {
                small = ((decimal)drd["small"]);
                if (small != 0) 
                {
                    size.Items.Add("S");
                }

                medium = ((decimal)drd["medium"]);
                if (medium != 0)
                {
                    size.Items.Add("M");
                }
                large = ((decimal)drd["large"]);
                if (large != 0)
                {
                    size.Items.Add("L");
                }
                if (large == 0 && medium == 0 && small == 0)
                {
                    size.Items.Add("N/A");
                }
            }
           
        }
        private void size_IndexChanged(object sender, EventArgs e)
        {
            ComboBox size_one = this.Controls.Find("size_box" + i, true).First() as ComboBox;
            Label price_lb = this.Controls.Find("price"+i, true).First() as Label;
            Label amount_lb = this.Controls.Find("amount" + i, true).First() as Label;
            if (size_one.SelectedItem.ToString() == "S")
            {
                price_lb.Text = small.ToString();
            }
            if (size_one.SelectedItem.ToString() == "M")
            {
                price_lb.Text =  medium.ToString();
            }
            if (size_one.SelectedItem.ToString() == "L")
            {
                price_lb.Text = large.ToString();
            }
            if (size_one.SelectedItem.ToString() == "N/A")
            {
                price_lb.Text = small.ToString();
            }
            amount_lb.Text = price_lb.Text;
        }
        private void remove_button_Click(object sender, EventArgs e)
        {
            try
            {              
                var button = sender as Button;
                string bt_name = button.Name;

                char b = bt_name.Last();
                string p_name = "panel" + b.ToString();
                string amount_lbl= "amount" + b.ToString();
                string menu_box = "menu_box" + b.ToString();
                string size_box = "size_box" + b.ToString();
                string price_lbl = "price" + b.ToString();
                string quantity = "quantity" + b.ToString();
                FlowLayoutPanel fp = this.Controls.Find(p_name, true).FirstOrDefault() as FlowLayoutPanel;
                Label a_l = this.Controls.Find(amount_lbl, true).FirstOrDefault() as Label;
                Label u_l = this.Controls.Find(price_lbl, true).FirstOrDefault() as Label;
                ComboBox m_box = this.Controls.Find(menu_box, true).FirstOrDefault() as ComboBox;
                ComboBox s_box = this.Controls.Find(size_box, true).FirstOrDefault() as ComboBox;
                NumericUpDown n_box = this.Controls.Find(quantity, true).FirstOrDefault() as NumericUpDown;

                fp.Controls.Remove(a_l);
                a_l.Dispose();
                fp.Controls.Remove(u_l);
                u_l.Dispose();
                fp.Controls.Remove(m_box);
                m_box.Dispose();
                fp.Controls.Remove(s_box);
                s_box.Dispose();
                fp.Controls.Remove(n_box);
                n_box.Dispose();
                fp.Dispose();
                i--;
               
                cathegory_box.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Clear All? ", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                clear();
                cathegory_box.Enabled = true;
            }
          
        }
        private void clear()
        {
            main_flow.Controls.Clear();
            total = 0;
            discount = 0;
            pay = 0;
            balance = 0;
            txt_total.Text = total.ToString();
            txt_discount.Text = total.ToString();
            txt_pay.Text = pay.ToString();
            txt_balance.Text = balance.ToString();
            txt_paid.Clear();
        }
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if(cathegory_box.SelectedIndex == -1)
            {
                cathegory_box.SelectedItem = "RiceBowls";
            }
            if (i == 0)
            {
                MessageBox.Show("Please add menu before finish", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int j = 1; j <= i; j++)
                {
                    string amount = "amount" + j.ToString();
                    string menu = "menu_box" + j.ToString();
                    string size = "size_box" + j.ToString();
                    string quantity = "quantity" + j.ToString();
                    ComboBox menu_box = this.Controls.Find(menu, true).FirstOrDefault() as ComboBox;
                    ComboBox size_box = this.Controls.Find(size, true).FirstOrDefault() as ComboBox;
                    Label amount_lbl = this.Controls.Find(amount, true).FirstOrDefault() as Label;
                    NumericUpDown n1 = this.Controls.Find(quantity, true).FirstOrDefault() as NumericUpDown;
                    try
                    {
                        if (String.IsNullOrEmpty(amount_lbl.Text) || cathegory_box.SelectedIndex == -1)
                        {
                         
                            amount_lbl.Text = 0.ToString();
                        }
                        else
                        {
                            total += decimal.Parse(amount_lbl.Text);
                        }

                       
                           
                            if (total == 0 || amount_lbl.Text == null)
                            {
                                MessageBox.Show("Please add menu before finish", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    bool discountexists = false;
                    if (cathegory_box.SelectedIndex == -1)
                    {
                        discountexists = false;
                    }
                    else if (size_box.SelectedIndex == -1 || menu_box.SelectedIndex == -1)
                    {
                        discountexists = false;
                    }
                    else
                    {
                        discountexists = DbObject.checkExistence("select count(*) FROM discount WHERE category = '" + cathegory_box.SelectedItem.ToString() + "' AND food_name = '" + menu_box.SelectedItem.ToString() + "' AND selection = '" + size_box.SelectedItem.ToString() + "' AND status LIKE 'Avail%' ");
                        if (discountexists == true)
                        {
                            string query = "SELECT deduct_price FROM discount WHERE category = '" + cathegory_box.SelectedItem.ToString() + "' AND food_name = '" + menu_box.SelectedItem.ToString() + "' AND selection = '" + size_box.SelectedItem.ToString() + "' AND status LIKE 'Avail%' ";
                            decimal dis = 0;
                            DbObject.OpenConnection();
                            MySqlDataReader drd = DbObject.DataReader(query);
                            while (drd.Read())
                            {
                                dis = ((decimal)(drd["deduct_price"]));
                            }
                            DbObject.CloseConnection();
                            discount = discount + dis * ((decimal)n1.Value);
                        }

                    }



                }
                txt_total.Text = total.ToString();

                txt_discount.Text = discount.ToString();
                txt_pay.Text = (total - discount).ToString();
              
            }
          

        }
        private void cathegory_box_Click(object sender, EventArgs e)
        {
            cathegory_box.Items.Clear();            
            string query = "select name FROM cathegory";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(query);
            while (drd.Read())
            {
                cathegory_box.Items.Add(drd["name"].ToString());
            }
            DbObject.CloseConnection();
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            getBillNo();
            
            getCustomer_ID();
            if (total == 0 || txt_paid.Text == 0.ToString() || i == 0)
            {
                MessageBox.Show("Please complete fields before finish", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Billing? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    receipt_box.AppendText("\t\t" + "TASTE ELITE- JAFFNA" + Environment.NewLine);
                    receipt_box.AppendText("\t\t" + "Restaurant Invoice" + Environment.NewLine);
                    receipt_box.AppendText("--------------------------------------------------" + Environment.NewLine);
                    receipt_box.AppendText("Bill No\t\t: " + txt_billNo.Text + Environment.NewLine);
                    receipt_box.AppendText("Order Date\t: " + DateTime.Today.ToShortDateString() + Environment.NewLine);
                    receipt_box.AppendText("Order Time\t: " + DateTime.Now.ToShortTimeString() + Environment.NewLine);
                    receipt_box.AppendText("Customer\t: " + cus_name + Environment.NewLine);
                    receipt_box.AppendText("Mobile No\t: " + mobile + Environment.NewLine);
                    receipt_box.AppendText("--------------------------------------------------" + Environment.NewLine);
                    receipt_box.AppendText("                " + Environment.NewLine);
                    receipt_box.AppendText("Description\t\t Qty\t U_Price\t Amount   " + Environment.NewLine);
                    receipt_box.AppendText("--------------------------------------------------" + Environment.NewLine);



                    DbObject.OpenConnection();
                    for (int j = 1; j <= i; j++)
                    {
                        string menu = "menu_box" + j.ToString();
                        string size = "size_box" + j.ToString();
                        string quantity = "quantity" + j.ToString();
                        string price = "price" + j.ToString();
                        string amount = "amount" + j.ToString();

                        ComboBox menu_box = this.Controls.Find(menu, true).First() as ComboBox;
                        ComboBox size_box = this.Controls.Find(size, true).First() as ComboBox;
                        NumericUpDown n_box = this.Controls.Find(quantity, true).First() as NumericUpDown;
                        Label price_lbl = this.Controls.Find(price, true).First() as Label;
                        Label amount_lbl = this.Controls.Find(amount, true).First() as Label;

                        
                       DbObject.ExecuteQueries("INSERT INTO billing(bill_id, food_name, size, quantity, unit_price, amount) VALUES('" + txt_billNo.Text + "', '" + menu_box.SelectedItem.ToString() + "', '" + size_box.SelectedItem.ToString() + "','" +(int)n_box.Value + "','" + decimal.Parse(price_lbl.Text) + "','" + decimal.Parse(amount_lbl.Text) + "')  ");
                      
                        receipt_box.AppendText(size_box.SelectedItem.ToString() + "_" + menu_box.SelectedItem.ToString() + "\t" + n_box.Value.ToString() + "\t" + price_lbl.Text + "     " + amount_lbl.Text + "\t     " + Environment.NewLine);
                        
                       

                    }
                    receipt_box.AppendText("" + Environment.NewLine);
                    receipt_box.AppendText("" + Environment.NewLine);
                    receipt_box.AppendText("Total Charge\t: Rs." + txt_total.Text + Environment.NewLine);
                    receipt_box.AppendText("Discount\t\t: Rs." + txt_discount.Text + Environment.NewLine);
                    receipt_box.AppendText("AmountTo Pay : Rs." + txt_pay.Text + Environment.NewLine);
                    receipt_box.AppendText("Paid Amount\t: Rs." + txt_paid.Text + Environment.NewLine);
                    receipt_box.AppendText("Balance\t\t: Rs." + txt_balance.Text + Environment.NewLine);
                    receipt_box.AppendText("" + Environment.NewLine);
                    receipt_box.AppendText("" + Environment.NewLine);

                    receipt_box.AppendText("--------------------------------------------------" + Environment.NewLine);
                    receipt_box.AppendText("Entered By\t: " + Properties.Settings.Default.username + Environment.NewLine);
                    receipt_box.AppendText("\t\t" + "THANK YOU......COME AGAIN" + Environment.NewLine);

                    MessageBox.Show("Added Sucessfully", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    DbObject.ExecuteQueries("INSERT INTO invoices VALUES('" + txt_billNo.Text + "', '" + txt_cus.Text + "', '" + i + "','" + decimal.Parse(txt_total.Text) + "','" + decimal.Parse(txt_discount.Text) + "','" + decimal.Parse(txt_pay.Text) + "','" + decimal.Parse(txt_paid.Text) + "','" + decimal.Parse(txt_balance.Text) + "','" + Properties.Settings.Default.username + "','" + DateTime.Today.Date.ToString("MM/dd/yyyy") + "','" + DateTime.Now.TimeOfDay + "')  ");
                    clear();
                    DbObject.CloseConnection();
                    i = 0;
                }
            }
           
        }

        private void txt_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 13) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                decimal paid = decimal.Parse(txt_paid.Text);
               
                pay = decimal.Parse(txt_pay.Text);
                if (pay <= paid)
                {
                    txt_paid.Text = paid.ToString("#,#.00");
                    balance = paid - pay;
                    txt_balance.Text = balance.ToString();
                    btn_receipt.Enabled = true;
                }
                else if(total == 0)
                {
                    MessageBox.Show("Please Add the menu first", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_receipt.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Amount is not enough", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_paid.Clear();
                    txt_balance.Text = 0.ToString();
                    btn_receipt.Enabled = false;
                }

            }
                
        }
        private void getBillNo()
        {
           
            var NumberList = new List<int>();
            string qry = "SELECT bill_id FROM invoices ";
            DbObject.OpenConnection();
            MySqlDataReader drd = DbObject.DataReader(qry);
            while (drd.Read())
            {
                List_String_ID.Add(drd["bill_id"].ToString());
           
            }
            DbObject.CloseConnection();
            for (int i = 0; i < List_String_ID.Count; i++)
            {
                NumberList.Add(Convert.ToInt32(List_String_ID[i].ToString().Substring(2, (List_String_ID[i].ToString().Length - 2))));
            }
            int max_no = NumberList.Max();


            max_no++;
            txt_billNo.Text = "B/" + max_no;
            List_String_ID.Clear();
        }

        private void bill_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void amount_TextChanged(object sender, EventArgs e)
        {
            cathegory_box.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPage();
            receipt_box.Clear();
        }
        private void printPage()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(receipt_box.Text);
                printDialog.Document = documentToPrint;
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                documentToPrint.Print();
            }
        }
        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(receipt_box.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.receipt_box.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {

        }
        private void getCustomer_ID()
        {
            List_String_ID.Clear();
            if (String.IsNullOrEmpty((string)txt_cus.Text))
            {
                
                var NumberList = new List<int>();
                string qry = "SELECT cus_id FROM invoices WHERE cus_id LIKE 'NBC/%' ";
                DbObject.OpenConnection();
                MySqlDataReader drd = DbObject.DataReader(qry);
                while (drd.Read())
                {
                    List_String_ID.Add(drd["cus_id"].ToString());

                }
                DbObject.CloseConnection();
                for (int i = 0; i < List_String_ID.Count; i++)
                {
                    NumberList.Add(Convert.ToInt32(List_String_ID[i].ToString().Substring(4, (List_String_ID[i].ToString().Length - 4))));
                }
                int max_no = NumberList.Max();
                max_no++;
                txt_cus.Text = "NBC/" + max_no;
            }
            else
            {
                txt_cus.Text = txt_cus.Text;
            }
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pay_TextChanged(object sender, EventArgs e)
        {
            txt_paid.Clear();
            txt_balance.Clear();

        }
    }

}
