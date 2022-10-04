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
    public partial class CFMElect : Form
    {
        public CFMElect()
        {
            InitializeComponent();
        }

        public SqlConnection con = new SqlConnection("Data Source=ALZAFARTECH;Initial Catalog=SU_Cafe_Management;Integrated Security=True;Pooling=False");
        private void CFMElect_Load(object sender, EventArgs e)
        {

        }

        private void lInpClear_Click(object sender, EventArgs e)
        {
            tbMemID.Clear();
            tbMemName.Clear();
            tbMemPhone.Clear();
            tbMemPos.Clear();
            tbMemCollege.Clear();
            tbMemDep.Clear();
            tbDate.Clear();
            tbMemID.Focus();
        }

        private void btnElect_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CFMembers VALUES (@ID, @Name, @Phone, @Position, @College, @Department, @Date)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(tbMemID.Text));
                cmd.Parameters.AddWithValue("@Name", tbMemName.Text);
                cmd.Parameters.AddWithValue("@Phone", tbMemPhone.Text);
                cmd.Parameters.AddWithValue("@Position", tbMemPos.Text);
                cmd.Parameters.AddWithValue("@College", tbMemCollege.Text);
                cmd.Parameters.AddWithValue("@Department", tbMemDep.Text);
                cmd.Parameters.AddWithValue("@Date", tbDate.Text);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();


                MessageBox.Show(i + " Succusfully Elected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
