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
    public partial class FFMCheck : Form
    {
        public FFMCheck()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void btnInpAccept_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Inputs VALUES (@ID, @Name, @Quantity, @Supplier, @Date)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbInpID.Text));
                cmd.Parameters.AddWithValue("@Name", tbInpName.Text);
                cmd.Parameters.AddWithValue("@Quantity", tbInpQuantity.Text);
                cmd.Parameters.AddWithValue("@Supplier", tbInpSupplier.Text);
                cmd.Parameters.AddWithValue("@Date", tbInpDate.Text);
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

        private void btnInpCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lInpClear_Click(object sender, EventArgs e)
        {
            tbInpID.Clear();
            tbInpName.Clear();
            tbInpQuantity.Clear();
            tbInpSupplier.Clear();
            tbInpDate.Clear();
            tbInpID.Focus();
        }

        private void btnInpSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Inputs where ID=@ID", con);
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

        private void btnInpUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Inputs SET Name=@Name, Quantity=@Quantity, Supplier=@Supplier, Date=@Date WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbInpID.Text));
                cmd.Parameters.AddWithValue("@Name", tbInpName.Text);
                cmd.Parameters.AddWithValue("@Quantity", tbInpQuantity.Text);
                cmd.Parameters.AddWithValue("@Supplier", tbInpSupplier.Text);
                cmd.Parameters.AddWithValue("@Date", tbInpDate.Text);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Succusfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand cmd = new SqlCommand("Delete Inputs where ID=@ID", con);
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

        private void FFMCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
