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
    public partial class FFM : Form
    {
        public FFM()
        {
            InitializeComponent();
        }

        public void loadform (object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void panelMain_Paint(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            loadform( new FFMDashboard());
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            
            loadform(new FFMHire());
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            
            loadform(new FFMFire());
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            
            loadform(new FFMCard());
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            loadform(new FFMCheck());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FFMLoginForm fFMLoginForm = new FFMLoginForm();
            fFMLoginForm.Show();
        }
    }
}
