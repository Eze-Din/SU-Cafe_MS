using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU_Cafeteria
{
    public partial class FFMLoginForm : Form
    {
        public FFMLoginForm()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void FFMLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lLogin_Click(object sender, EventArgs e)
        {

        }

        private void lFFMExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAs loginAs = new LoginAs();
            loginAs.Show();
        }

        private void tbFFMUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void llFFMChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FFMChangePassword fFMChangePassword = new FFMChangePassword();
            fFMChangePassword.Show();
        }

        private void lFFMClear_Click(object sender, EventArgs e)
        {
            tbFFMUsername.Clear();
            tbFFMPassword.Clear();
            tbFFMUsername.Focus();
        }

        private void btnFFMLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = tbFFMUsername.Text;
            password = tbFFMPassword.Text;

            try
            {
                string querry = "SELECT * FROM FFM WHERE username COLLATE Latin1_General_CS_AS = '" + tbFFMUsername.Text + "' AND password COLLATE Latin1_General_CS_AS = '" + tbFFMPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = tbFFMUsername.Text;
                    password = tbFFMPassword.Text;

                    FFM fFM = new FFM();
                    fFM.Show();
                    this.Hide();
                }
                else if (tbFFMUsername.Text.Trim() == String.Empty || tbFFMPassword.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Fill both fields!", "Unfilled box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbFFMPassword.Clear();
                    tbFFMUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Fill again correctly!", "Wrong attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbFFMUsername.Clear();
                    tbFFMPassword.Clear();
                    tbFFMUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Something bad happened!");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
