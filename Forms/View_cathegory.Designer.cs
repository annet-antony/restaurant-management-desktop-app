
namespace Restaurant_Project
{
    partial class View_cathegory
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
            this.lbl_head_cathegory = new System.Windows.Forms.Label();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.cathegory_grid = new System.Windows.Forms.DataGridView();
            this.No_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cathegory_add = new System.Windows.Forms.Button();
            this.btn_cathegory_delete = new System.Windows.Forms.Button();
            this.cathegory_panel = new System.Windows.Forms.Panel();
            this.btn_cathegory_update = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cathegory_grid)).BeginInit();
            this.cathegory_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_head_cathegory);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1576, 102);
            this.panel2.TabIndex = 8;
            // 
            // lbl_head_cathegory
            // 
            this.lbl_head_cathegory.AutoSize = true;
            this.lbl_head_cathegory.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_head_cathegory.ForeColor = System.Drawing.Color.Snow;
            this.lbl_head_cathegory.Location = new System.Drawing.Point(435, 7);
            this.lbl_head_cathegory.Name = "lbl_head_cathegory";
            this.lbl_head_cathegory.Size = new System.Drawing.Size(367, 63);
            this.lbl_head_cathegory.TabIndex = 2;
            this.lbl_head_cathegory.Text = "Manage Category";
            this.lbl_head_cathegory.Click += new System.EventHandler(this.label1_Click);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.Teal;
            this.bottom_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 782);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1576, 58);
            this.bottom_panel.TabIndex = 9;
            // 
            // cathegory_grid
            // 
            this.cathegory_grid.AllowUserToAddRows = false;
            this.cathegory_grid.AllowUserToResizeColumns = false;
            this.cathegory_grid.AllowUserToResizeRows = false;
            this.cathegory_grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cathegory_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cathegory_grid.ColumnHeadersHeight = 85;
            this.cathegory_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No_column,
            this.ID_column,
            this.name_column,
            this.size_column,
            this.Type_column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cathegory_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.cathegory_grid.EnableHeadersVisualStyles = false;
            this.cathegory_grid.Location = new System.Drawing.Point(269, 38);
            this.cathegory_grid.Name = "cathegory_grid";
            this.cathegory_grid.ReadOnly = true;
            this.cathegory_grid.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cathegory_grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.cathegory_grid.RowTemplate.Height = 40;
            this.cathegory_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cathegory_grid.Size = new System.Drawing.Size(714, 482);
            this.cathegory_grid.TabIndex = 0;
            this.cathegory_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cathegory_grid_CellClick);
            this.cathegory_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cathegory_grid_CellContentClick);
            this.cathegory_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cathegory_grid_CellDoubleClick);
            this.cathegory_grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.cathegory_grid_CellFormatting);
            this.cathegory_grid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.cathegory_grid_RowPostPaint);
            // 
            // No_column
            // 
            this.No_column.HeaderText = "No";
            this.No_column.MinimumWidth = 8;
            this.No_column.Name = "No_column";
            this.No_column.ReadOnly = true;
            this.No_column.Width = 50;
            // 
            // ID_column
            // 
            this.ID_column.HeaderText = "Cathegory_ID";
            this.ID_column.MinimumWidth = 8;
            this.ID_column.Name = "ID_column";
            this.ID_column.ReadOnly = true;
            this.ID_column.Visible = false;
            this.ID_column.Width = 150;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Category";
            this.name_column.MinimumWidth = 8;
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            this.name_column.Width = 200;
            // 
            // size_column
            // 
            this.size_column.HeaderText = "Size_Available";
            this.size_column.MinimumWidth = 8;
            this.size_column.Name = "size_column";
            this.size_column.ReadOnly = true;
            this.size_column.Width = 200;
            // 
            // Type_column
            // 
            this.Type_column.HeaderText = "Type_available";
            this.Type_column.MinimumWidth = 8;
            this.Type_column.Name = "Type_column";
            this.Type_column.ReadOnly = true;
            this.Type_column.Width = 200;
            // 
            // btn_cathegory_add
            // 
            this.btn_cathegory_add.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cathegory_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cathegory_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cathegory_add.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cathegory_add.ForeColor = System.Drawing.Color.Snow;
            this.btn_cathegory_add.Location = new System.Drawing.Point(219, 561);
            this.btn_cathegory_add.Name = "btn_cathegory_add";
            this.btn_cathegory_add.Size = new System.Drawing.Size(251, 65);
            this.btn_cathegory_add.TabIndex = 1;
            this.btn_cathegory_add.Text = "&ADD";
            this.btn_cathegory_add.UseVisualStyleBackColor = false;
            this.btn_cathegory_add.Click += new System.EventHandler(this.btn_cathegory_add_Click);
            // 
            // btn_cathegory_delete
            // 
            this.btn_cathegory_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cathegory_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cathegory_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cathegory_delete.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cathegory_delete.ForeColor = System.Drawing.Color.Snow;
            this.btn_cathegory_delete.Location = new System.Drawing.Point(814, 561);
            this.btn_cathegory_delete.Name = "btn_cathegory_delete";
            this.btn_cathegory_delete.Size = new System.Drawing.Size(251, 65);
            this.btn_cathegory_delete.TabIndex = 3;
            this.btn_cathegory_delete.Text = "&DELETE";
            this.btn_cathegory_delete.UseVisualStyleBackColor = false;
            this.btn_cathegory_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cathegory_panel
            // 
            this.cathegory_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cathegory_panel.Controls.Add(this.btn_cathegory_update);
            this.cathegory_panel.Controls.Add(this.btn_cathegory_add);
            this.cathegory_panel.Controls.Add(this.cathegory_grid);
            this.cathegory_panel.Controls.Add(this.btn_cathegory_delete);
            this.cathegory_panel.Location = new System.Drawing.Point(0, 98);
            this.cathegory_panel.Name = "cathegory_panel";
            this.cathegory_panel.Size = new System.Drawing.Size(1411, 660);
            this.cathegory_panel.TabIndex = 92;
            this.cathegory_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.cathegory_panel_Paint);
            // 
            // btn_cathegory_update
            // 
            this.btn_cathegory_update.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cathegory_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cathegory_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cathegory_update.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cathegory_update.ForeColor = System.Drawing.Color.Snow;
            this.btn_cathegory_update.Location = new System.Drawing.Point(520, 561);
            this.btn_cathegory_update.Name = "btn_cathegory_update";
            this.btn_cathegory_update.Size = new System.Drawing.Size(251, 65);
            this.btn_cathegory_update.TabIndex = 2;
            this.btn_cathegory_update.Text = "&UPDATE";
            this.btn_cathegory_update.UseVisualStyleBackColor = false;
            this.btn_cathegory_update.Click += new System.EventHandler(this.btn_cathegory_update_Click);
            // 
            // View_cathegory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1413, 866);
            this.ControlBox = false;
            this.Controls.Add(this.cathegory_panel);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_cathegory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_cathegory";
            this.Load += new System.EventHandler(this.View_cathegory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cathegory_grid)).EndInit();
            this.cathegory_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_head_cathegory;
        public System.Windows.Forms.DataGridView cathegory_grid;
        private System.Windows.Forms.Button btn_cathegory_add;
        private System.Windows.Forms.Button btn_cathegory_delete;
        public System.Windows.Forms.Panel cathegory_panel;
        public System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Button btn_cathegory_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_column;
    }
}