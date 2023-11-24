namespace itts_library
{
    partial class Borrowings
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
            this.borrowings_table = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.borrowings_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // role_level
            // 
            this.role_level.AutoSize = true;
            this.role_level.Location = new System.Drawing.Point(67, 54);
            this.role_level.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.role_level.Name = "role_level";
            this.role_level.Size = new System.Drawing.Size(0, 13);
            this.role_level.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Role Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Daftar peminjaman buku:";
            // 
            // full_name
            // 
            this.full_name.AutoSize = true;
            this.full_name.Location = new System.Drawing.Point(17, 28);
            this.full_name.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(0, 13);
            this.full_name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ITTSLIB";
            // 
            // borrowings_table
            // 
            this.borrowings_table.ColumnCount = 3;
            this.borrowings_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.4359F));
            this.borrowings_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.5641F));
            this.borrowings_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.borrowings_table.Controls.Add(this.label5, 2, 0);
            this.borrowings_table.Controls.Add(this.label4, 1, 0);
            this.borrowings_table.Controls.Add(this.label3, 0, 0);
            this.borrowings_table.Location = new System.Drawing.Point(12, 122);
            this.borrowings_table.Name = "borrowings_table";
            this.borrowings_table.RowCount = 1;
            this.borrowings_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.borrowings_table.Size = new System.Drawing.Size(337, 187);
            this.borrowings_table.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Judul Buku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Username Peminjam";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(258, 9);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Borrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.borrowings_table);
            this.Controls.Add(this.role_level);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.full_name);
            this.Controls.Add(this.label1);
            this.Name = "Borrowings";
            this.Text = "Borrowings";
            this.borrowings_table.ResumeLayout(false);
            this.borrowings_table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label role_level;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label full_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel borrowings_table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
    }
}