using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье значение");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвертое значение");
            int d = int.Parse(Console.ReadLine());

            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (max < d)
            {
                max = d;
            }

            Console.WriteLine(max);
        }
    }
}
