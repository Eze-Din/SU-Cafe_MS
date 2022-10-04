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
    public partial class CFMFire : Form
    {
        public CFMFire()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void CFMFire_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CFMembers where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbMemID.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMem.DataSource = dt;
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from CFMembers", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMem.DataSource = dt;

            con.Close();
        }

        private void lClear_Click(object sender, EventArgs e)
        {
            tbMemID.Clear();
            tbMemID.Focus();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete CFMembers where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbMemID.Text));
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
