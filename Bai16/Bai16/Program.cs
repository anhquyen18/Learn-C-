using System;
using System.Collections;
using System.Collections.Generic;

namespace Bai16
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Dictionary<string, double> dic2 = new Dictionary<string, double>();

            dic.Add(1, "Trần Anh Quyền");
            dic.Add(2, "Trần Anh Nguyên");
            if (dic.ContainsKey(2) == false)
                dic.Add(2, "Trần Anh Nguyên 12");
            dic.Add(3, "Trần Thị Anh Thảo");

            foreach(KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine("Mã = " + item.Key + "; Tên = " + item.Value);
            }
            dic.Remove(2);
            Console.WriteLine("Sau khi xóa phần tử có khóa chính là 2: ");
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine("Mã = " + item.Key + "; Tên = " + item.Value);
            }
            string value = dic[3];
            Console.WriteLine("Đối tượng có khóa chính = 3 là: "+value);

            //List<string> dsGiaTri = dic.Values.ToString();
            //List<int> key = dic.Keys.ToString();
        }
    }
}
