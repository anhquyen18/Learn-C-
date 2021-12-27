using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai27
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thoatBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            redRB.Checked = true;
            nhapTenTB.Focus();
        }

        private void nhapTenTB_TextChanged(object sender, EventArgs e)
        {
            tenLapTrinhLb.Text = nhapTenTB.Text;
        }

        private void redRB_CheckedChanged(object sender, EventArgs e)
        {
            if (redRB.Checked == true)
            {
                tenLapTrinhLb.ForeColor = redRB.ForeColor;
            }
        }

        private void greenRB_CheckedChanged(object sender, EventArgs e)
        {
            if (greenRB.Checked == true)
            {
                tenLapTrinhLb.ForeColor = greenRB.ForeColor;
            }
        }

        private void blueRB_CheckedChanged(object sender, EventArgs e)
        {
                tenLapTrinhLb.ForeColor = blueRB.ForeColor;
        }

        private void blackRB_CheckedChanged(object sender, EventArgs e)
        {
            if (blackRB.Checked == true)
            {
                tenLapTrinhLb.ForeColor = blackRB.ForeColor;
            }
        }

        private void boldCB_CheckedChanged(object sender, EventArgs e)
        {
            tenLapTrinhLb.Font = new Font(tenLapTrinhLb.Font.Name,
                tenLapTrinhLb.Font.Size, tenLapTrinhLb.Font.Style^FontStyle.Bold);
        }

        private void italicCB_CheckedChanged(object sender, EventArgs e)
        {
            tenLapTrinhLb.Font = new Font(tenLapTrinhLb.Font.Name,
               tenLapTrinhLb.Font.Size, tenLapTrinhLb.Font.Style ^ FontStyle.Italic);
        }

        private void underlineCB_CheckedChanged(object sender, EventArgs e)
        {
            tenLapTrinhLb.Font = new Font(tenLapTrinhLb.Font.Name,
               tenLapTrinhLb.Font.Size, tenLapTrinhLb.Font.Style ^ FontStyle.Underline);
            tenLapTrinhLb.Text = "Anh Quyền đẹp trai nhất quả đất";
        }
    }
}
