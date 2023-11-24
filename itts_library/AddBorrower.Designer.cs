namespace itts_library
{
    partial class AddBorrower
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
            this.role_level = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.full_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.full_name_input = new System.Windows.Forms.TextBox();
            this.username_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // role_level
            // 
            this.role_level.AutoSize = true;
            this.role_level.Location = new System.Drawing.Point(66, 49);
            this.role_level.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.role_level.Name = "role_level";
            this.role_level.Size = new System.Drawing.Size(0, 13);
            this.role_level.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Role Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tambah akun peminjam";
            // 
            // full_name
            // 
            this.full_name.AutoSize = true;
            this.full_name.Location = new System.Drawing.Point(16, 23);
            this.full_name.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(0, 13);
            this.full_name.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ITTSLIB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nama Lengkap:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // full_name_input
            // 
            this.full_name_input.Location = new System.Drawing.Point(97, 106);
            this.full_name_input.Name = "full_name_input";
            this.full_name_input.Size = new System.Drawing.Size(100, 20);
            this.full_name_input.TabIndex = 16;
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(97, 150);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(100, 20);
            this.username_input.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Username:";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(97, 194);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(100, 20);
            this.password_input.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password:";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(122, 250);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 21;
            this.add_button.Text = "Tambah";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.full_name_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.role_level);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.full_name);
            this.Controls.Add(this.label1);
            this.Name = "AddBorrower";
            this.Text = "AddBorrower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label role_level;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label full_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox full_name_input;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_button;
    }
}