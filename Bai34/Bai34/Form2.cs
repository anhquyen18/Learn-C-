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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Button[,] arrButton = null;
        Random rd = new Random();
        Button lasted = null;
        private void btVe_Click(object sender, EventArgs e)
        {
            int dong = int.Parse(tbDong.Text);
            int cot = int.Parse(tbCot.Text);
            
            arrButton = new Button[dong, cot];
            pnButton.Controls.Clear();
            for (int i = 0;i < arrButton.GetLength(0); i++)
            {
                for (int j = 0; j < arrButton.GetLength(1); j++)
                {
                    Button bt = new Button();
                    bt.Text = rd.Next(100) + "";
                    bt.Width = bt.Height = 50;
                    bt.Location = new Point(j * bt.Width, i * bt.Height);

                    pnButton.Controls.Add(bt);
                    arrButton[i, j] = bt;

                    bt.BackColor = Color.WhiteSmoke;
                    bt.Click += Bt_Click;
                    bt.Tag = i + ";" + j;
                }
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            if (lasted != null)
            {
                DoiMau(lasted, Color.WhiteSmoke);
            }
            Button bt = sender as Button;
            lasted = bt;
            DoiMau(lasted, Color.Aquamarine);
            lasted.BackColor = Color.Violet;
        }

        private void DoiMau(Button lasted, Color color)
        {
            string s = lasted.Tag.ToString();
            string[] arr = s.Split(';');
            int i = int.Parse(arr[0]);
            int j = int.Parse(arr[1]);

            for (int c = 0; c < arrButton.GetLength(1); c++)
            {
                arrButton[i, c].BackColor = color;
                
            }

            for (int d = 0; d < arrButton.GetLength(0); d++)
            {
                arrButton[d, j].BackColor = color;
            }

        }
    }
}
