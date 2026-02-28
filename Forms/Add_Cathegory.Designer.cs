
namespace Restaurant_Project
{
    partial class Add_Cathegory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cathegory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size_n = new System.Windows.Forms.RadioButton();
            this.size_y = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.type_n = new System.Windows.Forms.RadioButton();
            this.type_y = new System.Windows.Forms.RadioButton();
            this.btn_cathegory_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_cathegory_update = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 92);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(217, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 628);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 46);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category              :";
            // 
            // txt_cathegory
            // 
            this.txt_cathegory.Location = new System.Drawing.Point(299, 138);
            this.txt_cathegory.MaxLength = 25;
            this.txt_cathegory.Name = "txt_cathegory";
            this.txt_cathegory.Size = new System.Drawing.Size(213, 31);
            this.txt_cathegory.TabIndex = 1;
            this.txt_cathegory.TextChanged += new System.EventHandler(this.txt_cathegory_TextChanged);
            this.txt_cathegory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cathegory_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sizes Available    :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.size_n);
            this.groupBox1.Controls.Add(this.size_y);
            this.groupBox1.Location = new System.Drawing.Point(299, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // size_n
            // 
            this.size_n.AutoSize = true;
            this.size_n.BackColor = System.Drawing.Color.MintCream;
            this.size_n.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size_n.Location = new System.Drawing.Point(120, 20);
            this.size_n.Name = "size_n";
            this.size_n.Size = new System.Drawing.Size(74, 39);
            this.size_n.TabIndex = 5;
            this.size_n.Text = "No";
            this.size_n.UseVisualStyleBackColor = false;
            // 
            // size_y
            // 
            this.size_y.AutoSize = true;
            this.size_y.BackColor = System.Drawing.Color.MintCream;
            this.size_y.Checked = true;
            this.size_y.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size_y.Location = new System.Drawing.Point(6, 20);
            this.size_y.Name = "size_y";
            this.size_y.Size = new System.Drawing.Size(81, 39);
            this.size_y.TabIndex = 4;
            this.size_y.TabStop = true;
            this.size_y.Text = "Yes";
            this.size_y.UseVisualStyleBackColor = false;
            this.size_y.CheckedChanged += new System.EventHandler(this.size_y_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Types Available   :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.type_n);
            this.groupBox2.Controls.Add(this.type_y);
            this.groupBox2.Location = new System.Drawing.Point(299, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 72);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // type_n
            // 
            this.type_n.AutoSize = true;
            this.type_n.BackColor = System.Drawing.Color.MintCream;
            this.type_n.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type_n.Location = new System.Drawing.Point(120, 20);
            this.type_n.Name = "type_n";
            this.type_n.Size = new System.Drawing.Size(74, 39);
            this.type_n.TabIndex = 9;
            this.type_n.Text = "No";
            this.type_n.UseVisualStyleBackColor = false;
            // 
            // type_y
            // 
            this.type_y.AutoSize = true;
            this.type_y.BackColor = System.Drawing.Color.MintCream;
            this.type_y.Checked = true;
            this.type_y.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type_y.Location = new System.Drawing.Point(6, 20);
            this.type_y.Name = "type_y";
            this.type_y.Size = new System.Drawing.Size(81, 39);
            this.type_y.TabIndex = 8;
            this.type_y.TabStop = true;
            this.type_y.Text = "Yes";
            this.type_y.UseVisualStyleBackColor = false;
            // 
            // btn_cathegory_add
            // 
            this.btn_cathegory_add.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cathegory_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cathegory_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cathegory_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cathegory_add.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cathegory_add.ForeColor = System.Drawing.Color.Snow;
            this.btn_cathegory_add.Location = new System.Drawing.Point(148, 435);
            this.btn_cathegory_add.Name = "btn_cathegory_add";
            this.btn_cathegory_add.Size = new System.Drawing.Size(149, 63);
            this.btn_cathegory_add.TabIndex = 10;
            this.btn_cathegory_add.Text = "&ADD";
            this.btn_cathegory_add.UseVisualStyleBackColor = false;
            this.btn_cathegory_add.Click += new System.EventHandler(this.btn_cathegory_add_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_reset.FlatAppearance.BorderSize = 3;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.ForeColor = System.Drawing.Color.Snow;
            this.btn_reset.Location = new System.Drawing.Point(334, 435);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(159, 63);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "&RESET\r\n";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_back.FlatAppearance.BorderSize = 3;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.Snow;
            this.btn_back.Location = new System.Drawing.Point(1, 557);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(157, 65);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "&BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_cathegory_update
            // 
            this.btn_cathegory_update.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_cathegory_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cathegory_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cathegory_update.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cathegory_update.ForeColor = System.Drawing.Color.Snow;
            this.btn_cathegory_update.Location = new System.Drawing.Point(528, 435);
            this.btn_cathegory_update.Name = "btn_cathegory_update";
            this.btn_cathegory_update.Size = new System.Drawing.Size(149, 63);
            this.btn_cathegory_update.TabIndex = 12;
            this.btn_cathegory_update.Text = "&UPDATE";
            this.btn_cathegory_update.UseVisualStyleBackColor = false;
            this.btn_cathegory_update.Click += new System.EventHandler(this.btn_cathegory_update_Click);
            // 
            // Add_Cathegory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 674);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cathegory_update);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_cathegory_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cathegory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Cathegory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cathegory";
            this.Load += new System.EventHandler(this.Add_Cathegory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_cathegory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton size_n;
        public System.Windows.Forms.RadioButton size_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton type_n;
        public System.Windows.Forms.RadioButton type_y;
        public System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.Button btn_cathegory_add;
        public System.Windows.Forms.Button btn_cathegory_update;
    }
}