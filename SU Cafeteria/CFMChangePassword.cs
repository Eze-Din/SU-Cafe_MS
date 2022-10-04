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
    public partial class CFMChangePassword : Form
    {
        public CFMChangePassword()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void picCFMCPBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CFMLoginForm cFMLoginForm = new CFMLoginForm();
            cFMLoginForm.ShowDialog();
        }

        private void lCFMCPExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCFMChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT password FROM CFM WHERE Password='" + tbCFMOldPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count.ToString() == "1")
                {
                    if (tbCFMNewPassword1.Text == tbCFMNewPassword2.Text && tbCFMNewPassword1.Text.Trim() != String.Empty)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE CFM SET Password='" + tbCFMNewPassword2.Text + "' WHERE password = '" + tbCFMOldPassword.Text + "'", con);

                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Succesfully Updated!");
                        this.Hide();
                        CFMLoginForm cFMLogin = new CFMLoginForm();
                        cFMLogin.Show();
                    }
                    else if (tbCFMNewPassword1.Text != tbCFMNewPassword2.Text)
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

        private void lCFMCPClear_Click(object sender, EventArgs e)
        {
            tbCFMOldPassword.Clear();
            tbCFMNewPassword1.Clear();
            tbCFMNewPassword2.Clear();
            tbCFMOldPassword.Focus();
        }
    }
}
