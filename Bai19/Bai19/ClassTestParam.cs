using System;
using System.Collections.Generic;
using System.Text;

namespace Bai19
{
    class ClassTestParam
    {
        public int Sum(params int[] arr)
        {
            int s = 0;

            foreach(int x in arr)
            {
                s += x;
            }
            return s;
        }
    }
}
