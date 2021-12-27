using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn thoát không?",
                            "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Con chó nghe lời đấy!");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Con chó nghe lời đấy!", "Thằng ngu", 
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
