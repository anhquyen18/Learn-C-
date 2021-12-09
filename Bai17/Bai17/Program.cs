using System;
using System.Collections.Generic;

namespace Bai17
{
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                menu();

                Console.WriteLine("Bạn có tiếp sử  dụng Từ điển không? (c/k): ");
                string s = Console.ReadLine();
                if (s[0] == 'k')
                    break;
            }
            Console.WriteLine("Bye!");
        }

        private static void menu()
        {
            Console.WriteLine("1. Tạo từ mới");
            Console.WriteLine("2. Sửa tử");
            Console.WriteLine("3. Tra cứu từ");
            Console.WriteLine("4. Xóa từ");
            Console.WriteLine("Xin mời bạn lựa chọn chức năng.");
            int cn = int.Parse(Console.ReadLine());

            try
            {

                switch (cn)
                {
                    case 1:
                        TaoTuMoi();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraCuu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    default:
                        Console.WriteLine("Bạn đã chọn sai chức năng!");
                        break;
                }
            }catch(Exception e)
            {
                Console.WriteLine("Lỗi mẹ gì đó rồi!" + e.Message);
            }

        }

        private static void XoaTu()
        {
            Console.WriteLine("Mời bạn nhập vào từ muốn xóa: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("Xóa thành công từ [{0}]", ta);
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ [{0}] để xóa", ta);
            }
        }

        private static void TraCuu()
        {
            Console.Write("Nhập vào từ muốn tra cứu: ");
            string ta = Console.ReadLine();

            if (dic.ContainsKey(ta))
            {
                string tv = dic[ta];
                Console.WriteLine("Nghĩa của [{0}] là [{1}] ", ta, tv);
            }
            else
            {
                Console.WriteLine("Từ điển chưa có cập nhật từ [{0}]", ta);
            }
        }

        private static void SuaTu()
        {
            Console.Write("Nhập vào Tiếng Anh để sửa lại nghĩa: ");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta) == false)
            {
                Console.WriteLine("Không tìm thấy [{0}] để sửa", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại nghĩa Tiếng Việt: ");
                string tv = Console.ReadLine();
                dic[ta] = tv;
            }
        }

        private static void TaoTuMoi()
        {
            Console.Write("Mời bạn nhập vào từ Tiếng Anh: ");
            String ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("Từ [{0}] đã tồn tại rồi", ta);
            }
            else
            {
                Console.Write("Mời bạn nhập vào nghĩa Tiếng Việt: ");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
            }

        }
    }
}
