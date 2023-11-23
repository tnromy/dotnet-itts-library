using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace itts_library
{
    public partial class Books : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        public Dictionary<string, dynamic> user;


        public Books(Dictionary<string, dynamic> user)
        {
            InitializeComponent();
            this.user = user;
            full_name.Text = this.user["full_name"];

            var getBooks = from x in dc.books select x;
            int booksCount = getBooks.Count();
            books_table.RowCount = booksCount + 1;




            int currentRow = 1;
            foreach (var book in getBooks)
            {
                this.genLabelInCell(currentRow: currentRow, labelText: currentRow.ToString(), labelPosition: 0);
                this.genLabelInCell(currentRow: currentRow, labelText: book.book_name, labelPosition: 1);
                this.genLabelInCell(currentRow: currentRow, labelText: book.book_issuer, labelPosition: 2);
                this.genLabelInCell(currentRow: currentRow, labelText: book.book_writer, labelPosition: 3);
                this.genButtonInCell(bookId : book.book_id);

                currentRow++;
            } //  end foreach books
        }

        public void genLabelInCell(int currentRow, String labelText, int labelPosition)
        {
            System.Windows.Forms.Label labelInCell = new System.Windows.Forms.Label();



            books_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65066F));



            labelInCell.AutoSize = true;
            labelInCell.Location = new System.Drawing.Point(3, 0);
            labelInCell.Name = "labelInCell" + currentRow;
            labelInCell.Size = new System.Drawing.Size(68, 35);
            labelInCell.TabIndex = 0;
            labelInCell.Text = labelText;


            books_table.Controls.Add(labelInCell, labelPosition, currentRow);
        }

        public void genButtonInCell(int bookId)
        {
            //
            var getBorrow = dc.borrows.SingleOrDefault(x => x.book_id == bookId);

            if (getBorrow != null)
            {
                Console.WriteLine("terpinjam");
            }
            else
            {
                Console.WriteLine("belum");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
