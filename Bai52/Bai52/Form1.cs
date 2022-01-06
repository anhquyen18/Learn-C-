using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chonHinhBt_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFilePB.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void luuBt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plain Text|*.txt|Tất cả|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Bạn muốn lưu nội dung vào: " + saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Bạn không lưu");
                
            }
        }

        private void chonMauBt_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = tabControl1.SelectedTab.BackColor;
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                tabControl1.SelectedTab.BackColor = colorDialog1.Color;
            }
        }

        private void doiFontBt_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = tenLb.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tenLb.Font = fontDialog1.Font;
            }
        }

        private void chonFolderBt_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTB.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
