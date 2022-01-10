using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> dsSV = new List<SinhVien>();
        private void themBt_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(maTB.Text);
            sv.Ten = tenTB.Text;
            sv.NamSinh = namSinhDTP.Value;
            dsSV.Add(sv);
            HienThiSinhVien();
        }

        public void HienThiSinhVien()
        {
            danhSachLB.Items.Clear();
            foreach(SinhVien sv in dsSV)
            {
                danhSachLB.Items.Add(sv);
            }
        }

        private void luuBt_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            bool kt = FileFactory.LuuFile(dsSV, path);
            if(kt == true)
            {
                MessageBox.Show("Lưu thành công");
            }
        }

        private void docBt_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            dsSV = FileFactory.DocFile(path);
            HienThiSinhVien();
        }
    }
}
