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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tenTB_TextChanged(object sender, EventArgs e)
        {

            if (smileyCatPB.Visible == true)
            {
                changeCatBt.Text = tenTB.Text + ", change to the Sad Cat :(";
            }
            else if (smileyCatPB.Visible == false)
            {
                changeCatBt.Text = tenTB.Text + ", change to the Smiley Cat :)";
            }
        }

        private void changeCatBt_Click(object sender, EventArgs e)
        {
            if (smileyCatPB.Visible == true)
            {
                changeCatBt.Text = changeCatBt.Text.Replace("Sad", "Smiley");
                changeCatBt.Text = changeCatBt.Text.Replace(":(", ":)");
                smileyCatPB.Visible = false;
                
            }
            else if (smileyCatPB.Visible == false)
            {
                changeCatBt.Text = changeCatBt.Text.Replace("Smiley", "Sad");
                changeCatBt.Text = changeCatBt.Text.Replace(":)", ":(");

                smileyCatPB.Visible = true;
            }
        }

    }
}
