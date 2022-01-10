using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai53
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Dictionary<string, Khoa> CSDL = new Dictionary<string, Khoa>();
        SinhVien selectedSV = null;
        private void FormMain_Load(object sender, EventArgs e)
        {
            LamGiaDuLieu();
            HienThiLenTreeView();
            HienThiKhoaLenCombobox();
        }

        private void HienThiLenTreeView()
        {
            khoaTV.Nodes.Clear();
            foreach(KeyValuePair<string, Khoa> item in CSDL)
            {
                Khoa kh = item.Value;
                TreeNode nodeKhoa = new TreeNode(kh.TenKhoa);
                nodeKhoa.Tag = kh;

                khoaTV.Nodes.Add(nodeKhoa);

                foreach(KeyValuePair<string, LopHoc> itemLop in kh.Lops)
                {
                    LopHoc lop = itemLop.Value;
                    TreeNode nodeLop = new TreeNode(lop.TenLop);
                    nodeLop.Tag = lop;
                    nodeKhoa.Nodes.Add(nodeLop);
                }
            }
            khoaTV.ExpandAll();
        }

        private void LamGiaDuLieu()
        {
            Khoa cntt = new Khoa() { MaKhoa = "CNTT", TenKhoa = "Khoa Công Nghệ Thông Tin" };
            Khoa ctt = new Khoa() { MaKhoa = "CTT", TenKhoa = "Khoa Xây dựng Công trình thủy" };
            Khoa xddd = new Khoa() { MaKhoa = "XDDD", TenKhoa = "Khoa Xây dựng Dân dụng và Công nghiệp" };

            CSDL.Add(cntt.MaKhoa, cntt);
            CSDL.Add(ctt.MaKhoa, ctt);
            CSDL.Add(xddd.MaKhoa, xddd);

            LopHoc lopcntt1 = new LopHoc() { MaLop = "cntt1", TenLop = "18T1" };
            cntt.Lops.Add(lopcntt1.MaLop,lopcntt1);
            lopcntt1.KhoaChuQuan = cntt;
            LopHoc lopcntt2 = new LopHoc() { MaLop = "cntt2", TenLop = "18T2" };
            cntt.Lops.Add(lopcntt2.MaLop, lopcntt2);
            lopcntt2.KhoaChuQuan = cntt;

            LopHoc lopctt1 = new LopHoc() { MaLop = "ctt1", TenLop = "18THXD1" };
            ctt .Lops.Add(lopctt1.MaLop, lopctt1);
            lopctt1.KhoaChuQuan = ctt;
            LopHoc lopctt2 = new LopHoc() { MaLop = "ctt2", TenLop = "18THXD2" };
            ctt.Lops.Add(lopctt2.MaLop, lopctt2);
            lopctt1.KhoaChuQuan = ctt;

            SinhVien quyen = new SinhVien() { Ma = "sv1",Ten = "Trần Anh Quyền",
                GioiTinh = false, 
                NamSinh = new DateTime(2000, 9, 18) };
            lopctt1.SinhViens.Add(quyen.Ma, quyen);
            quyen.LopChuQuan = lopctt1;

            SinhVien nguyen = new SinhVien()
            {
                Ma = "sv2",
                GioiTinh = false,
                NamSinh = new DateTime(1998, 7, 18)
            };
            lopctt1.SinhViens.Add(nguyen.Ma, nguyen);
            nguyen.LopChuQuan = lopctt1;

        }

        private void khoaTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node!= null)// có chọn nút gì đó trên giao diện
            {
                if(e.Node.Level == 1)// đung là NSD chọn nút lớp học => hiển thị danh sách sinh viên
                {
                    LopHoc lop = e.Node.Tag as LopHoc;
                    HienThiDanhSachSinhVienTheoLop(lop);
                }
                else
                {
                    sinhVienLV.Items.Clear(); //Xóa đi vì không xem danh sách sinh viên
                }
            }
        }

        private void HienThiDanhSachSinhVienTheoLop(LopHoc lop)
        {
            sinhVienLV.Items.Clear();
            foreach(KeyValuePair<string, SinhVien> itemSV in lop.SinhViens)
            {
                SinhVien sv = itemSV.Value;
                ListViewItem lvi = new ListViewItem(sv.Ma);
                lvi.SubItems.Add(sv.Ten);
                lvi.SubItems.Add(sv.GioiTinh == false ? "Nam" : "Nữ");
                if (sv.NamSinh != null)
                {
                lvi.SubItems.Add(sv.NamSinh.ToString("dd/MM/yyyy"));

                }
                else
                {
                    lvi.SubItems.Add(sv.NamSinh.ToString("..."));
                }
                sinhVienLV.Items.Add(lvi);
                lvi.Tag = sv;
            }
        }

        private void HienThiKhoaLenCombobox()
        {
            khoaCBB.Items.Clear();
            foreach(KeyValuePair<string, Khoa> itemKhoa in CSDL)
            {
                Khoa kh = itemKhoa.Value;
                khoaCBB.Items.Add(kh); 
            }
        }

        private void khoaCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (khoaCBB.SelectedIndex == -1) return;
            Khoa kh = khoaCBB.SelectedItem as Khoa;
            HienThiLopLenCombobox(kh);
        }

        private void HienThiLopLenCombobox(Khoa khoa)
        {
            lopCBB.Items.Clear();
            foreach (KeyValuePair<string, LopHoc> itemLop in khoa.Lops)
            {
                LopHoc lop = itemLop.Value;
                lopCBB.Items.Add(lop);
            }
        }

        private void luuBt_Click(object sender, EventArgs e)
        {
            if (khoaCBB.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn Khoa");
                return;
            }
            if (lopCBB.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn Lớp");
                return;
            }
            SinhVien sv = new SinhVien();
            sv.Ma = maSVTB.Text;
            sv.Ten = tenSVTB.Text;
            sv.GioiTinh = namRB.Checked;

            LopHoc lop = lopCBB.SelectedItem as LopHoc;
            sv.LopChuQuan = lop;
            lop.SinhViens.Add(sv.Ma, sv);
            MessageBox.Show("Đã lưu thành công");
        }

        private void xoaBt_Click(object sender, EventArgs e)
        {
            if (selectedSV != null)
            {
                LopHoc lop = selectedSV.LopChuQuan;
                lop.SinhViens.Remove(selectedSV.Ma);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để xóa");
            }
                
        }

        private void sinhVienLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sinhVienLV.SelectedItems.Count == 0) return;
            ListViewItem lvi = sinhVienLV.SelectedItems[0];
            SinhVien sv = lvi.Tag as SinhVien;
            maSVTB.Text = sv.Ma;
            tenSVTB.Text = sv.Ten;
            if (sv.GioiTinh)
                nuRB.Checked = true;
            else
                namRB.Checked = true;
            selectedSV = sv;
        }

        private void heThongThoatMn_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát?", "Hỏi thoát"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }

        private void heThongLuuDuLieuMn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool kt = FileFactory.SaveFile(CSDL, saveFileDialog1.FileName);
                if (kt)
                    MessageBox.Show("Lưu thành công");

            }
        }

        private void heThongDocDuLieuMn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                CSDL = FileFactory.readFile(openFileDialog1.FileName);
                HienThiLenTreeView();
            }
        }
    }
}
