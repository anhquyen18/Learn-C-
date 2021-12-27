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
    public partial class SinhVienForm : Form
    {
        public SinhVienForm()
        {
            InitializeComponent();
        }

        private void luuBt_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(maTB.Text);
            sv.Ten = tenTB.Text;

            sinhVienLB.Items.Add(sv);
        }

        private void sinhVienLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sinhVienLB.SelectedIndex != -1)
            {
                SinhVien sv = sinhVienLB.SelectedItem as SinhVien;
                maTB.Text = sv.Ma.ToString();
                tenTB.Text = sv.Ten;
            }
        }

        private void xoaBt_Click(object sender, EventArgs e)
        {
            if (sinhVienLB.SelectedIndex != -1)
            {

                sinhVienLB.Items.RemoveAt(sinhVienLB.SelectedIndex);
            }
        }

        private void leBt_Click(object sender, EventArgs e)
        {
            sinhVienLB.SelectedIndex = -1;
            List<SinhVien> dsSV = new List<SinhVien>();

            for (int i = 0; i < sinhVienLB.Items.Count; i++)
            {
                dsSV.Add(sinhVienLB.Items[i] as SinhVien);
                if (dsSV[i].Ma % 2 == 1)
                {
                    sinhVienLB.SelectedIndex = i;
                }
            }
        }
    }
}
