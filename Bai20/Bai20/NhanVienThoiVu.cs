using System;
using System.Collections.Generic;
using System.Text;

namespace Bai20
{
    class NhanVienThoiVu:NhanVien
    {
        public override void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Đây là phương thức tính lương của NhanVienThoiVu.");
        } 
    }
}
