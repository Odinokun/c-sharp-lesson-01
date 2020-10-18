using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое значение от 0 и выше");
            int factorial = int.Parse(Console.ReadLine());
            int result = 1;

            if (factorial < 0)
            {
                Console.WriteLine("Число должно быть больше или равно 0");
            }
            else if (factorial == 0)
            {
                Console.WriteLine(factorial + "! = " + result);
            }
            else
            {
                for (int i = 1; i <= factorial; i++)
                {
                    result = result * i;
                }
                
                Console.WriteLine(factorial + "! = " + result);
            }
        }
    }
}
