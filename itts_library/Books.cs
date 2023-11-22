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
    public partial class Books : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        public Dictionary<string, dynamic> user;

        public Books(Dictionary<string, dynamic> user)
        {
            InitializeComponent();
            this.user = user;
            full_name.Text = this.user["full_name"];
        }
    }
}
