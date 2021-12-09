using System;
using System.Collections.Generic;
using System.Text;

namespace Bai20
{
    class NhanVien
    {
        public int Ma { get; set; }
        public string Ten { get; set; }

        public virtual void TinhLuong()
        {
            Console.WriteLine("Đây là phương thức tính lương của NhanVien.");
        }
    }
}
