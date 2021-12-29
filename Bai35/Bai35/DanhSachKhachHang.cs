using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai35
{
    class DanhSachKhachHang
    {
        List<KhachHang> dsKH = new List<KhachHang>();
        public List<KhachHang> KH
        {
            get
            {
                return dsKH;
            }
        }
        public void Mua(KhachHang kh)
        {
            dsKH.Add(kh);
        }
        public int TongSoKhachHang
        {
            get
            {
                return dsKH.Count;
            }
        }

        public int TongSoKhachHangSV
        {
            get
            {
                int soSV = 0;
                foreach (KhachHang kh in dsKH)
                    if (kh.LaSinhVien == true)
                        soSV++;
                return soSV;
            }
        }

        public double TongDoanhThu
        {
            get
            {
                double sum = 0;
                foreach (KhachHang kh in dsKH)
                    sum += kh.TinhTien;
                return sum;
            }
        }
    }
}
