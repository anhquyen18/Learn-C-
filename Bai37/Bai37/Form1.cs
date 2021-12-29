using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xuLyVe100GheLenGiaoDien();
        }

        private void xuLyVe100GheLenGiaoDien()
        {
            gheTLP.Controls.Clear();
            int ghe = 1;
            for (int i = 0; i < gheTLP.ColumnCount; i++)
            {
                for (int j = 0; i < gheTLP.RowCount; j++)
                {
                    Label gheLb = new Label();
                    gheLb.Text = ghe + "";
                    gheLb.AutoSize = false;
                    gheLb.Dock = DockStyle.Fill;
                    gheLb.TextAlign = ContentAlignment.MiddleCenter;
                    gheLb.Width = gheLb.Height = 50;
                    gheLb.BackColor = Color.White;
                    gheTLP.Controls.Add(gheLb, j, i);
                   
                    ghe++;
                }
            }

        }

    }
}
