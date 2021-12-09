using System;
using System.Collections.Generic;
using System.Text;

namespace Bai21
{
    class PhongBan
    {
        private List<NhanVien> dsNV = new List<NhanVien>();
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public NhanVien TruongPhong { get; set; }
        public bool ThemNhanVien(NhanVien nv)
        {
            bool trungMaNV = false;
            foreach(NhanVien oldNV in dsNV)
            {
                if (oldNV.MaNhanVien == nv.MaNhanVien)
                {
                    trungMaNV = true;
                    break;
                }
            }

            if (trungMaNV == true)
            {
                return false;
            }
            nv.Phong = this;
            dsNV.Add(nv);
            return true;
        }

        public void XuatToanBoNhanVien()
        {
            foreach(NhanVien nv in dsNV)
            {
                Console.WriteLine(nv);
            }
        }

        public NhanVien TimNhanVien(int maNV)
        {
            NhanVien nv = null;
            foreach (NhanVien old in dsNV)
                if (old.MaNhanVien == maNV)
                    return old;
            return nv;
        }

        public bool XoaNhanVien(int maNV)
        {
            NhanVien nv = TimNhanVien(maNV);
            if (nv == null) return false;
            dsNV.Remove(nv);
            return true;
        }

        private int compare(NhanVien nv1, NhanVien nv2)
        {
            int kqSSTen = string.Compare(nv1.TenNV, nv2.TenNV, true);
            if (kqSSTen == 0)
            {
                if (nv1.MaNhanVien < nv2.MaNhanVien)
                    return 1;
                if (nv1.MaNhanVien > nv2.MaNhanVien)
                    return -1;
                return 0;
            }
            return kqSSTen;
        }

        public void SapXep()
        {
            dsNV.Sort(compare);
        }

        public long TongLuong()
        {
            long sum = 0;
            foreach(NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong;
            }
            return sum;
        }
    }
}
