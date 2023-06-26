﻿using Guna.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greeenEats
{

    public partial class signup : Form
    {
        public string std_username;
        public string std_email;
        public int std_phoneNo;
        public string std_password;
        public string std_confirmPassword;

        public signup()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            loginpage objl = new loginpage();
            objl.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_acc_btn_Click(object sender, EventArgs e)
        {
            loginpage objlog = new loginpage();
            objlog.Show();
            this.Hide();
        }

        private void create_acc_Click(object sender, EventArgs e)
        {
            std_username = entered_username.Text;
            std_email = entered_stdEmail.Text;
            std_phoneNo = Convert.ToInt32(entered_phoneNumber.Text);
            std_password = entered_stdPassword.Text;
            std_confirmPassword = entered_stdPassword.Text;

            starting_form obj_signup = new starting_form();
            obj_signup.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void signupAsStaff_btn_Click(object sender, EventArgs e)
        {
            staff_signup objstaffup = new staff_signup();
            objstaffup.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            starting_form objs = new starting_form();
            objs.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
