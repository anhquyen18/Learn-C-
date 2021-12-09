using System;
using System.Collections.Generic;

namespace Bai21
{
    class Program
    {
        static List<PhongBan> dsPB = new List<PhongBan>();
        static void TestQuanLyNV()
        {
            PhongBan pNS = new PhongBan();
            pNS.MaPhongBan = 1;
            pNS.TenPhongBan = "Phòng Nhân Sự";
            dsPB.Add(pNS);

            NhanVien Nguyen = new NhanVien();
            Nguyen.MaNhanVien = 2;
            Nguyen.TenNV = "Trần Anh Nguyên";
            Nguyen.ChucVu = LoaiChucVu.TRUONG_PHONG;
            pNS.ThemNhanVien(Nguyen);

            NhanVien Quyen = new NhanVien();
            Quyen.MaNhanVien = 1;
            Quyen.TenNV = "Trần Anh Quyền";
            Quyen.ChucVu = LoaiChucVu.GIAM_DOC;
            pNS.ThemNhanVien(Quyen);

           

            PhongBan pKT = new PhongBan();
            pKT.MaPhongBan = 2;
            pKT.TenPhongBan = "Phòng kế toán";
            dsPB.Add(pKT);

            NhanVien Thao = new NhanVien();
            Thao.MaNhanVien = 3;
            Thao.TenNV = "Trần Thị Anh Thảo";
            Thao.ChucVu = LoaiChucVu.TRUONG_PHONG;
            pKT.ThemNhanVien(Thao);

            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty: ");
            foreach(PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }

            NhanVien old = pNS.TimNhanVien(1);
            if (old != null)
            {
                old.TenNV = "Anh Quyền đẹp trai vcl";
            }

            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty sau khi đã chỉnh sửa: ");
            foreach (PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }

            Console.WriteLine("Danh sách nhân viên thuộc phòng nhân sự sau khi sắp xếp: ");
            pNS.SapXep();
            pNS.XuatToanBoNhanVien();

            long sum = 0;
            foreach (PhongBan pb in dsPB)
            {
                sum += pb.TongLuong();
            }
            Console.WriteLine(sum);
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            TestQuanLyNV();
        }
    }
}
