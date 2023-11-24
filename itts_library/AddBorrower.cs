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
    public partial class AddBorrower : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        public AddBorrower()
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
        }
    }
}
