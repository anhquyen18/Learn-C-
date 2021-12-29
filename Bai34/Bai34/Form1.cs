using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button lasted = null;
        private void btThem_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            Random rd = new Random();
            bt.Text = rd.Next(102) + "";
            bt.Width = 100;
            bt.Height = 30;
            bt.BackColor = Color.Yellow; 
            pnButton.Controls.Add(bt);
            bt.Click += Bt_Click;
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            if (lasted != null)
            {
                lasted.BackColor = Color.Yellow;
            }
            Button bt = sender as Button;
            bt.BackColor = Color.Red;
            lasted = bt;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lasted != null)
            {
                pnButton.Controls.Remove(lasted);
            }
        }
    }
}
