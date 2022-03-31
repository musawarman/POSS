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

namespace POSS
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            Display();
            //MessageBox.Show("Test");
        }
        void Display()
        {
            try
            {
                Koneksi.Connect.Open();
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("Select Username, Password from tbUser", Koneksi.Connect);
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                DataTable data = new DataTable();
                sqlDisplay.Fill(data);
                dgData.DataSource = data;
                Koneksi.Connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Koneksi.Connect.Open();
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("Select Username, Password from tbUser where username like '%" + textBox1.Text + "%'", Koneksi.Connect);
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                DataTable data = new DataTable();
                sqlDisplay.Fill(data);
                dgData.DataSource = data;
                txtUsername.DataBindings.Add("Text", data, "username");
                txtPassword.DataBindings.Add("Text", data, "password");
                txtUsername.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                Koneksi.Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.Connect.Open();
                SqlDataAdapter sqlDisplay = new SqlDataAdapter("Select Username, Password from tbUser where username like '%" + textBox1.Text + "%'", Koneksi.Connect);
                sqlDisplay.SelectCommand.ExecuteNonQuery();
                DataTable data = new DataTable();
                sqlDisplay.Fill(data);
                dgData.DataSource = data;
                txtUsername.DataBindings.Add("Text", data, "username");
                txtUsername.DataBindings.Clear();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                Koneksi.Connect.Close();
            }

        }
    }
}
