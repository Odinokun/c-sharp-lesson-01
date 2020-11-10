using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ArrReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 45, 10, 55, 1, 87, 23 };

            for (int i = testArr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(testArr[i]);
            }
        }
    }
}
