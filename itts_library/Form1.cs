﻿using System;
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
    public partial class Form1 : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            
            var getUser = dc.users.Single(x => x.username == username.Text);
            Console.WriteLine("perhatikan baris di bawh ini");
            if(BCrypt.Net.BCrypt.EnhancedVerify(password.Text, getUser.password))
             {
                UserData.user = getUser;

                Books books = new Books();
                books.Show();
                this.Hide();
             } else
              {
             Console.WriteLine("password salah");
              }
            //Console.WriteLine(BCrypt.Net.BCrypt.EnhancedHashPassword("asdfasdf", 11));


        }
    }
}
