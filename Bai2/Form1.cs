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
using System.Data.Sql;


namespace Bai2
{
    public partial class Form1 : Form
    {
        //string strketnoi = @"Data Source=A209PC02;Initial Catalog=QL_KHOA; Integrated Security=True";
        //SqlConnection sqlketnoi = null;
        KetNoi kn = new KetNoi();
        SqlConnection sqlketnoi;
        public Form1()
        {
            InitializeComponent();
            //try
            //{
            //    if (sqlketnoi == null)
            //    {
            //        sqlketnoi = new SqlConnection(strketnoi);
            //    }
            //    if (sqlketnoi.State == ConnectionState.Closed)
            //    {
            //        sqlketnoi.Open();
            //        MessageBox.Show("Ket noi thanh cong");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            sqlketnoi = kn.connect;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadKhoa_ComBoBox()
        {
            sqlketnoi.Open();
            string selectstring = "select * from dbo.Khoa";
            SqlCommand cmd = new SqlCommand(selectstring,sqlketnoi);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ccb_Khoa.Items.Add(rd["MaKhoa"].ToString());
            }
            rd.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadKhoa_ComBoBox();
        }
    }
}
