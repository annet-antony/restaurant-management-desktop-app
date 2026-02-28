
namespace Restaurant_Project
{
    partial class Add_Wastage
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radio_raw = new System.Windows.Forms.RadioButton();
            this.radio_food = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.measure_box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_unit_price = new System.Windows.Forms.TextBox();
            this.lbl_food_cathegory = new System.Windows.Forms.Label();
            this.cathegory_box = new System.Windows.Forms.ComboBox();
            this.unit_box = new System.Windows.Forms.NumericUpDown();
            this.head_panel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unit_box)).BeginInit();
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
            this.head_panel.Size = new System.Drawing.Size(1049, 97);
            this.head_panel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(375, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food Wastage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date                        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wastage ID            :";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category                 :";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(338, 109);
            this.txt_ID.MaxLength = 5;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(146, 31);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radio_raw);
            this.groupBox4.Controls.Add(this.radio_food);
            this.groupBox4.Location = new System.Drawing.Point(338, 407);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 68);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // radio_raw
            // 
            this.radio_raw.AutoSize = true;
            this.radio_raw.BackColor = System.Drawing.Color.MintCream;
            this.radio_raw.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_raw.Location = new System.Drawing.Point(124, 18);
            this.radio_raw.Name = "radio_raw";
            this.radio_raw.Size = new System.Drawing.Size(216, 39);
            this.radio_raw.TabIndex = 7;
            this.radio_raw.Text = "Raw Materials";
            this.radio_raw.UseVisualStyleBackColor = false;
            this.radio_raw.CheckedChanged += new System.EventHandler(this.radio_raw_CheckedChanged);
            // 
            // radio_food
            // 
            this.radio_food.AutoSize = true;
            this.radio_food.BackColor = System.Drawing.Color.MintCream;
            this.radio_food.Checked = true;
            this.radio_food.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_food.Location = new System.Drawing.Point(6, 20);
            this.radio_food.Name = "radio_food";
            this.radio_food.Size = new System.Drawing.Size(97, 39);
            this.radio_food.TabIndex = 6;
            this.radio_food.TabStop = true;
            this.radio_food.Text = "Food";
            this.radio_food.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Snow;
            this.monthCalendar1.Location = new System.Drawing.Point(338, 156);
            this.monthCalendar1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(1980, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.MediumSeaGreen;
            this.monthCalendar1.TodayDate = new System.DateTime(2021, 6, 18, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name                       :";
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.MintCream;
            this.name_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_box.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_box.FormattingEnabled = true;
            this.name_box.ItemHeight = 29;
            this.name_box.Location = new System.Drawing.Point(338, 538);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(252, 37);
            this.name_box.TabIndex = 11;
            this.name_box.Click += new System.EventHandler(this.name_box_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unit of Measure    :";
            // 
            // measure_box
            // 
            this.measure_box.BackColor = System.Drawing.Color.MintCream;
            this.measure_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measure_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.measure_box.FormattingEnabled = true;
            this.measure_box.Location = new System.Drawing.Point(338, 599);
            this.measure_box.Name = "measure_box";
            this.measure_box.Size = new System.Drawing.Size(146, 33);
            this.measure_box.TabIndex = 13;
            this.measure_box.SelectionChangeCommitted += new System.EventHandler(this.measure_box_SelectionChangeCommitted);
            this.measure_box.Click += new System.EventHandler(this.measure_box_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MintCream;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 35);
            this.label7.TabIndex = 16;
            this.label7.Text = "Waste Amount      :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 810);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 35);
            this.label8.TabIndex = 20;
            this.label8.Text = "Reason                   :";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(338, 810);
            this.txt_reason.MaxLength = 50;
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(340, 82);
            this.txt_reason.TabIndex = 21;
            this.txt_reason.TextChanged += new System.EventHandler(this.txt_reason_TextChanged);
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
            this.btn_add.Location = new System.Drawing.Point(804, 627);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(203, 62);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "&ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.btn_reset.Location = new System.Drawing.Point(804, 702);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(203, 65);
            this.btn_reset.TabIndex = 23;
            this.btn_reset.Text = "&RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MintCream;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(35, 754);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 35);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cost                        :";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(338, 754);
            this.txt_cost.MaxLength = 8;
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.ReadOnly = true;
            this.txt_cost.Size = new System.Drawing.Size(146, 31);
            this.txt_cost.TabIndex = 19;
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
            this.btn_back.Location = new System.Drawing.Point(804, 780);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(203, 65);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "&BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.btn_update.Location = new System.Drawing.Point(804, 624);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(203, 65);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "&UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(338, 702);
            this.txt_amount.MaxLength = 5;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(146, 31);
            this.txt_amount.TabIndex = 17;
            this.txt_amount.Visible = false;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MintCream;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(33, 653);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 35);
            this.label9.TabIndex = 14;
            this.label9.Text = "Unit Price              :";
            // 
            // txt_unit_price
            // 
            this.txt_unit_price.Location = new System.Drawing.Point(338, 653);
            this.txt_unit_price.MaxLength = 5;
            this.txt_unit_price.Name = "txt_unit_price";
            this.txt_unit_price.ReadOnly = true;
            this.txt_unit_price.Size = new System.Drawing.Size(146, 31);
            this.txt_unit_price.TabIndex = 15;
            // 
            // lbl_food_cathegory
            // 
            this.lbl_food_cathegory.AutoSize = true;
            this.lbl_food_cathegory.BackColor = System.Drawing.Color.MintCream;
            this.lbl_food_cathegory.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_food_cathegory.Location = new System.Drawing.Point(33, 488);
            this.lbl_food_cathegory.Name = "lbl_food_cathegory";
            this.lbl_food_cathegory.Size = new System.Drawing.Size(253, 35);
            this.lbl_food_cathegory.TabIndex = 8;
            this.lbl_food_cathegory.Text = "Food Cathegory      :";
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
            this.cathegory_box.Location = new System.Drawing.Point(338, 490);
            this.cathegory_box.Name = "cathegory_box";
            this.cathegory_box.Size = new System.Drawing.Size(252, 37);
            this.cathegory_box.TabIndex = 9;
            this.cathegory_box.Click += new System.EventHandler(this.cathegory_box_Click);
            // 
            // unit_box
            // 
            this.unit_box.Location = new System.Drawing.Point(338, 702);
            this.unit_box.Name = "unit_box";
            this.unit_box.Size = new System.Drawing.Size(146, 31);
            this.unit_box.TabIndex = 25;
            this.unit_box.Visible = false;
            this.unit_box.ValueChanged += new System.EventHandler(this.unit_box_ValueChanged);
            // 
            // Add_Wastage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1049, 922);
            this.Controls.Add(this.unit_box);
            this.Controls.Add(this.cathegory_box);
            this.Controls.Add(this.lbl_food_cathegory);
            this.Controls.Add(this.txt_unit_price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.measure_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.head_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Wastage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Wastage";
            this.Load += new System.EventHandler(this.Add_Wastage_Load);
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unit_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.RadioButton radio_raw;
        public System.Windows.Forms.RadioButton radio_food;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_food_cathegory;
        public System.Windows.Forms.TextBox txt_ID;
        public System.Windows.Forms.ComboBox name_box;
        public System.Windows.Forms.ComboBox measure_box;
        public System.Windows.Forms.TextBox txt_reason;
        public System.Windows.Forms.Button btn_reset;
        public System.Windows.Forms.TextBox txt_cost;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.TextBox txt_unit_price;
        public System.Windows.Forms.ComboBox cathegory_box;
        public System.Windows.Forms.NumericUpDown unit_box;
        public System.Windows.Forms.TextBox txt_amount;
    }
}