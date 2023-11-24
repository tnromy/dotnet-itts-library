namespace itts_library
{
    partial class Borrowers
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
            this.label1 = new System.Windows.Forms.Label();
            this.role_level = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.full_name = new System.Windows.Forms.Label();
            this.borrowers_table = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_borrower = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.borrowers_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ITTSLIB";
            // 
            // role_level
            // 
            this.role_level.AutoSize = true;
            this.role_level.Location = new System.Drawing.Point(64, 48);
            this.role_level.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.role_level.Name = "role_level";
            this.role_level.Size = new System.Drawing.Size(0, 13);
            this.role_level.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Role Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Daftar akun peminjam:";
            // 
            // full_name
            // 
            this.full_name.AutoSize = true;
            this.full_name.Location = new System.Drawing.Point(14, 22);
            this.full_name.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(0, 13);
            this.full_name.TabIndex = 6;
            // 
            // borrowers_table
            // 
            this.borrowers_table.ColumnCount = 3;
            this.borrowers_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.63443F));
            this.borrowers_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.36557F));
            this.borrowers_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.borrowers_table.Controls.Add(this.label5, 2, 0);
            this.borrowers_table.Controls.Add(this.label3, 0, 0);
            this.borrowers_table.Controls.Add(this.label4, 1, 0);
            this.borrowers_table.Location = new System.Drawing.Point(14, 106);
            this.borrowers_table.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.borrowers_table.Name = "borrowers_table";
            this.borrowers_table.RowCount = 2;
            this.borrowers_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.borrowers_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.borrowers_table.Size = new System.Drawing.Size(221, 140);
            this.borrowers_table.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nama Lengkap";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // add_borrower
            // 
            this.add_borrower.Location = new System.Drawing.Point(139, 80);
            this.add_borrower.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.add_borrower.Name = "add_borrower";
            this.add_borrower.Size = new System.Drawing.Size(135, 19);
            this.add_borrower.TabIndex = 14;
            this.add_borrower.Text = "Tambah Akun Peminjam";
            this.add_borrower.UseVisualStyleBackColor = true;
            this.add_borrower.Click += new System.EventHandler(this.add_borrower_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(181, 8);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Borrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 246);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add_borrower);
            this.Controls.Add(this.borrowers_table);
            this.Controls.Add(this.role_level);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.full_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Borrowers";
            this.Text = "Borrowers";
            this.borrowers_table.ResumeLayout(false);
            this.borrowers_table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label role_level;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label full_name;
        private System.Windows.Forms.TableLayoutPanel borrowers_table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_borrower;
        private System.Windows.Forms.Button back;
    }
}