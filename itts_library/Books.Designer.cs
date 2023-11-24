namespace itts_library
{
    partial class Books
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
            this.full_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.books_table = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.role_level = new System.Windows.Forms.Label();
            this.borrower = new System.Windows.Forms.Button();
            this.borrowing = new System.Windows.Forms.Button();
            this.books_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITTSLIB";
            // 
            // full_name
            // 
            this.full_name.AutoSize = true;
            this.full_name.Location = new System.Drawing.Point(14, 27);
            this.full_name.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(0, 13);
            this.full_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daftar buku yang tersedia:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // books_table
            // 
            this.books_table.ColumnCount = 5;
            this.books_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.85714F));
            this.books_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.14286F));
            this.books_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.books_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.books_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.books_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.books_table.Controls.Add(this.label4, 1, 0);
            this.books_table.Controls.Add(this.label3, 0, 0);
            this.books_table.Controls.Add(this.label5, 2, 0);
            this.books_table.Controls.Add(this.label6, 3, 0);
            this.books_table.Controls.Add(this.label7, 4, 0);
            this.books_table.Location = new System.Drawing.Point(9, 131);
            this.books_table.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.books_table.Name = "books_table";
            this.books_table.RowCount = 1;
            this.books_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65066F));
            this.books_table.Size = new System.Drawing.Size(350, 189);
            this.books_table.TabIndex = 3;
            this.books_table.Paint += new System.Windows.Forms.PaintEventHandler(this.books_table_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Judul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Penerbit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Penulis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Action";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Role Level:";
            // 
            // role_level
            // 
            this.role_level.AutoSize = true;
            this.role_level.Location = new System.Drawing.Point(64, 53);
            this.role_level.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.role_level.Name = "role_level";
            this.role_level.Size = new System.Drawing.Size(0, 13);
            this.role_level.TabIndex = 5;
            // 
            // borrower
            // 
            this.borrower.Location = new System.Drawing.Point(199, 76);
            this.borrower.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.borrower.Name = "borrower";
            this.borrower.Size = new System.Drawing.Size(70, 20);
            this.borrower.TabIndex = 6;
            this.borrower.Text = "Peminjam";
            this.borrower.UseVisualStyleBackColor = true;
            this.borrower.Click += new System.EventHandler(this.borrower_Click);
            // 
            // borrowing
            // 
            this.borrowing.Location = new System.Drawing.Point(277, 76);
            this.borrowing.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.borrowing.Name = "borrowing";
            this.borrowing.Size = new System.Drawing.Size(82, 20);
            this.borrowing.TabIndex = 7;
            this.borrowing.Text = "Peminjaman";
            this.borrowing.UseVisualStyleBackColor = true;
            this.borrowing.Click += new System.EventHandler(this.borrowing_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 293);
            this.Controls.Add(this.borrowing);
            this.Controls.Add(this.borrower);
            this.Controls.Add(this.role_level);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.books_table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.full_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.books_table.ResumeLayout(false);
            this.books_table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label full_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel books_table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label role_level;
        private System.Windows.Forms.Button borrower;
        private System.Windows.Forms.Button borrowing;
    }
}