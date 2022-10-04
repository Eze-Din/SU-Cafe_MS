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
    public partial class FFMChangePassword : Form
    {
        public FFMChangePassword()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void lChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbFFMUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FFMChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void picFFMCPBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FFMLoginForm fFMLoginForm = new FFMLoginForm();
            fFMLoginForm.ShowDialog();
        }

        private void lFFMCPExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFFMChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT password FROM FFM WHERE Password='" + tbFFMOldPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count.ToString() == "1")
                {
                    if (tbFFMNewPassword1.Text == tbFFMNewPassword2.Text && tbFFMNewPassword1.Text.Trim() != String.Empty)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE FFM SET Password='" + tbFFMNewPassword2.Text + "' WHERE password = '" + tbFFMOldPassword.Text + "'", con);

                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Succesfully Updated!");
                        this.Hide();
                        FFMLoginForm fFMLogin = new FFMLoginForm();
                        fFMLogin.Show();
                    }
                    else if(tbFFMNewPassword1.Text != tbFFMNewPassword2.Text)
                    {
                        MessageBox.Show("Please, match the new password!");
                    }
                    else
                    {
                        MessageBox.Show("Please, fill the new password!");
                    }

                }
                else
                {
                    MessageBox.Show("Your password is incorrect!");
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void lFFMCPClear_Click(object sender, EventArgs e)
        {
            tbFFMOldPassword.Clear();
            tbFFMNewPassword1.Clear();
            tbFFMNewPassword2.Clear();

            tbFFMOldPassword.Focus();
        }
    }
}
