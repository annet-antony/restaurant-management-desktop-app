
namespace Restaurant_Project
{
    partial class View_table_reservation
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
            this.lbl_head = new System.Windows.Forms.Label();
            this.booking_view = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.view_panel = new System.Windows.Forms.Panel();
            this.btn_viewall = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_view)).BeginInit();
            this.view_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_head);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1571, 105);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_head.ForeColor = System.Drawing.Color.Snow;
            this.lbl_head.Location = new System.Drawing.Point(532, 17);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(491, 63);
            this.lbl_head.TabIndex = 1;
            this.lbl_head.Text = "Manage Table Bookings";
            this.lbl_head.Click += new System.EventHandler(this.label1_Click);
            // 
            // booking_view
            // 
            this.booking_view.AllowUserToAddRows = false;
            this.booking_view.AllowUserToResizeColumns = false;
            this.booking_view.AllowUserToResizeRows = false;
            this.booking_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.booking_view.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.booking_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booking_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booking_view.ColumnHeadersHeight = 85;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booking_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.booking_view.EnableHeadersVisualStyles = false;
            this.booking_view.Location = new System.Drawing.Point(3, 102);
            this.booking_view.Name = "booking_view";
            this.booking_view.ReadOnly = true;
            this.booking_view.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.booking_view.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.booking_view.RowTemplate.Height = 40;
            this.booking_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booking_view.Size = new System.Drawing.Size(1571, 485);
            this.booking_view.TabIndex = 2;
            this.booking_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booking_view_CellClick);
            this.booking_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booking_view_CellContentClick);
            this.booking_view.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.booking_view_CellFormatting);
            this.booking_view.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.booking_view_CellMouseClick);
            this.booking_view.Click += new System.EventHandler(this.booking_view_Click);
            this.booking_view.DoubleClick += new System.EventHandler(this.booking_view_DoubleClick);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_add.FlatAppearance.BorderSize = 10;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.Snow;
            this.btn_add.Location = new System.Drawing.Point(390, 617);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(251, 65);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "&ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.add_button_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_delete.FlatAppearance.BorderSize = 10;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete.Location = new System.Drawing.Point(912, 617);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(251, 65);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "&DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // btn_order
            // 
            this.btn_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_order.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_order.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_order.FlatAppearance.BorderSize = 10;
            this.btn_order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_order.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_order.ForeColor = System.Drawing.Color.Snow;
            this.btn_order.Location = new System.Drawing.Point(1173, 617);
            this.btn_order.Margin = new System.Windows.Forms.Padding(5);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(251, 65);
            this.btn_order.TabIndex = 5;
            this.btn_order.Text = "&FOOD ORDER";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 834);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 32);
            this.panel1.TabIndex = 7;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Honeydew;
            this.lbl_date.Font = new System.Drawing.Font("Sitka Display", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(40, 23);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(211, 40);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Filter By Date   :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 28);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 35);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 6, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // view_panel
            // 
            this.view_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.view_panel.Controls.Add(this.btn_viewall);
            this.view_panel.Controls.Add(this.btn_update);
            this.view_panel.Controls.Add(this.lbl_date);
            this.view_panel.Controls.Add(this.dateTimePicker1);
            this.view_panel.Controls.Add(this.btn_order);
            this.view_panel.Controls.Add(this.booking_view);
            this.view_panel.Controls.Add(this.btn_delete);
            this.view_panel.Controls.Add(this.btn_add);
            this.view_panel.Location = new System.Drawing.Point(0, 102);
            this.view_panel.Name = "view_panel";
            this.view_panel.Size = new System.Drawing.Size(1571, 734);
            this.view_panel.TabIndex = 8;
            this.view_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.view_panel_Paint);
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
            this.btn_viewall.Location = new System.Drawing.Point(512, 26);
            this.btn_viewall.Name = "btn_viewall";
            this.btn_viewall.Size = new System.Drawing.Size(163, 40);
            this.btn_viewall.TabIndex = 7;
            this.btn_viewall.Text = "&VIEW ALL";
            this.btn_viewall.UseVisualStyleBackColor = false;
            this.btn_viewall.Click += new System.EventHandler(this.btn_viewall_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_update.FlatAppearance.BorderSize = 10;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.Snow;
            this.btn_update.Location = new System.Drawing.Point(651, 617);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(251, 65);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "&UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // View_table_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1571, 866);
            this.ControlBox = false;
            this.Controls.Add(this.view_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_table_reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_table_reservation";
            this.Load += new System.EventHandler(this.View_table_reservation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booking_view)).EndInit();
            this.view_panel.ResumeLayout(false);
            this.view_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_order;
        public System.Windows.Forms.DataGridView booking_view;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel view_panel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_viewall;
    }
}