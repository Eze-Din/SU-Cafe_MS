using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SU_Cafeteria
{
    public partial class CFMCheck : Form
    {
        public CFMCheck()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbInp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CFMCheck_Load(object sender, EventArgs e)
        {
            cbInp.Items.Add("Breakfast");
            cbInp.Items.Add("Lunch");
            cbInp.Items.Add("Dinner");
            cbInp.Items.Add("All");
        }

        private void btnInpAccept_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CFMInputs VALUES (@ID, @Name, @Quantity, @Date, @Type)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbInpID.Text));
                cmd.Parameters.AddWithValue("@Name", tbInpName.Text);
                cmd.Parameters.AddWithValue("@Quantity", tbInpQuantity.Text);
                cmd.Parameters.AddWithValue("@Date", tbInpDate.Text);
                cmd.Parameters.AddWithValue("@Type", cbInp.Text);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();


                MessageBox.Show(i + " Succusfully Accepted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnInpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete CFMInputs where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbInpID.Text));
                cmd.ExecuteNonQuery();


                MessageBox.Show("Succusfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnInpCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInpSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from CFMInputs where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbInpID.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInp.DataSource = dt;
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

        private void lInpClear_Click(object sender, EventArgs e)
        {
            tbInpID.Clear();
            tbInpName.Clear();
            tbInpQuantity.Clear();
            tbInpDate.Clear();
            tbInpID.Focus();
        }
    }
}
