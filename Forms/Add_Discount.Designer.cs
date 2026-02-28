
namespace Restaurant_Project
{
    partial class Add_Discount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_food_id = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.end_calender = new System.Windows.Forms.MonthCalendar();
            this.start_calender = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.amount_box = new System.Windows.Forms.GroupBox();
            this.txt_current = new System.Windows.Forms.TextBox();
            this.current_lbl = new System.Windows.Forms.Label();
            this.txt_deducted = new System.Windows.Forms.TextBox();
            this.deduct_lbl = new System.Windows.Forms.Label();
            this.txt_fixed = new System.Windows.Forms.TextBox();
            this.fixed_lbl = new System.Windows.Forms.Label();
            this.discount_value = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size_box = new System.Windows.Forms.ComboBox();
            this.size_lbl = new System.Windows.Forms.Label();
            this.status_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cathegory_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.head_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.amount_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discount_value)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.Teal;
            this.head_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head_panel.Controls.Add(this.label1);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(1332, 85);
            this.head_panel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(520, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 63);
            this.label1.TabIndex = 26;
            this.label1.Text = "Add Discount";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_food_id);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 804);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_food_id
            // 
            this.txt_food_id.Location = new System.Drawing.Point(345, 17);
            this.txt_food_id.MaxLength = 5;
            this.txt_food_id.Name = "txt_food_id";
            this.txt_food_id.ReadOnly = true;
            this.txt_food_id.Size = new System.Drawing.Size(146, 31);
            this.txt_food_id.TabIndex = 7;
            this.txt_food_id.Visible = false;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(1062, 18);
            this.txt_ID.MaxLength = 5;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(146, 31);
            this.txt_ID.TabIndex = 14;
            this.txt_ID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(68, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "Food ID                   :";
            this.label8.Visible = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_update.FlatAppearance.BorderSize = 3;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.Snow;
            this.btn_update.Location = new System.Drawing.Point(1133, 652);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(184, 65);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "&UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(768, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Discount ID            :";
            this.label2.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_back.FlatAppearance.BorderSize = 3;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.Snow;
            this.btn_back.Location = new System.Drawing.Point(-2, 737);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(161, 65);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "&BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_reset.FlatAppearance.BorderSize = 3;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.ForeColor = System.Drawing.Color.Snow;
            this.btn_reset.Location = new System.Drawing.Point(949, 652);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(178, 65);
            this.btn_reset.TabIndex = 23;
            this.btn_reset.Text = "&RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_add.FlatAppearance.BorderSize = 3;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.Snow;
            this.btn_add.Location = new System.Drawing.Point(759, 652);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(184, 65);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "&ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.end_calender);
            this.groupBox2.Controls.Add(this.start_calender);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(37, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 342);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discount time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(376, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "Expired on                      ";
            // 
            // end_calender
            // 
            this.end_calender.BackColor = System.Drawing.Color.Snow;
            this.end_calender.Enabled = false;
            this.end_calender.Location = new System.Drawing.Point(376, 71);
            this.end_calender.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.end_calender.MinDate = new System.DateTime(1980, 12, 31, 0, 0, 0, 0);
            this.end_calender.Name = "end_calender";
            this.end_calender.ShowTodayCircle = false;
            this.end_calender.TabIndex = 21;
            this.end_calender.TitleBackColor = System.Drawing.Color.MediumSeaGreen;
            this.end_calender.TodayDate = new System.DateTime(2021, 6, 18, 0, 0, 0, 0);
            // 
            // start_calender
            // 
            this.start_calender.BackColor = System.Drawing.Color.Snow;
            this.start_calender.Location = new System.Drawing.Point(30, 71);
            this.start_calender.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.start_calender.MinDate = new System.DateTime(1980, 12, 31, 0, 0, 0, 0);
            this.start_calender.Name = "start_calender";
            this.start_calender.ShowTodayCircle = false;
            this.start_calender.TabIndex = 19;
            this.start_calender.TitleBackColor = System.Drawing.Color.MediumSeaGreen;
            this.start_calender.TodayDate = new System.DateTime(2021, 6, 18, 0, 0, 0, 0);
            this.start_calender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.start_calender_DateSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "Starts From                     ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.amount_box);
            this.groupBox3.Controls.Add(this.discount_value);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(759, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 305);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount Details";
            // 
            // amount_box
            // 
            this.amount_box.Controls.Add(this.txt_current);
            this.amount_box.Controls.Add(this.current_lbl);
            this.amount_box.Controls.Add(this.txt_deducted);
            this.amount_box.Controls.Add(this.deduct_lbl);
            this.amount_box.Controls.Add(this.txt_fixed);
            this.amount_box.Controls.Add(this.fixed_lbl);
            this.amount_box.Location = new System.Drawing.Point(9, 99);
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(544, 200);
            this.amount_box.TabIndex = 18;
            this.amount_box.TabStop = false;
            // 
            // txt_current
            // 
            this.txt_current.Location = new System.Drawing.Point(294, 139);
            this.txt_current.MaxLength = 5;
            this.txt_current.Name = "txt_current";
            this.txt_current.ReadOnly = true;
            this.txt_current.Size = new System.Drawing.Size(146, 31);
            this.txt_current.TabIndex = 23;
            // 
            // current_lbl
            // 
            this.current_lbl.AutoSize = true;
            this.current_lbl.BackColor = System.Drawing.Color.MintCream;
            this.current_lbl.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.current_lbl.Location = new System.Drawing.Point(8, 139);
            this.current_lbl.Name = "current_lbl";
            this.current_lbl.Size = new System.Drawing.Size(273, 35);
            this.current_lbl.TabIndex = 22;
            this.current_lbl.Text = "Current Price            :";
            // 
            // txt_deducted
            // 
            this.txt_deducted.Location = new System.Drawing.Point(294, 88);
            this.txt_deducted.MaxLength = 5;
            this.txt_deducted.Name = "txt_deducted";
            this.txt_deducted.ReadOnly = true;
            this.txt_deducted.Size = new System.Drawing.Size(146, 31);
            this.txt_deducted.TabIndex = 21;
            this.txt_deducted.TextChanged += new System.EventHandler(this.txt_deducted_TextChanged);
            // 
            // deduct_lbl
            // 
            this.deduct_lbl.AutoSize = true;
            this.deduct_lbl.BackColor = System.Drawing.Color.MintCream;
            this.deduct_lbl.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deduct_lbl.Location = new System.Drawing.Point(6, 84);
            this.deduct_lbl.Name = "deduct_lbl";
            this.deduct_lbl.Size = new System.Drawing.Size(275, 35);
            this.deduct_lbl.TabIndex = 20;
            this.deduct_lbl.Text = "Deducted Amount     :";
            // 
            // txt_fixed
            // 
            this.txt_fixed.Location = new System.Drawing.Point(294, 33);
            this.txt_fixed.MaxLength = 5;
            this.txt_fixed.Name = "txt_fixed";
            this.txt_fixed.ReadOnly = true;
            this.txt_fixed.Size = new System.Drawing.Size(146, 31);
            this.txt_fixed.TabIndex = 19;
            // 
            // fixed_lbl
            // 
            this.fixed_lbl.AutoSize = true;
            this.fixed_lbl.BackColor = System.Drawing.Color.MintCream;
            this.fixed_lbl.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fixed_lbl.Location = new System.Drawing.Point(6, 33);
            this.fixed_lbl.Name = "fixed_lbl";
            this.fixed_lbl.Size = new System.Drawing.Size(273, 35);
            this.fixed_lbl.TabIndex = 18;
            this.fixed_lbl.Text = "Fixed Price                :";
            // 
            // discount_value
            // 
            this.discount_value.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.discount_value.Location = new System.Drawing.Point(303, 52);
            this.discount_value.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.discount_value.Name = "discount_value";
            this.discount_value.Size = new System.Drawing.Size(146, 31);
            this.discount_value.TabIndex = 13;
            this.discount_value.ValueChanged += new System.EventHandler(this.discount_value_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MintCream;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 35);
            this.label9.TabIndex = 12;
            this.label9.Text = "Discount Percentage:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.size_box);
            this.groupBox1.Controls.Add(this.size_lbl);
            this.groupBox1.Controls.Add(this.status_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cathegory_box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.name_box);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(37, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 305);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount for";
            // 
            // size_box
            // 
            this.size_box.BackColor = System.Drawing.Color.MintCream;
            this.size_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.size_box.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.size_box.FormattingEnabled = true;
            this.size_box.ItemHeight = 29;
            this.size_box.Location = new System.Drawing.Point(308, 187);
            this.size_box.Name = "size_box";
            this.size_box.Size = new System.Drawing.Size(242, 37);
            this.size_box.TabIndex = 13;
            this.size_box.SelectionChangeCommitted += new System.EventHandler(this.size_box_SelectionChangeCommitted);
            this.size_box.VisibleChanged += new System.EventHandler(this.size_box_VisibleChanged);
            this.size_box.Click += new System.EventHandler(this.size_box_Click);
            // 
            // size_lbl
            // 
            this.size_lbl.AutoSize = true;
            this.size_lbl.BackColor = System.Drawing.Color.MintCream;
            this.size_lbl.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size_lbl.Location = new System.Drawing.Point(29, 187);
            this.size_lbl.Name = "size_lbl";
            this.size_lbl.Size = new System.Drawing.Size(251, 35);
            this.size_lbl.TabIndex = 12;
            this.size_lbl.Text = "Select                      :";
            // 
            // status_box
            // 
            this.status_box.BackColor = System.Drawing.Color.MintCream;
            this.status_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_box.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status_box.FormattingEnabled = true;
            this.status_box.ItemHeight = 29;
            this.status_box.Items.AddRange(new object[] {
            "Available",
            "Cancelled",
            "Expired"});
            this.status_box.Location = new System.Drawing.Point(308, 240);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(242, 37);
            this.status_box.TabIndex = 9;
            this.status_box.SelectedIndexChanged += new System.EventHandler(this.status_box_SelectedIndexChanged);
            this.status_box.SelectionChangeCommitted += new System.EventHandler(this.status_box_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category                 :";
            // 
            // cathegory_box
            // 
            this.cathegory_box.BackColor = System.Drawing.Color.MintCream;
            this.cathegory_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cathegory_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cathegory_box.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cathegory_box.FormattingEnabled = true;
            this.cathegory_box.ItemHeight = 29;
            this.cathegory_box.Items.AddRange(new object[] {
            "Breakfast",
            "Chicken",
            "Drinks",
            "Dessert",
            "Dinner",
            "RiceBowls",
            "Starters",
            "Special Menu"});
            this.cathegory_box.Location = new System.Drawing.Point(308, 52);
            this.cathegory_box.Name = "cathegory_box";
            this.cathegory_box.Size = new System.Drawing.Size(242, 37);
            this.cathegory_box.TabIndex = 3;
            this.cathegory_box.SelectedIndexChanged += new System.EventHandler(this.cathegory_box_SelectedIndexChanged);
            this.cathegory_box.SelectionChangeCommitted += new System.EventHandler(this.cathegory_box_SelectionChangeCommitted);
            this.cathegory_box.Click += new System.EventHandler(this.cathegory_box_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Food Name             :";
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.MintCream;
            this.name_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_box.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_box.FormattingEnabled = true;
            this.name_box.ItemHeight = 29;
            this.name_box.Location = new System.Drawing.Point(308, 126);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(242, 37);
            this.name_box.TabIndex = 5;
            this.name_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.name_box.SelectionChangeCommitted += new System.EventHandler(this.name_box_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MintCream;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(31, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 35);
            this.label12.TabIndex = 8;
            this.label12.Text = "Status                      :";
            // 
            // Add_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1332, 905);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.head_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Discount";
            this.Load += new System.EventHandler(this.Add_Discount_Load);
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.amount_box.ResumeLayout(false);
            this.amount_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discount_value)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MonthCalendar end_calender;
        public System.Windows.Forms.MonthCalendar start_calender;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_food_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label size_lbl;
        private System.Windows.Forms.GroupBox amount_box;
        private System.Windows.Forms.Label current_lbl;
        private System.Windows.Forms.Label deduct_lbl;
        private System.Windows.Forms.Label fixed_lbl;
        public System.Windows.Forms.Button btn_reset;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.ComboBox cathegory_box;
        public System.Windows.Forms.ComboBox name_box;
        public System.Windows.Forms.NumericUpDown discount_value;
        public System.Windows.Forms.ComboBox status_box;
        public System.Windows.Forms.TextBox txt_ID;
        public System.Windows.Forms.ComboBox size_box;
        public System.Windows.Forms.TextBox txt_current;
        public System.Windows.Forms.TextBox txt_deducted;
        public System.Windows.Forms.TextBox txt_fixed;
    }
}