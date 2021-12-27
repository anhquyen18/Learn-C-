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
    public partial class FormDanhMuc : Form
    {
        public static bool CoThayDoi = false;
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void LuuBt_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.MaDM = maDMTB.Text;
            dm.TenDM = tenDMTB.Text;
            FormSanPham.DanhSachDM.Add(dm);

            HienThiDanhMucLenListBox();

            maDMTB.Text = "";
            tenDMTB.Text = ""; 
            maDMTB.Focus();
            CoThayDoi = true;
        }

        public void HienThiDanhMucLenListBox()
        {
            danhMucLB.Items.Clear();
            foreach(DanhMuc dm in FormSanPham.DanhSachDM)
            {
                danhMucLB.Items.Add(dm);
            }
        }

        private void danhMucLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danhMucLB.SelectedIndex != -1)
            {
                DanhMuc dm = danhMucLB.SelectedItem as DanhMuc;
                maDMTB.Text = dm.MaDM;
                tenDMTB.Text = dm.TenDM;
            }
        }

        private void XoaBt_Click(object sender, EventArgs e)
        {
            if (danhMucLB.SelectedIndex != -1)
            {
                DanhMuc dm = danhMucLB.SelectedItem as DanhMuc;
                danhMucLB.Items.Remove(dm);
            }
        }

        private void dongBt_Click(object sender, EventArgs e)
        {
            if (CoThayDoi == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }
    }
}
