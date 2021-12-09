using System;
using System.Collections.Generic;
using System.Text;

namespace Bai20
{
    class NhanVienChinhThuc:NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Đây là phương thức tính lương của NhanVienChinhThuc.");
        }
    }
}
