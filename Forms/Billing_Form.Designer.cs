
namespace Restaurant_Project
{
    partial class Billing_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.head_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.main_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.row_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cathegory_box = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_billNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.receipt_box = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_receipt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bill_panel = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cus = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.head_panel.SuspendLayout();
            this.main_flow.SuspendLayout();
            this.row_panel.SuspendLayout();
            this.bill_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.Teal;
            this.head_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head_panel.Controls.Add(this.label1);
            this.head_panel.Location = new System.Drawing.Point(1, 3);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(1559, 85);
            this.head_panel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(293, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(496, 1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.label4.Size = new System.Drawing.Size(140, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(263, 1);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.label3.Size = new System.Drawing.Size(86, 56);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(-1, 1);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 105, 10);
            this.label2.Size = new System.Drawing.Size(267, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food Menu";
            // 
            // main_flow
            // 
            this.main_flow.AutoScroll = true;
            this.main_flow.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.main_flow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_flow.Controls.Add(this.button1);
            this.main_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.main_flow.Location = new System.Drawing.Point(9, 144);
            this.main_flow.Name = "main_flow";
            this.main_flow.Size = new System.Drawing.Size(833, 377);
            this.main_flow.TabIndex = 4;
            this.main_flow.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(345, 1);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 5, 0, 10);
            this.label6.Size = new System.Drawing.Size(155, 56);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unit Price";
            // 
            // row_panel
            // 
            this.row_panel.BackColor = System.Drawing.Color.DarkCyan;
            this.row_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row_panel.Controls.Add(this.label6);
            this.row_panel.Controls.Add(this.label7);
            this.row_panel.Controls.Add(this.label3);
            this.row_panel.Controls.Add(this.label2);
            this.row_panel.Controls.Add(this.label4);
            this.row_panel.Location = new System.Drawing.Point(9, 83);
            this.row_panel.Name = "row_panel";
            this.row_panel.Size = new System.Drawing.Size(833, 60);
            this.row_panel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(636, 1);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 5, 40, 10);
            this.label7.Size = new System.Drawing.Size(168, 56);
            this.label7.TabIndex = 12;
            this.label7.Text = "Amount";
            // 
            // cathegory_box
            // 
            this.cathegory_box.BackColor = System.Drawing.Color.MintCream;
            this.cathegory_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cathegory_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cathegory_box.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cathegory_box.FormattingEnabled = true;
            this.cathegory_box.ItemHeight = 29;
            this.cathegory_box.Location = new System.Drawing.Point(200, 19);
            this.cathegory_box.Name = "cathegory_box";
            this.cathegory_box.Size = new System.Drawing.Size(242, 37);
            this.cathegory_box.TabIndex = 1;
            this.cathegory_box.SelectionChangeCommitted += new System.EventHandler(this.cathegory_box_SelectionChangeCommitted);
            this.cathegory_box.Click += new System.EventHandler(this.cathegory_box_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_add.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(654, 536);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(188, 65);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "&FINISH";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_clear.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Location = new System.Drawing.Point(450, 536);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(196, 65);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "&CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_billNo
            // 
            this.txt_billNo.Location = new System.Drawing.Point(720, 25);
            this.txt_billNo.MaxLength = 10;
            this.txt_billNo.Name = "txt_billNo";
            this.txt_billNo.ReadOnly = true;
            this.txt_billNo.Size = new System.Drawing.Size(122, 31);
            this.txt_billNo.TabIndex = 3;
            this.txt_billNo.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MintCream;
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(590, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 40);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bill No  :";
            this.label9.Visible = false;
            // 
            // receipt_box
            // 
            this.receipt_box.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.receipt_box.Location = new System.Drawing.Point(861, 16);
            this.receipt_box.Name = "receipt_box";
            this.receipt_box.ReadOnly = true;
            this.receipt_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.receipt_box.Size = new System.Drawing.Size(456, 698);
            this.receipt_box.TabIndex = 13;
            this.receipt_box.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category    :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 855);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 15);
            this.panel1.TabIndex = 10;
            // 
            // btn_receipt
            // 
            this.btn_receipt.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_receipt.Enabled = false;
            this.btn_receipt.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_receipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_receipt.Location = new System.Drawing.Point(654, 686);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(188, 65);
            this.btn_receipt.TabIndex = 14;
            this.btn_receipt.Text = "&RECEIPT";
            this.btn_receipt.UseVisualStyleBackColor = false;
            this.btn_receipt.Click += new System.EventHandler(this.btn_receipt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MintCream;
            this.label10.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(9, 573);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 40);
            this.label10.TabIndex = 7;
            this.label10.Text = "Discount          :";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(230, 582);
            this.txt_discount.MaxLength = 10;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.ReadOnly = true;
            this.txt_discount.Size = new System.Drawing.Size(155, 31);
            this.txt_discount.TabIndex = 8;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(230, 533);
            this.txt_total.MaxLength = 10;
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(155, 31);
            this.txt_total.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MintCream;
            this.label11.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(10, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 40);
            this.label11.TabIndex = 9;
            this.label11.Text = "Total                 :";
            // 
            // bill_panel
            // 
            this.bill_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bill_panel.Controls.Add(this.btn_back);
            this.bill_panel.Controls.Add(this.label8);
            this.bill_panel.Controls.Add(this.txt_cus);
            this.bill_panel.Controls.Add(this.button2);
            this.bill_panel.Controls.Add(this.txt_balance);
            this.bill_panel.Controls.Add(this.label14);
            this.bill_panel.Controls.Add(this.txt_paid);
            this.bill_panel.Controls.Add(this.label13);
            this.bill_panel.Controls.Add(this.txt_pay);
            this.bill_panel.Controls.Add(this.label12);
            this.bill_panel.Controls.Add(this.row_panel);
            this.bill_panel.Controls.Add(this.btn_receipt);
            this.bill_panel.Controls.Add(this.label11);
            this.bill_panel.Controls.Add(this.main_flow);
            this.bill_panel.Controls.Add(this.receipt_box);
            this.bill_panel.Controls.Add(this.label10);
            this.bill_panel.Controls.Add(this.txt_total);
            this.bill_panel.Controls.Add(this.label9);
            this.bill_panel.Controls.Add(this.txt_discount);
            this.bill_panel.Controls.Add(this.txt_billNo);
            this.bill_panel.Controls.Add(this.label5);
            this.bill_panel.Controls.Add(this.cathegory_box);
            this.bill_panel.Controls.Add(this.btn_clear);
            this.bill_panel.Controls.Add(this.btn_add);
            this.bill_panel.Location = new System.Drawing.Point(1, 87);
            this.bill_panel.Name = "bill_panel";
            this.bill_panel.Size = new System.Drawing.Size(1554, 771);
            this.bill_panel.TabIndex = 15;
            this.bill_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bill_panel_Paint);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_back.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(1339, 573);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(188, 65);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "&BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(861, 718);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 40);
            this.label8.TabIndex = 22;
            this.label8.Text = "cus_id  :";
            this.label8.Visible = false;
            // 
            // txt_cus
            // 
            this.txt_cus.Location = new System.Drawing.Point(991, 724);
            this.txt_cus.MaxLength = 10;
            this.txt_cus.Name = "txt_cus";
            this.txt_cus.ReadOnly = true;
            this.txt_cus.Size = new System.Drawing.Size(122, 31);
            this.txt_cus.TabIndex = 23;
            this.txt_cus.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1339, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 65);
            this.button2.TabIndex = 21;
            this.button2.Text = "&PRINT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(230, 715);
            this.txt_balance.MaxLength = 10;
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.ReadOnly = true;
            this.txt_balance.Size = new System.Drawing.Size(155, 31);
            this.txt_balance.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.MintCream;
            this.label14.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(10, 709);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 40);
            this.label14.TabIndex = 19;
            this.label14.Text = "Balance            :";
            // 
            // txt_paid
            // 
            this.txt_paid.Location = new System.Drawing.Point(230, 671);
            this.txt_paid.MaxLength = 10;
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(155, 31);
            this.txt_paid.TabIndex = 18;
            this.txt_paid.TextChanged += new System.EventHandler(this.txt_paid_TextChanged);
            this.txt_paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paid_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.MintCream;
            this.label13.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(9, 662);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 40);
            this.label13.TabIndex = 17;
            this.label13.Text = "Paid Amount   :";
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(230, 628);
            this.txt_pay.MaxLength = 7;
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.ReadOnly = true;
            this.txt_pay.Size = new System.Drawing.Size(155, 31);
            this.txt_pay.TabIndex = 16;
            this.txt_pay.TextChanged += new System.EventHandler(this.txt_pay_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MintCream;
            this.label12.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(9, 619);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 35);
            this.label12.TabIndex = 15;
            this.label12.Text = "Amount To Pay   :";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // Billing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1560, 870);
            this.ControlBox = false;
            this.Controls.Add(this.bill_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.head_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing_Form";
            this.Load += new System.EventHandler(this.Billing_Form_Load);
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.main_flow.ResumeLayout(false);
            this.row_panel.ResumeLayout(false);
            this.row_panel.PerformLayout();
            this.bill_panel.ResumeLayout(false);
            this.bill_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.FlowLayoutPanel main_flow;
        private System.Windows.Forms.Panel row_panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cathegory_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_billNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox receipt_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_receipt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel bill_panel;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_discount;
        public System.Windows.Forms.TextBox txt_cus;
        public System.Windows.Forms.Button btn_back;
    }
}