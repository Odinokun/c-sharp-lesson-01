using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ArrElementIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 45, 10, 55, 1, 87, 23 };
            int result = -1;

            Console.WriteLine("Введите искомое число:\t");
            int searchNumb = int.Parse(Console.ReadLine());

            for (int i = 0; i < testArr.Length; i++)
            {
                if(searchNumb == testArr[i])
                {
                    result = i;
                }
            }

            Console.WriteLine("Индекс искомого числа =\t" + result);
        }
    }
}
