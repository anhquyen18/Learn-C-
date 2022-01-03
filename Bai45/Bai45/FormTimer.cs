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
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            watchLb.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopBt_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void startBt_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
