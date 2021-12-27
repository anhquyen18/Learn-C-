using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai30
{
    public partial class BaiTap : Form
    {
        public BaiTap()
        {
            InitializeComponent();
        }

        private void capNhatBt_Click(object sender, EventArgs e)
        {
            tenRongEr.SetError(nhapTenTB, "");


            if (nhapTenTB.Text == "")
            {
            tenRongEr.SetError(nhapTenTB, "Sao để trống thế thằng ngu");
            }
            else
            {
                try
                {
                if (chonLopCB.SelectedItem.Equals("Lớp A"))
                {
                    lopALB.Items.Add(nhapTenTB.Text);
                }
                else if (chonLopCB.SelectedItem.Equals("Lớp B"))
                {
                    lopBLB.Items.Add(nhapTenTB.Text);
                }
                }catch(Exception Loi)
                {
                    MessageBox.Show("Chọn lớp muốn thêm đi đã thằng ngu, sống vội thế!", "Lỗi rồi");
                }
            }
        }

        private void xoaABt_Click(object sender, EventArgs e)
        {
            while (lopALB.SelectedIndices.Count > 0)
            {
                lopALB.Items.RemoveAt(lopALB.SelectedIndices[0]);
            }
        }

        private void xoaBBt_Click(object sender, EventArgs e)
        {
            while (lopBLB.SelectedIndices.Count > 0)
            {
                lopBLB.Items.RemoveAt(lopALB.SelectedIndices[0]);
            }
        }

        private void chuyenABt_Click(object sender, EventArgs e)
        {

            while (lopALB.SelectedIndices.Count > 0)
            {
                lopBLB.Items.Add(lopALB.SelectedItems[0]);
                lopALB.Items.RemoveAt(lopALB.SelectedIndices[0]);
            }
        }

        private void chuyenBBt_Click(object sender, EventArgs e)
        {
            while (lopBLB.SelectedIndices.Count > 0)
            {
                lopALB.Items.Add(lopBLB.SelectedItems[0]);
                lopBLB.Items.RemoveAt(lopBLB.SelectedIndices[0]);
            }

        }

        private void chuyenToanBoABt_Click(object sender, EventArgs e)
        {
            while (lopALB.Items.Count > 0)
            {
                lopBLB.Items.Add(lopALB.Items[0]);
                lopALB.Items.RemoveAt(0);
            }
        }

        private void chuyenToanBoBBt_Click(object sender, EventArgs e)
        {
            while (lopBLB.Items.Count > 0)
            {
                lopALB.Items.Add(lopBLB.Items[0]);
                lopBLB.Items.RemoveAt(0);
            }
        }

        private void ketThucBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
