using System;

namespace Bai8
{
    class Program
    {
        static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
                
            }
            return gt;
        }

        static void fn1(int a)
        {
            for(int i = 0; i < 10; i++)
            {
                a = a+i;
            }
            
            Console.WriteLine("a trong khi gọi hàm fn1 = {0}", a);
        }

        static void fn2(ref int b)
        {
            b = b + 2;
            Console.WriteLine("b trong khi gọi hàm fn2 = {0}", b);
        }

        static void fn3(out int c)
        {
            c = 8 + 1;
            Console.WriteLine("c trong khi gọi hàm fn3 = {0}", c);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int v = 5;
            Console.WriteLine("a trước khi gọi hàm fn1 = {0}", v);
            fn1(v);       
            Console.WriteLine("a sau khi gọi hàm fn1 = {0}", v);

            /*int b = 10;
            Console.WriteLine("b trước khi gọi hàm fn2 = {0}", b);
            fn2(ref b);
            Console.WriteLine("b sau khi gọi hàm fn2 = {0}", b);*/

            /*int c = 10;
            Console.WriteLine("c trước khi gọi hàm fn3 = {0}",c);
            fn3(out c);
            Console.WriteLine("c sau khi gọi hàm fn3 = {0}", c);*/
        }
    }
}
