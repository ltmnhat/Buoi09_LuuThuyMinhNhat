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

namespace Bai1
{
    public partial class Form1 : Form
    {
        string strketnoi = @"Data Source=A209PC02;Initial Catalog=QL_KHOA; Integrated Security=True";
        SqlConnection sqlketnoi = null;
        public Form1()
        {
            InitializeComponent();
            try
            {
                if (sqlketnoi == null)
                {
                    sqlketnoi = new SqlConnection(strketnoi);
                }
                if (sqlketnoi.State == ConnectionState.Closed)
                {
                    sqlketnoi.Open();
                    MessageBox.Show("Ket noi thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(KT_MaKhoa(txtMaKhoa.Text)==true)
                {
                    sqlketnoi.Open();
                    string add = "insert into dbo.Khoa values ('" + txtMaKhoa.Text + "','" + txtTenKhoa.Text + "')";
                    SqlCommand cmd = new SqlCommand(add, sqlketnoi);
                    cmd.ExecuteNonQuery();
                    sqlketnoi.Close();
                    MessageBox.Show("Them thanh cong!");
                }
                else {MessageBox.Show("Trung ma khoa");}
            }
            catch(Exception ex)
            {
                MessageBox.Show("That Bai");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dele = "delete from dbo.Khoa where MaKhoa=" + "'" + txtMaKhoa.Text + "'";
            SqlCommand cmd = new SqlCommand(dele, sqlketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoa thanh cong!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string upda = "update dbo.Khoa set TenKhoa='" + txtTenKhoa.Text + "'" + " where MaKhoa=" + txtMaKhoa.Text;
            SqlCommand cmd = new SqlCommand(upda, sqlketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sua thanh cong!");
        }
        bool KT_MaKhoa(string ma)
        {
            try
            {
                //mo ket noi
                sqlketnoi.Open();
                string selectstring = "select count(*) from dbo.Khoa where MaKhoa='" + ma + "'";
                SqlCommand cmd = new SqlCommand(selectstring, sqlketnoi);
                int count = (int)cmd.ExecuteNonQuery();
                sqlketnoi.Close();
                if (count >= 1)
                    return false;
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
