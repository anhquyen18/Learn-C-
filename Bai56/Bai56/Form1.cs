using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Bai56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void luuBt_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plain text .txt|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                noiDungRTB.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Đã lưu nội dung trên RichTextBox xuống tập tin thành công");
            }
        }

        private void docBt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Plain text .txt|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = openFileDialog1.OpenFile();
                StreamReader sr = new StreamReader(stream);
                noiDungRTB.Text = sr.ReadToEnd();
            }

        }
    }
}
