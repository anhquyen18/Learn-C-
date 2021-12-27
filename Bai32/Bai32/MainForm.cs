using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai32
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            leftCLB.Items.AddRange(new string[] { "Hà Nột", "Đà Nẵng", 
                "Hồ Chí Minh", "Lâm Đồng", "Huế"});
        }

        private void chuyenPhaiBt_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < leftCLB.Items.Count; i++)
            {
                if (leftCLB.GetItemChecked(i))
                {
                    rightCLB.Items.Add(leftCLB.Items[i]);
                    leftCLB.Items.RemoveAt(i);
                }
            }
        }

        private void chuyenTatCaPhaiBt_Click(object sender, EventArgs e)
        {
            rightCLB.Items.AddRange(leftCLB.Items);
            leftCLB.Items.Clear();
        }

        private void chuyenTraiBt_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection dsChecked = rightCLB.CheckedItems;
            foreach (var x in dsChecked){
                leftCLB.Items.Add(x);
            }
            while (dsChecked.Count > 0)
            {
                rightCLB.Items.Remove(dsChecked[0]);
            }
        }

        private void chuyenTatCaTraiBt_Click(object sender, EventArgs e)
        {
            leftCLB.Items.AddRange(rightCLB.Items);
            rightCLB.Items.Clear();
        }
    }
}
