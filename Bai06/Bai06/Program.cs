using System;

namespace Bai07
{
    class Program
    {
        static void HocDoWhile()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập số n đi mày: ");
            n = int.Parse(Console.ReadLine());
            int gt = 1;
            int i = 1;
            do
            {
                gt *= i;
                i++;
            } while (i <= n);
            Console.WriteLine("{0}!={1}", n, gt);
        }

        static void HocWhile()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập số n đi mày: ");
            n = int.Parse(Console.ReadLine());
            int gt = 1;
            int i = 1;
            do
            {
                gt *= i;
                i++;
            } while (i <= n);
            Console.WriteLine("{0}!={1}", n, gt);
        }
        static void Main(string[] args)
        {
            HocWhile();
        }
    }
}
