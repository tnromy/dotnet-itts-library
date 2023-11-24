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
    public partial class Borrowers : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        public Borrowers()
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

            var getBorrowers = dc.users.Where(x => x.role_level == 2).ToList();

            int borrowersCount = getBorrowers.Count();
            borrowers_table.RowCount = borrowersCount + 1;




            int currentRow = 1;
            foreach (var borrower in getBorrowers)
            {
                this.borrowers_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this.genLabelInCell(currentRow: currentRow, labelText: currentRow.ToString(), labelPosition: 0);
                this.genLabelInCell(currentRow: currentRow, labelText: borrower.full_name, labelPosition: 1);
                this.genLabelInCell(currentRow: currentRow, labelText: borrower.username, labelPosition: 2);

                // gen button borrow and return




                currentRow++;
            } //  end foreach borrowers



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


            borrowers_table.Controls.Add(labelInCell, labelPosition, currentRow);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_borrower_Click(object sender, EventArgs e)
        {
            AddBorrower addBorrower = new AddBorrower();
            addBorrower.Show();
            this.Hide();
        }
    }
}
