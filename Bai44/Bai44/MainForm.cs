using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai44
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void moBaiTap1TSMI_Click(object sender, EventArgs e)
        {
            FormBai1 bai1 = new FormBai1();
            bai1.MdiParent = this;
            bai1.Show();
        }

        private void moBaiTap2TSMI_Click(object sender, EventArgs e)
        {
            FormBai2 bai2 = new FormBai2();
            bai2.MdiParent = this;
            bai2.Show();
        }

        private void moBaiTap3TSMI_Click(object sender, EventArgs e)
        {
            FormBai3 bai3 = new FormBai3();
            bai3.MdiParent = this;
            bai3.Show();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
