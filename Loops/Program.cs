using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========first triangle==========");
            for (int i = 1; i < 5; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("========second triangle==========");
            for (int i = 4; i > 0; i--)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("========third triangle==========");
            for (int i = 1; i < 5; i++)
            {
                int space = 4;

                for (int j = space - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("========fourth triangle==========");
            for (int i = 4; i > 0; i--)
            {
                int space = 4;

                for (int j = space - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("========rhombus==========");
            Console.Write("Please, enter rhombus size ");
            int rhombusSize = int.Parse(Console.ReadLine());

            //begin top part of a rhombus
            for (int i = 1; i <= rhombusSize; i++)
            {
                if (i % 2 != 0)
                {
                    for (int k = 0; k < (rhombusSize - i) / 2; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            //end top part of a rhombus

            //begin bottom part of a rhombus
            for (int i = rhombusSize - 2; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    for (int k = 0; k < (rhombusSize - i) / 2; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            //end bottom part of a rhombus
        }
    }
}
