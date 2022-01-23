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
namespace Bai61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn = 
            "SERVER=PAIDEPTRAI\\SQLEXPRESS; Database = CSDLTest; Integrated Security = True"; 
        private void btDemSoSanPham_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(*) from SanPham";
            command.Connection = conn;

            object data = command.ExecuteScalar();
            int n = (int)data;
            lbTest.Text = "Có " + n + " sản phẩm";

        }

        private void btXemChiTiet_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (conn == null)
                    conn = new SqlConnection(sqlConn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from SanPham where ma=" + tbNhapMa.Text;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) // Có dữ liệu
                {
                    tbMaSP.Text = reader.GetInt32(0) + "";
                    tbTenSP.Text = reader.GetString(1);
                    tbGiaSP.Text = reader.GetInt32(2) + "";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                if (ex is FormatException||ex is OverflowException)
                {
                    MessageBox.Show("Anh Quyền đẹp trai vcl");
                }
            
            }
            
        }

        private void btXemChiTiet2_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where ma=@ma";
            command.Connection = conn;

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Int);
            parMa.Value = tbNhapMa.Text;
            command.Parameters.Add(parMa);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tbNhapMa.Text = reader.GetInt32(0) + "";
                tbTenSP.Text = reader.GetString(1);
                tbGiaSP.Text = reader.GetInt32(2) + "";
            }
            reader.Close();
        }

        private void btHienThiDanhSach_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            lvSanPham.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + "");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + "");

                lvSanPham.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
