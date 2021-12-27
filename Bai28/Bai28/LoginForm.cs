using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai28
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dangNhapBt_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text == "admin" && passwordTB.Text == "123456")
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void thoatBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
