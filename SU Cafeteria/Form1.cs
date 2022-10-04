using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU_Cafeteria
{
    public partial class LoginAs : Form
    {
        public LoginAs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAsFFM_Click(object sender, EventArgs e)
        {
            this.Hide();
            FFMLoginForm fFMLoginForm = new FFMLoginForm();
            fFMLoginForm.Show();
        }

        private void btnAsCFM_Click(object sender, EventArgs e)
        {
            this.Hide();
            CFMLoginForm cFMLoginForm = new CFMLoginForm();
            cFMLoginForm.Show();
        }

        private void LoginAs_Load(object sender, EventArgs e)
        {
            //btnAsFFM.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
        }
    }
}
