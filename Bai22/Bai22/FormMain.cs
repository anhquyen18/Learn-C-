using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Anh Quyền đẹp trai vcl");
            Application.Exit();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink ;
            this.WindowState = FormWindowState.Normal;
        }

        private void FormMain_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.Text = "ĐÃ BIẾN THÀNH ĐỎ";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn đã đóng cửa sổ");
        }
    }
}
