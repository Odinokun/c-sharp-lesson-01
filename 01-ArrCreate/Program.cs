using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 45, 10, 55, 1, 87, 23 };

            for (int i = 0; i < testArr.Length; i++)
            {
                Console.WriteLine(testArr[i]);
            }
        }
    }
}
