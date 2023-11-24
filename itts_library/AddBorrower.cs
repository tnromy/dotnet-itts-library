using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            DataClassesDataContext dc = new DataClassesDataContext();

            string inputUsername = username_input.Text;

            // Cek apakah sudah ada user dengan username yang sama
            var existingUser = dc.users.FirstOrDefault(u => u.username == inputUsername);

            if (existingUser == null)
            {
                // Jika belum ada, tambahkan user baru
                itts_library.user userInput = new itts_library.user
                {
                    full_name = full_name_input.Text,
                    username = inputUsername,
                    password = BCrypt.Net.BCrypt.EnhancedHashPassword(password_input.Text, 11),
                    role_level = 2
                };

                // Tambahkan user baru ke tabel
                dc.users.InsertOnSubmit(userInput);
                dc.SubmitChanges();

                // Informasi bahwa user telah ditambahkan
                Borrowers borrowers = new Borrowers();
                borrowers.Show();
                this.Hide();
            }
            else
            {
                // Jika sudah ada, berikan pesan kesalahan atau ambil tindakan yang sesuai
                Console.WriteLine("Username sudah digunakan. Pilih username lain.");
            }

        }
    }
}
