using System;

namespace Bai20
{ 
    class Program
    {
        static void TestNhanVien()- 
        {
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            NhanVien nv = new NhanVien();
            NhanVien nv1 = new NhanVienThoiVu();
            NhanVienChinhThuc ct = new NhanVienChinhThuc();
            ct.TinhLuong();
            nv.TinhLuong();
            nv1.TinhLuong();
        }
    }
}
