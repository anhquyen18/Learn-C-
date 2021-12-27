using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai26
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void hoBt_Click(object sender, EventArgs e)
        {
            hoTenLb.Text = hoTb.Text;
        }

        private void tenBt_Click(object sender, EventArgs e)
        {
            hoTenLb.Text = tenTb.Text;
        }

        private void hoTenBt_Click(object sender, EventArgs e)
        {
            hoTenLb.Text = hoTb.Text + " " + tenTb.Text;
        }

        private void thoatBt_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Muốn thoát hả cu?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ans == DialogResult.Yes)
                Close();
        }
    }
}
