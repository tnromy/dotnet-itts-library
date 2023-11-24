using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace itts_library
{
    public partial class Books : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();




        public Books()
        {
            InitializeComponent();
            full_name.Text = UserData.user.full_name;
            if (UserData.user.role_level == 1)
            {
                role_level.Text = "Petugas Perpustakaan";
                borrower.Visible = true;
                borrowing.Visible = true;

            }
            else if (UserData.user.role_level == 2)
            {
                role_level.Text = "Peminjam";
                borrower.Visible = false;
                borrowing.Visible = false;
            }

            var getBooks = from x in dc.books select x;
            int booksCount = getBooks.Count();
            books_table.RowCount = booksCount + 1;




            int currentRow = 1;
            foreach (var book in getBooks)
            {
                books_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65066F));
                this.genLabelInCell(currentRow: currentRow, labelText: currentRow.ToString(), labelPosition: 0);
                this.genLabelInCell(currentRow: currentRow, labelText: book.book_name, labelPosition: 1);
                this.genLabelInCell(currentRow: currentRow, labelText: book.book_issuer, labelPosition: 2);
                this.genLabelInCell(currentRow: currentRow, labelText: book.book_writer, labelPosition: 3);

                // gen button borrow and return



                this.genButtonInCell(currentRow: currentRow, buttonPosition: 4, bookId: book.book_id);

                currentRow++;
            } //  end foreach books
        }

        public void genLabelInCell(int currentRow, String labelText, int labelPosition)
        {
            System.Windows.Forms.Label labelInCell = new System.Windows.Forms.Label();







            labelInCell.AutoSize = true;
            labelInCell.Location = new System.Drawing.Point(3, 0);
            labelInCell.Name = "labelInCell" + currentRow;
            labelInCell.Size = new System.Drawing.Size(68, 35);
            labelInCell.TabIndex = 0;
            labelInCell.Text = labelText;


            books_table.Controls.Add(labelInCell, labelPosition, currentRow);
        }

        public itts_library.borrow selectFirstBorrow(int bookId)
        {
            int userId = UserData.user.user_id;

            return dc.borrows.FirstOrDefault(x => x.book_id == bookId && x.user_id == userId);
        }

        public void genButtonInCell(int currentRow, int buttonPosition, int bookId)
        {
            //
            int userId = UserData.user.user_id;



            System.Windows.Forms.Button borrowButton = new System.Windows.Forms.Button();

            borrowButton.Location = new System.Drawing.Point(3, 0);
            borrowButton.Name = "borrowButton" + currentRow;

            borrowButton.Size = new System.Drawing.Size(229, 59);
            borrowButton.TabIndex = 4;
            borrowButton.Text = "Pinjam";

            if (this.selectFirstBorrow(bookId: bookId) != null)
            {
                borrowButton.Text = "Kembalikan";
            }
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += (object sender, EventArgs e) =>
            {
                // Logika yang akan dijalankan saat tombol diklik
                // Misalnya, Anda dapat menambahkan logika untuk tombol "borrow" di sini


                if (borrowButton.Text == "Pinjam")
                {


                    // Membuat objek borrow baru
                    itts_library.borrow newBorrow = new itts_library.borrow
                    {
                        book_id = bookId,
                        user_id = userId
                    };

                    // Menambahkan objek borrow baru ke DataContext
                    dc.borrows.InsertOnSubmit(newBorrow);

                    // Menyimpan perubahan ke database
                    dc.SubmitChanges();

                    borrowButton.Text = "Kembalikan";

                }
                else if (borrowButton.Text == "Kembalikan")
                {

                    dc.borrows.DeleteOnSubmit(this.selectFirstBorrow(bookId));

                    // Menyimpan perubahan ke database
                    dc.SubmitChanges();
                    borrowButton.Text = "Pinjam";
                }
            };

            books_table.Controls.Add(borrowButton, buttonPosition, currentRow);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void books_table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void borrower_Click(object sender, EventArgs e)
        {
            Borrowers borrowers = new Borrowers();
            borrowers.Show();
            this.Hide();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void borrowing_Click(object sender, EventArgs e)
        {
            Borrowings borrowings = new Borrowings();
            borrowings.Show();
            this.Hide();
        }
    }
}
