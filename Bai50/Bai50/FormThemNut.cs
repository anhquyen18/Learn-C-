using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai50
{
    public partial class FormThemNut : Form
    {
        public FormThemNut()
        {
            InitializeComponent();
        }

        private void FormThemNut_Load(object sender, EventArgs e)
        {

        }

        private void okBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
