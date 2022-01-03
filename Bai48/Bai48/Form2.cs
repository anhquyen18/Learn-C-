using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai48
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<DanhMuc> khoHang = new List<DanhMuc>();
        private void Form2_Load(object sender, EventArgs e)
        {
            DanhMuc bia = new DanhMuc();
            bia.Ma = "dm1";
            bia.Ten = "Nhóm bia";
            khoHang.Add(bia);

            SanPham biaKen = new SanPham();
            biaKen.Ma = "sp1";
            biaKen.Ten = "Heneiken";
            biaKen.Gia = 150;
            bia.ThemSanPham(biaKen);

            SanPham biaHuda = new SanPham();
            biaHuda.Ma = "sp2";
            biaHuda.Ten = "Huda";
            biaHuda.Gia = 120;
            bia.ThemSanPham(biaHuda);

            DanhMuc ruou = new DanhMuc();
            ruou.Ma = "dm2";
            ruou.Ten = "Nhóm rượu";
            khoHang.Add(ruou);

            SanPham ruouDe = new SanPham();
            ruouDe.Ma = "sp1";
            ruouDe.Ten = "Rượu Đế";
            ruouDe.Gia = 150;
            ruou.ThemSanPham(ruouDe);

            SanPham ruouHue = new SanPham();
            ruouHue.Ma = "sp2";
            ruouHue.Ten = "Rượu Huế";
            ruouHue.Gia = 100;
            ruou.ThemSanPham(ruouHue);

            foreach (DanhMuc dm in khoHang)
            {
                //Tạo nhóm cho ListView:
                ListViewGroup lvg = new ListViewGroup(dm.Ten);
                listView1.Groups.Add(lvg);
                foreach(SanPham sp in dm.SanPhams)
                {
                    // tạo 1 dòng listview item:
                    ListViewItem lvi = new ListViewItem(sp.Ma);
                    lvi.SubItems.Add(sp.Ten);
                    lvi.SubItems.Add(sp.Gia + "");
                    lvi.Group = lvg;
                    listView1.Items.Add(lvi);

                    if (dm == ruou)
                        lvi.ForeColor = Color.Red;
                }
            }
        }
    }
}
