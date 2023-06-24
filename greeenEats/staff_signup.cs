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
    public partial class staff_signup : Form
    {
        public staff_signup()
        {
            InitializeComponent();
        }

        private void create_acc_Click(object sender, EventArgs e)
        {

        }

        private void staff_create_btn_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            signup objs = new signup();
            objs.Show();
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
