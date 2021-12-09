using System;
using System.Collections.Generic;

namespace Bai15
{
    class Program
    {
        static void HocList()
        {
            List<string> ds = new List<string>();
            ds.Add("Trần");
            ds.Add("Anh");
            ds.Add("Quyền");

            ds.Insert(ds.Count, "đẹp trai vcl");
            ds.RemoveAt(0);

            Console.WriteLine("Danh sách các phần tử trong List là: ");
            foreach(string s in ds)
            {
                Console.Write(s+" ");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            HocList();
            
        }
    }
}
