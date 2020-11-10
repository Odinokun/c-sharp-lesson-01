using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArrSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 45, 10, 55, 1, 87, 23 };

            for (int i = 0; i < testArr.Length; i++)
            {
                for (int k = 0; k < testArr.Length - 1; k++)
                {
                    if (testArr[k + 1] < testArr[k])
                    {
                        int temp = testArr[k];
                        testArr[k] = testArr[k + 1];
                        testArr[k + 1] = temp;
                    }
                }
            }

            for (int b = 0; b < testArr.Length; b++)
            {
                Console.WriteLine(testArr[b]);
            }
        }
    }
}
