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
    public partial class FFMCard : Form
    {
        public FFMCard()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void FFMCard_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Students VALUES (@ID, @Cardnum, @Name, @Phone, @College, @Dep, @Date)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbStdID.Text));
                cmd.Parameters.AddWithValue("@Cardnum", int.Parse(tbStdCardNum.Text));
                cmd.Parameters.AddWithValue("@Name", tbStdName.Text);
                cmd.Parameters.AddWithValue("@Phone", tbStdPhone.Text);
                cmd.Parameters.AddWithValue("@College", tbStdCollege.Text);
                cmd.Parameters.AddWithValue("@Dep", tbStdDep.Text);
                cmd.Parameters.AddWithValue("@Date", tbStdDate.Text);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();


                MessageBox.Show(i + " Succusfully Registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please, fill correctly!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                con.Close();
            }
        }

        private void lStdClear_Click(object sender, EventArgs e)
        {
            tbStdID.Clear();
            tbStdCardNum.Clear();
            tbStdName.Clear();
            tbStdPhone.Clear();
            tbStdCollege.Clear();
            tbStdDep.Clear();
            tbStdDate.Clear();
            tbStdID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Students where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbStdID.Text));
                cmd.ExecuteNonQuery();


                MessageBox.Show("Succusfully Removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please, fill correct ID!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
