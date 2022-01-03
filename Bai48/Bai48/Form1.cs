using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sanPhamLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sanPhamLV.SelectedItems.Count > 0)
            {
                ListViewItem lvi = sanPhamLV.SelectedItems[0];
                string ma = lvi.SubItems[0].Text;
                string ten = lvi.SubItems[1].Text;
                int gia = int.Parse(lvi.SubItems[2].Text);

                donGiaTB.Text = gia+"";
                maTB.Text = ma;
                sanPhamTB.Text = ten;
            }
        }

        private void sanPhamLV_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != -1)
            {
                ColumnHeader col = sanPhamLV.Columns[e.Column];
                MessageBox.Show("Bạn click cột: " + col.Text);
            }
        }

        private void themSanPhamBt_Click(object sender, EventArgs e)
        {
            // Tạo 1 ListViewItem (tạo 1 dòng):
            ListViewItem lvi = new ListViewItem(maTB.Text);
            // Thêm cột còn lại:
            lvi.SubItems.Add(sanPhamTB.Text);
            lvi.SubItems.Add(donGiaTB.Text);
            //Đưa lvi lên giao diện:
            sanPhamLV.Items.Add(lvi);    
        }

        private void xoaBt_Click(object sender, EventArgs e)
        {
            if (sanPhamLV.SelectedItems.Count > 0)
            {
                sanPhamLV.Items.Remove(sanPhamLV.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng");
            }
        }

        private void suaBt_Click(object sender, EventArgs e)
        {
            if (sanPhamLV.SelectedItems.Count > 0)
            {
                ListViewItem lvi = sanPhamLV.SelectedItems[0];
                lvi.SubItems[0].Text = maTB.Text;
                lvi.SubItems[1].Text = sanPhamTB.Text;
                lvi.SubItems[2].Text = donGiaTB.Text;
            }
        }
    }
}
