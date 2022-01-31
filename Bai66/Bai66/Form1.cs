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

namespace Bai66
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
        SqlDataAdapter adapter = null;
        DataSet ds;
        private void btNapDuLieu_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(sqlConn);
            adapter = new SqlDataAdapter("Select * from SanPham", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "SanPham");
            dgvSanPham.DataSource = ds.Tables["SanPham"];
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["SanPham"].NewRow();
            row["Ma"] = tbMa.Text;
            row["Ten"] = tbTen.Text;
            row["DonGia"] = tbGia.Text;
            row["MaDanhMuc"] = tbMaDM.Text;

            ds.Tables["SanPham"].Rows.Add(row);

            int kq = adapter.Update(ds.Tables["SanPham"]);
            if (kq > 0)
                btNapDuLieu.PerformClick();
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int vt = -1;
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds.Tables["SanPham"].Rows[vt];
            tbMa.Text = row["Ma"]+"";
            tbTen.Text = row["Ten"]+"";
            tbGia.Text = row["DonGia"]+"";
            tbMaDM.Text = row["MaDanhMuc"]+"";
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào");
            }
            DataRow row = ds.Tables["SanPham"].Rows[vt];
            row.BeginEdit();
            tbMa.Text = row["Ma"] + "";
            tbTen.Text = row["Ten"] + "";
            tbGia.Text = row["DonGia"] + "";
            tbMaDM.Text = row["MaDanhMuc"] + "";
            row.EndEdit();

            int kq = adapter.Update(ds.Tables["SanPHam"]);
            if (kq > 0)
            {
                btNapDuLieu.PerformClick();
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật bại"); 
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
             
        }
    }
}
