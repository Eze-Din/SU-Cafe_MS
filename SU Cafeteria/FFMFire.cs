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
    public partial class FFMFire : Form
    {
        public FFMFire()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void btnEmpSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Employees where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbFireID.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmp.DataSource = dt;
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

        private void btnEmpShow_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employees", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmp.DataSource = dt;

            con.Close();
        }

        private void lEmpClear_Click(object sender, EventArgs e)
        {
            tbFireID.Clear();
            tbFireID.Focus();
        }

        private void btnEmpFire_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Employees where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbFireID.Text));
                cmd.ExecuteNonQuery();

                
                MessageBox.Show("Succusfully Fired!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEmpCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
