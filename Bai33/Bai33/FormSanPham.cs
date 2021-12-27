using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai33
{
    public partial class FormSanPham : Form
    {
        private static List<DanhMuc> danhSachDM = new List<DanhMuc>();
        List<SanPham> danhSachSP = new List<SanPham>();
        public FormSanPham()
        {
            InitializeComponent();
        }

        internal static List<DanhMuc> DanhSachDM { get => danhSachDM; set => danhSachDM = value; }

        private void quanLyDMBt_Click(object sender, EventArgs e)
        {
            FormDanhMuc formDM = new FormDanhMuc();
            FormDanhMuc.CoThayDoi = false;
            if (formDM.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhMucLenComboBox();
            }
        }

        private void HienThiDanhMucLenComboBox()
        {
            danhMucCB.Items.Clear();
            foreach (DanhMuc dm in danhSachDM)
                danhMucCB.Items.Add(dm);
        }

        private void luuBt_Click(object sender, EventArgs e)
        {
            if (danhMucCB.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn danh mục");
                return;
            }
            DanhMuc dm = danhMucCB.SelectedItem as DanhMuc;
            SanPham sp = new SanPham();
            sp.MaSP = maSPTB.Text;
            sp.TenSP = tenSPTB.Text;
            sp.DonGia = double.Parse(donGiaTB.Text);
            sp.XuatXu = xuatXuTB.Text;
            sp.HanDung = hanSDDTP.Value;
            dm.ThemSanPham(sp);
            danhSachSP.Add(sp);

            HienThiSanPhamLenListBox();

            XoaTrangChiTietSanPham();
        }

        void XoaTrangChiTietSanPham()
        {
            maSPTB.Text = "";
            tenSPTB.Text = "";
            donGiaTB.Text = "";
            xuatXuTB.Text = "";
            maSPTB.Focus();
        }

        void HienThiSanPhamLenListBox()
        {
            danhSachLB.Items.Clear();
            foreach (SanPham sp in danhSachSP)
                danhSachLB.Items.Add(sp);
        }

        private void danhSachLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danhSachLB.SelectedIndex == -1)
                return;
            SanPham sp = danhSachLB.SelectedItem as SanPham;
            danhMucCB.Text = sp.Nhom.TenDM;
            maSPTB.Text = sp.MaSP  ;
            tenSPTB.Text = sp.TenSP;
            donGiaTB.Text = sp.DonGia+"";
            xuatXuTB.Text = sp.XuatXu;
            hanSDDTP.Value = sp.HanDung;
        }

        private void xoaBt_Click(object sender, EventArgs e)
        {
            if (danhSachLB.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào để xóa");
                return;
            }
            SanPham sp = danhSachLB.SelectedItem as SanPham;
            DialogResult ret = MessageBox.Show("Bạn có muốn xóa ["+sp.TenSP+"] không", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ret == DialogResult.Yes)
            {
                danhSachSP.Remove(sp);
                HienThiSanPhamLenListBox();
                XoaTrangChiTietSanPham();
            }
            
        }
    }
}
