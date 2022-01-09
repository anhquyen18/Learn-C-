using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> dsSV = new List<SinhVien>();

        private void themSVBt_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(maTB.Text);
            sv.Ten = tenTB.Text;
            sv.NamSinh = namSinhDTP.Value;

            dsSV.Add(sv);

            HienThiDSSV();
        }

        private void HienThiDSSV()
        {
            svLB.Items.Clear();
            foreach (SinhVien sv in dsSV)
                svLB.Items.Add(sv);
        }

        private void luuSVBt_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\csdl.txt";
                bool kt = FileFactory.LuuFile(dsSV, path);
                if (kt)
                    MessageBox.Show("Lưu thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void docSVBt_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            if (System.IO.File.Exists(path))
            {
            dsSV = FileFactory.DocFile(path);

            HienThiDSSV();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            docSVBt.PerformClick();
        }
    }
}
