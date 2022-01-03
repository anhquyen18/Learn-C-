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

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            fileNewMn.PerformClick();
        }

        private void fileNewMn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn tạo mới file");
        }

        private void fileSaveMn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn muốn lưu file");
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            fileSaveMn.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            pro.Text = s;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                int percent = i * 100 / 100;
                backgroundWorker1.ReportProgress(percent, i);
                System.Threading.Thread.Sleep(1);
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PercentPB.Value = e.ProgressPercentage;
            percentLb.Text = (double.Parse(e.UserState.ToString())) + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
