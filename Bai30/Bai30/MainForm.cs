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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void capNhatBt_Click(object sender, EventArgs e)
        {
            int x = int.Parse(soTB.Text);
            soLB.Items.Add(x);
        }

        private void xoaDauCuoiBt_Click(object sender, EventArgs e)
        {
            soLB.Items.RemoveAt(0);
            soLB.Items.RemoveAt(soLB.Items.Count-1);
        }

        private void tongBT_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < soLB.Items.Count; i++)
            {
                int x = (int) soLB.Items[i];
                sum += x;
            }
            MessageBox.Show("Tổng các phần tử trong danh sách là: " + sum, "Tổng của danh sách");
        }

        private void xoaDangChonBt_Click(object sender, EventArgs e)
        {
            // Xóa 1 phần tử
            /*if (soLB.SelectedIndex != -1)
            {
                soLB.Items.RemoveAt(soLB.SelectedIndex);
            }*/

            // Xóa nhiều phần tử
            while (soLB.SelectedIndices.Count > 0)
            {
                soLB.Items.RemoveAt(soLB.SelectedIndices[0]);
            }
        }

        private void tang2Bt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < soLB.Items.Count; i++)
            {
                int x = (int) soLB.Items[i];
                soLB.Items[i] = x + 2;

            }
        }

        private void binhPhuongBt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < soLB.Items.Count; i++)
            {
                int x = (int)soLB.Items[i];
                int x2 = (int)Math.Pow(x, 2);
                soLB.Items[i] = x2;

            }

        }

        private void chonChanBt_Click(object sender, EventArgs e)
        {
            // trước khi chọn số chắn thì ta phải bỏ chọn toàn bộ các số cũ
            soLB.SelectedIndex = -1; // tự bỏ chọn toàn bộ các dòng trên list box
            for (int i = 0; i < soLB.Items.Count; i++)
            {
                int x = (int)soLB.Items[i];
                if (x % 2 == 0)
                {
                    soLB.SelectedIndex = i;
                }
            }
        }

        private void chonLeBt_Click(object sender, EventArgs e)
        {
            soLB.SelectedIndex = -1;
            for (int i = 0; i < soLB.Items.Count; i++)
            {
                int x = (int)soLB.Items[i];
                if (x % 2 == 1)
                {
                    soLB.SelectedIndex = i;
                }
            }

        }

        private void ketThucBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
