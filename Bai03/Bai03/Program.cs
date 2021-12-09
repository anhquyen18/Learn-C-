using System;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anh Quyền đẹp trai vcl");
            int soLuong = 0;
            double diemToan = 9.5;
            int x1 = 1;

            string name = "Trần Anh Quyền";
            Console.WriteLine(name);

            int x =  1 / 2;
            Console.WriteLine(x);

            var t = 5;
            Console.WriteLine("Kiểu của t = {0}", t.GetType());

            /*int b;
            Console.WriteLine("Mời bạn nhập vào số b: ");
            b = int.Parse(Console.ReadLine());

            if (-b % 2 == 0)
            {
                Console.WriteLine("{0} là số chẵn", b);

            }
            else
            {
                Console.WriteLine("{0} là số lẻ", b);
            }*/

            /*double diem;
            Console.WriteLine("Nhập điểm của bạn: ");
            diem = double.Parse(Console.ReadLine());
            string ketqua = diem >=8? "Giỏi": diem >= 6.5 ? "Khá" : diem >=5 ? "Trung bình" : "Yếu";
            Console.WriteLine(ketqua);*/

            double a = 5, b = 7;
            Console.WriteLine("Nhập nhép toán (+, -, *, /):");
            char kt = Console.ReadLine()[0];

            switch (kt)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static void Ham1(int x, double y)
        {

        }
    }
}
