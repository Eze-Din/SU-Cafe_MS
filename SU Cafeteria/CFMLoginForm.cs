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
    public partial class CFMLoginForm : Form
    {
        public CFMLoginForm()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void picCFMBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAs loginAs = new LoginAs();
            loginAs.Show();
        }

        private void lCFMExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llCFMChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CFMChangePassword cFMChangePassword = new CFMChangePassword();
            cFMChangePassword.Show();
        }

        private void btnCFMLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = tbCFMUsername.Text;
            password = tbCFMPassword.Text;

            try
            {
                string querry = "SELECT * FROM CFM WHERE username COLLATE Latin1_General_CS_AS = '" + tbCFMUsername.Text + "' AND password COLLATE Latin1_General_CS_AS = '" + tbCFMPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = tbCFMUsername.Text;
                    password = tbCFMPassword.Text;

                    CFM cFM = new CFM();
                    cFM.Show();
                    this.Hide();
                }
                else if(tbCFMUsername.Text.Trim() == String.Empty || tbCFMPassword.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Fill both fields!", "Unfilled box", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCFMPassword.Clear();
                    tbCFMUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Fill again correctly!", "Wrong attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCFMUsername.Clear();
                    tbCFMPassword.Clear();
                    tbCFMUsername.Focus();
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

        private void lCFMClear_Click(object sender, EventArgs e)
        {
            tbCFMUsername.Clear();
            tbCFMPassword.Clear();
            tbCFMUsername.Focus();
        }

        private void CFMLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
