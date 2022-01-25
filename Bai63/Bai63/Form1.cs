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
namespace Bai63
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
        int madm = -1;
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhMuc();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "update SanPham set Ten = N'" + tbTen.Text 
                + "', DonGia=" + tbGia.Text + " where Ma = " + tbMa.Text;
            command.CommandText = sql;
            command.Connection = conn;
            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiSanPhamTheoMaDanhMuc(madm);
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            
        }

        private void HienThiDanhMuc()
        {
            if (conn == null)
                conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from DanhMuc";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            cbbDanhMuc.Items.Clear();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                cbbDanhMuc.Items.Add(ma + "-" + ten);
            }
            reader.Close();
        }

        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDanhMuc.SelectedIndex == -1) return;
            string line = cbbDanhMuc.SelectedItem + "";
            string[] arr = line.Split('-');
            int madm = int.Parse(arr[0]);
            HienThiSanPhamTheoMaDanhMuc(madm);
            
        }

        private void HienThiSanPhamTheoMaDanhMuc(int madm)
        {
            if (conn == null)
                conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham where MaDanhMuc = "+madm;
            command.Connection = conn;
            lvSanPham.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + "");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + "");

                lvSanPham.Items.Add(lvi);
            }
            reader.Close();

        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            tbMa.Text = lvi.SubItems[0].Text;
            tbTen.Text = lvi.SubItems[1].Text;
            tbGia.Text = lvi.SubItems[2].Text;
        }

        private void btCapNhat2_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "update SanPham set Ten=@ten, DonGia=@gia where Ma=@Ma";
            command.CommandText = sql;
            command.Connection = conn;

            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = tbTen.Text;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = tbGia.Text;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = tbMa.Text;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiSanPhamTheoMaDanhMuc(madm);
                MessageBox.Show("Cập nhật được rồi đó");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
