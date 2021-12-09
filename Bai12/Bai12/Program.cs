using System;

namespace Bai12
{
    class Program
    {
        static void HocBietLe1()
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.Write("Mời bạn nhập vào ngày tháng năm sinh: ");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("Bạn vừa nhập ngày tháng năm sinh = " + birthday.ToString("dd/MM/yyyy"));
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Đã có lỗi xảy ra");
            }
        }

        static void HocBietLe2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Mời bạn nhập tử số: ");
            int tu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập tử số: ");
            int mau = Convert.ToInt32(Console.ReadLine());
            if (mau == 0)
            {
                throw new ArithmeticException("Lỗi mẫu số = 0");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                HocBietLe2();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
