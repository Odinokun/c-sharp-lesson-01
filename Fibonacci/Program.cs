using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Fibonacci(int a, int b)
        {
            int result = a + b;

            if (result < 2)
            {
                Console.Write(a + ", " + b + ", ");
            }
            
            if (result < 200)
            {
                Console.Write(result + ", ");
                Fibonacci(b, result);
            }

            //while (result < 200)
            //{
            //    Fibonacci(b, result);
            //}

        }

        static void Main(string[] args)
        {
            Fibonacci(0, 1);
        }
    }
}
