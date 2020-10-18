using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1;

            for (int i = 1; i < 100; i++)
            {
                int count = 0;

                for (int k = 1; k <= firstNumber; k++)
                {
                    if (firstNumber % k == 0)
                    {
                        count++;
                    }

                    if (k == firstNumber && count == 2)
                    {
                        Console.Write(firstNumber + ", ");
                    }
                }

                firstNumber++;
            }
        }
    }
}
