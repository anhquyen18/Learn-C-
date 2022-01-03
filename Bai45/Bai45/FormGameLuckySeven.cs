using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai45
{
    public partial class FormGameLuckySeven : Form
    {
        public FormGameLuckySeven()
        {
            InitializeComponent();
        }
        int tienMay = 100;
        int tienNguoi = 100;
        Random rd = new Random();
        int count = 0;
        private void quaySoBt_Click(object sender, EventArgs e)
        {
            if (tienNguoi < 30)
            {
                MessageBox.Show("Bạn không đủ tiền.");
                return;

            }
            tienNguoi = tienNguoi - 30;
            tienMay = tienMay + 30;
            count = 0;
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int so1 = rd.Next(9);
            int so2 = rd.Next(10);
            int so3 = rd.Next(11);

            so1Lb.Text = so1 + "";
            so2Lb.Text = so2 + "";
            so3Lb.Text = so3 + "";

            if (count > 100)
            {
                if (so1 == 7)
                {
                    tienNguoi =tienNguoi + 100 + (tienMay / 2);
                    tienMay = tienMay / 2;
                }
                if (so2 == 7)
                {
                    tienNguoi = tienNguoi + 30 + (tienMay / 2);
                    tienMay = tienMay / 2;
                }
                if (so3 == 7)
                    tienNguoi = tienNguoi + 10;
                tienMayLb.Text = tienMay + "";
                tienNguoiChoiLb.Text = tienNguoi + "";
                
                timer1.Stop();
            }
            count++;
        }

        private void gameMoiBt_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn tạo game mới","Game mới",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                tienMay = 100;
                tienNguoi = 100;
                tienMayLb.Text = tienMay + "";
                tienNguoiChoiLb.Text = tienNguoi + "";
            }
        }

        private void ketThucBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
