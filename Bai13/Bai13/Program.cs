using System;

namespace Bai13
{
    class Program
    {
        static void XuLyChuoi1()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi: ");
            s = Console.ReadLine();

            int demInHoa = 0, demInThuong = 0, demSo = 0, demKhoangTrang = 0 ;
            char[] arr = s.ToCharArray();
            for (int i = 0; i<arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                    demInThuong++;
                if (char.IsUpper(arr[i]))
                    demInHoa++;
                if (char.IsDigit(arr[i]))
                    demSo++;
                if (char.IsWhiteSpace(arr[i]))
                    demKhoangTrang++;
                
            }
            Console.WriteLine("Có {0} ký tự in thường", demInThuong);
            Console.WriteLine("Có {0} ký tự in hoa", demInHoa);
            Console.WriteLine("Có {0} số", demSo);
            Console.WriteLine("Có {0} khoảng trắng", demKhoangTrang);

        }

        static void XuLyChuoi2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi: ");
            s = Console.ReadLine();

            int demInHoa = 0, demInThuong = 0, demSo = 0, demKhoangTrang = 0;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char kt = s[i];
                if (char.IsLower(arr[kt]))
                    demInThuong++;
                if (char.IsUpper(arr[kt]))
                    demInHoa++;
                if (char.IsDigit(arr[kt]))
                    demSo++;
                if (char.IsWhiteSpace(arr[kt]))
                    demKhoangTrang++;

            }
            Console.WriteLine("Có {0} ký tự in thường", demInThuong);
            Console.WriteLine("Có {0} ký tự in hoa", demInHoa);
            Console.WriteLine("Có {0} số", demSo);
            Console.WriteLine("Có {0} khoảng trắng", demKhoangTrang);

        }

        static void XuLyChuoi3()
        {
            string s;
            Console.WriteLine("Mioi ban nhap vao mot chuoi: ");
            s = Console.ReadLine();
            Console.WriteLine("Moi ban nhap chuoi tiep theo");
            string s2 = Console.ReadLine();
            int kq = s.ToLower().CompareTo(s2.ToLower());
            if (kq == 0)
            {
                Console.WriteLine("s va s2 giong nhau");
            }else if(kq < 0) {
                Console.WriteLine("s < s2");
            }
            else
            {
                Console.WriteLine("s>s2");
            }
        }

        static void XuLyChuoi4()
        {
            string s = string.Format("{0:dd/MM/yy}", DateTime.Now);
            Console.WriteLine(s);
        }

        static void XuLyChuoi6()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string s = "D:/baihatyeuthich/Photograph.mp3";
            int vt = s.LastIndexOf("/");
            string tenBH = s.Substring(vt+1);
            int vt2 = tenBH.LastIndexOf(".");
            string tenBH2 = tenBH.Substring(0, vt2);
             
            Console.WriteLine(tenBH2);
        }
        static void Main(string[] args)
        {
            XuLyChuoi6();
        }
    }
}
