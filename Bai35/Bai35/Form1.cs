using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai35
{
    public partial class Form1 : Form
    {
        DanhSachKhachHang database = new DanhSachKhachHang();
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Ten = tbTenKH.Text;
            kh.SoLuongMua = int.Parse(tbSoLuongSach.Text);
            kh.LaSinhVien = cbLaSinhVien.Checked;
            database.Mua(kh);

            lbThanhTien.Text = kh.TinhTien + "";
        }

        private void btTiep_Click(object sender, EventArgs e)
        {
            tbTenKH.Text = "";
            tbSoLuongSach.Text = "";
            cbLaSinhVien.Checked = false;
            lbThanhTien.Text = "";
            tbTenKH.Focus();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            tbTongSoKhach.Text = database.TongSoKhachHang + "";
            tbTongDoanhThu.Text = database.TongDoanhThu + "";
            tbTongSoKhachSV.Text = database.TongSoKhachHangSV + "";

        }

        private void tbTongSoKhach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form formKH = new Form();
            formKH.Width = formKH.Height = 300;
            ListBox listKH = new ListBox();
            formKH.Controls.Add(listKH);
            listKH.Dock = DockStyle.Fill;
            foreach (KhachHang kh in database.KH)
            {
                listKH.Items.Add(kh.Ten);
            }
            formKH.StartPosition = FormStartPosition.CenterParent;
            formKH.Show();
        }

        private void tbTongSoKhachSV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form formKH = new Form();
            formKH.Width = formKH.Height = 300;
            ListBox listKH = new ListBox();
            formKH.Controls.Add(listKH);
            listKH.Dock = DockStyle.Fill;
            foreach (KhachHang kh in database.KH)
            {
                if (kh.LaSinhVien == true)
                    listKH.Items.Add(kh.Ten);
            }
            formKH.StartPosition = FormStartPosition.CenterParent;
            formKH.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }

        private void cbLaSinhVien_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
