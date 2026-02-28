
namespace Restaurant_Project
{
    partial class Login_form
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
            this.head_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.show_password = new System.Windows.Forms.CheckBox();
            this.cancel = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.user_password = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // head_label
            // 
            this.head_label.AutoSize = true;
            this.head_label.BackColor = System.Drawing.Color.Transparent;
            this.head_label.Font = new System.Drawing.Font("Monotype Corsiva", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.head_label.ForeColor = System.Drawing.Color.DarkRed;
            this.head_label.Location = new System.Drawing.Point(315, 305);
            this.head_label.Name = "head_label";
            this.head_label.Size = new System.Drawing.Size(172, 79);
            this.head_label.TabIndex = 2;
            this.head_label.Text = "Login\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(121, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 85);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(496, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 85);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elite";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.show_password);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.user_password);
            this.panel1.Controls.Add(this.user_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.user_label);
            this.panel1.Location = new System.Drawing.Point(75, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 360);
            this.panel1.TabIndex = 6;
            // 
            // show_password
            // 
            this.show_password.AutoSize = true;
            this.show_password.BackColor = System.Drawing.Color.Transparent;
            this.show_password.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.show_password.ForeColor = System.Drawing.Color.Maroon;
            this.show_password.Location = new System.Drawing.Point(265, 141);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(200, 39);
            this.show_password.TabIndex = 11;
            this.show_password.Text = "Show Password";
            this.show_password.UseVisualStyleBackColor = false;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged);
            // 
            // cancel
            // 
            this.cancel.BackgroundImage = global::Restaurant_Project.Properties.Resources.de1cc8aaf816632956a83939d3009eff_copy;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.Maroon;
            this.cancel.Location = new System.Drawing.Point(131, 222);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(161, 69);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // login_button
            // 
            this.login_button.BackgroundImage = global::Restaurant_Project.Properties.Resources.de1cc8aaf816632956a83939d3009eff_copy;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_button.ForeColor = System.Drawing.Color.Maroon;
            this.login_button.Location = new System.Drawing.Point(346, 222);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(165, 69);
            this.login_button.TabIndex = 9;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click_1);
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.Color.White;
            this.user_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_password.ForeColor = System.Drawing.Color.Maroon;
            this.user_password.Location = new System.Drawing.Point(265, 103);
            this.user_password.MaxLength = 20;
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(261, 32);
            this.user_password.TabIndex = 8;
            // 
            // user_txt
            // 
            this.user_txt.BackColor = System.Drawing.Color.White;
            this.user_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_txt.ForeColor = System.Drawing.Color.Maroon;
            this.user_txt.Location = new System.Drawing.Point(265, 45);
            this.user_txt.MaxLength = 10;
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(261, 32);
            this.user_txt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password   :";
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.BackColor = System.Drawing.Color.Transparent;
            this.user_label.Font = new System.Drawing.Font("Sitka Display", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_label.ForeColor = System.Drawing.Color.DarkRed;
            this.user_label.Location = new System.Drawing.Point(22, 25);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(227, 58);
            this.user_label.TabIndex = 5;
            this.user_label.Text = "User name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Restaurant_Project.Properties.Resources.depositphotos_89562490_stock_illustration_cartoon_funny_chef_cartoon_holding_removebg_preview;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(75, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 160);
            this.panel2.TabIndex = 7;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant_Project.Properties.Resources.de1cc8aaf816632956a83939d3009eff_v1_cropped;
            this.ClientSize = new System.Drawing.Size(750, 899);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.head_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_form";
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox show_password;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Panel panel2;
    }
}