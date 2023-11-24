using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itts_library
{
    public partial class Borrowings : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        public Borrowings()
        {
            InitializeComponent();
           
            full_name.Text = UserData.user.full_name;
            if (UserData.user.role_level == 1)
            {
                role_level.Text = "Petugas Perpustakaan";


            }
            else if (UserData.user.role_level == 2)
            {
                role_level.Text = "Peminjam";

            }
            var getBorrowings = from borrow in dc.borrows
                                join user in dc.users on borrow.user_id equals user.user_id
                                join book in dc.books on borrow.book_id equals book.book_id
                                select new
                                {
                                    borrowId = borrow.borrow_id,
                                    username = user.username,
                                    bookName = book.book_name,
                                    // ... tambahkan properti lain yang ingin Anda ambil
                                };
            int borrowingsCount = getBorrowings.Count();
            borrowings_table.RowCount = borrowingsCount + 1;




            int currentRow = 1;
            foreach (var borrowing in getBorrowings)
            {
                this.borrowings_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.genLabelInCell(currentRow: currentRow, labelText: currentRow.ToString(), labelPosition: 0);
                this.genLabelInCell(currentRow: currentRow, labelText: borrowing.bookName, labelPosition: 1);
                this.genLabelInCell(currentRow: currentRow, labelText: borrowing.username, labelPosition: 2);

                // gen button borrow and return




                currentRow++;
            } //  end foreach borrowings
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


            borrowings_table.Controls.Add(labelInCell, labelPosition, currentRow);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
