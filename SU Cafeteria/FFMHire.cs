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
    public partial class FFMHire : Form
    {
        public FFMHire()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void FFMHire_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpHire_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees VALUES (@ID, @Name, @Phone, @Address, @Hiredate, @Payment, @Paydate)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbEmpID.Text));
                cmd.Parameters.AddWithValue("@Name", tbEmpName.Text);
                cmd.Parameters.AddWithValue("@Phone", int.Parse(tbEmpPhone.Text));
                cmd.Parameters.AddWithValue("@Address", tbEmpAddress.Text);
                cmd.Parameters.AddWithValue("@Hiredate", tbEmpDate.Text);
                cmd.Parameters.AddWithValue("@Payment", tbEmpPay.Text);
                cmd.Parameters.AddWithValue("@Paydate", tbEmpPayDate.Text);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();

                
                MessageBox.Show(i + " Succusfully Hired!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEmpPay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employees SET Payment=@Payment, Paydate=@Paydate WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbEmpID.Text));
                cmd.Parameters.AddWithValue("@Payment", tbEmpPay.Text);
                cmd.Parameters.AddWithValue("@Paydate", tbEmpPayDate.Text);
                cmd.ExecuteNonQuery();

                
                MessageBox.Show("Succusfully Payed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lEmpClear_Click(object sender, EventArgs e)
        {
            tbEmpID.Clear();
            tbEmpName.Clear();
            tbEmpPhone.Clear();
            tbEmpAddress.Clear();
            tbEmpDate.Clear();
            tbEmpID.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            tbEmpPay.Clear();
            tbEmpPayDate.Clear();
            tbEmpID.Focus();
        }

        private void btnEmpCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
