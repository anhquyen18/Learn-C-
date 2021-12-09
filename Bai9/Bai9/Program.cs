using System;

namespace Bai9
{
    class Program
    {
       static void TestToanHoc()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào số a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Căn bậc 2 của a {0} = {1}", a, Math.Sqrt(a));

            Console.WriteLine("Mời bạn nhập vào số b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}^{1} = {2}", a, b, Math.Pow(a, b));

            Console.WriteLine("Mời bạn nhập vào 1 góc: ");
            int goc = Convert.ToInt32(Console.ReadLine());
            double radian = Math.PI * goc / 180;
            Console.WriteLine("sin({0})={1}", goc, Math.Sin(radian));
            Console.WriteLine("cos({0})={1}", goc, Math.Cos(radian));
            Console.WriteLine("tan({0})={1}", goc, Math.Tan(radian));
            Console.WriteLine("cotg({0})={1}", goc, 1/Math.Tan(radian));

            Console.ReadLine();
        }

        static void TestRandom()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rd = new Random();
            int x = rd.Next(101);
            Console.WriteLine("Máy ra số ngẫu nhiên = {0}", x);

            double a = rd.NextDouble()*10000;
            Console.WriteLine("Máy ra số ngẫu nhiên = {0}", a);
        }
        static void TestDateTime()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DateTime dt = new DateTime(2000,9,18);
            Console.WriteLine(dt.ToString("dd/MM/yyyy"));

            Console.WriteLine("Ngày sinh của bạn là: {0}", dt.Day);
            Console.WriteLine("Tháng sinh của bạn là: {0}", dt.Month);
            Console.WriteLine("Năm sinh của bạn là: {0}", dt.Year);


            Console.ReadLine();
        }
        

        static void Main(string[] args)
        {
            TestDateTime();
        }
    }
}
