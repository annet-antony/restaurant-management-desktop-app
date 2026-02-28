
namespace Restaurant_Project
{
    partial class view_food
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.food_panel = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.FoodGridView = new System.Windows.Forms.DataGridView();
            this.btn_viewall = new System.Windows.Forms.Button();
            this.cathegory_box = new System.Windows.Forms.ComboBox();
            this.lbl_cathegory = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.food_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1576, 117);
            this.panel2.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.Color.Snow;
            this.lbl1.Location = new System.Drawing.Point(690, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(295, 63);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Manage Food";
            // 
            // food_panel
            // 
            this.food_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.food_panel.Controls.Add(this.btn_update);
            this.food_panel.Controls.Add(this.btn_delete);
            this.food_panel.Controls.Add(this.panel1);
            this.food_panel.Controls.Add(this.btn_add);
            this.food_panel.Controls.Add(this.FoodGridView);
            this.food_panel.Location = new System.Drawing.Point(2, 210);
            this.food_panel.Name = "food_panel";
            this.food_panel.Size = new System.Drawing.Size(1560, 660);
            this.food_panel.TabIndex = 8;
            this.food_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.food_panel_Paint);
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
            this.btn_update.Location = new System.Drawing.Point(561, 506);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(251, 65);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "&UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_delete.FlatAppearance.BorderSize = 3;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete.Location = new System.Drawing.Point(860, 506);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(251, 65);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "&DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 618);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 36);
            this.panel1.TabIndex = 8;
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
            this.btn_add.Location = new System.Drawing.Point(263, 506);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(251, 65);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "&ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FoodGridView
            // 
            this.FoodGridView.AllowUserToAddRows = false;
            this.FoodGridView.AllowUserToResizeColumns = false;
            this.FoodGridView.AllowUserToResizeRows = false;
            this.FoodGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FoodGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FoodGridView.ColumnHeadersHeight = 85;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FoodGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FoodGridView.EnableHeadersVisualStyles = false;
            this.FoodGridView.Location = new System.Drawing.Point(-2, -2);
            this.FoodGridView.Name = "FoodGridView";
            this.FoodGridView.ReadOnly = true;
            this.FoodGridView.RowHeadersWidth = 62;
            this.FoodGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.FoodGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FoodGridView.RowTemplate.Height = 40;
            this.FoodGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FoodGridView.Size = new System.Drawing.Size(1562, 471);
            this.FoodGridView.TabIndex = 2;
            this.FoodGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodGridView_CellClick);
            this.FoodGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodGridView_CellDoubleClick);
            this.FoodGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.FoodGridView_CellFormatting);
            this.FoodGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FoodGridView_CellMouseClick);
            this.FoodGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.FoodGridView_RowPostPaint);
            this.FoodGridView.Click += new System.EventHandler(this.FoodGridView_Click);
            // 
            // btn_viewall
            // 
            this.btn_viewall.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_viewall.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_viewall.FlatAppearance.BorderSize = 3;
            this.btn_viewall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_viewall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_viewall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewall.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_viewall.ForeColor = System.Drawing.Color.Snow;
            this.btn_viewall.Location = new System.Drawing.Point(585, 138);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(190, 40);
            this.btn_viewall.TabIndex = 5;
            this.btn_viewall.Text = "&VIEW ALL";
            this.btn_viewall.UseVisualStyleBackColor = false;
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // cathegory_box
            // 
            this.cathegory_box.BackColor = System.Drawing.Color.MintCream;
            this.cathegory_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cathegory_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cathegory_box.Font = new System.Drawing.Font("Sitka Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cathegory_box.FormattingEnabled = true;
            this.cathegory_box.ItemHeight = 32;
            this.cathegory_box.Items.AddRange(new object[] {
            "",
            ""});
            this.cathegory_box.Location = new System.Drawing.Point(283, 138);
            this.cathegory_box.Name = "cathegory_box";
            this.cathegory_box.Size = new System.Drawing.Size(285, 40);
            this.cathegory_box.TabIndex = 1;
            this.cathegory_box.SelectedIndexChanged += new System.EventHandler(this.cathegory_box_SelectedIndexChanged);
            this.cathegory_box.SelectionChangeCommitted += new System.EventHandler(this.cathegory_box_SelectionChangeCommitted);
            this.cathegory_box.Click += new System.EventHandler(this.cathegory_box_Click);
            // 
            // lbl_cathegory
            // 
            this.lbl_cathegory.AutoSize = true;
            this.lbl_cathegory.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_cathegory.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cathegory.Location = new System.Drawing.Point(67, 138);
            this.lbl_cathegory.Name = "lbl_cathegory";
            this.lbl_cathegory.Size = new System.Drawing.Size(159, 40);
            this.lbl_cathegory.TabIndex = 0;
            this.lbl_cathegory.Text = "Category    :";
            // 
            // view_food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1576, 881);
            this.ControlBox = false;
            this.Controls.Add(this.btn_viewall);
            this.Controls.Add(this.lbl_cathegory);
            this.Controls.Add(this.cathegory_box);
            this.Controls.Add(this.food_panel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view_food";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Food";
            this.Load += new System.EventHandler(this.View_Food_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.food_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel food_panel;
        private System.Windows.Forms.ComboBox cathegory_box;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.DataGridView FoodGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_viewall;
        private System.Windows.Forms.Label lbl_cathegory;
        private System.Windows.Forms.Button btn_update;
    }
}