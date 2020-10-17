using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void MyPrintLine()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }
        static void MyPrintLine(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }
        static void MyPrintTriangle()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        static void MyPrintSquare()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("**");
            }
            Console.WriteLine("");
        }
        static void MyPrintSquare(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < b; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        static void MyPrintRombus()
        {
            int rhombusSize = 5;

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
            Console.WriteLine("");
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        //static int MyFunc(int x) { 
        //}


        static void Main(string[] args)
        {
            //MyPrintLine();
            //MyPrintLine(5);
            //MyPrintSquare(3, 3);
            //MyPrintTriangle();
            //MyPrintSquare();
            //MyPrintRombus();
            Console.WriteLine(Sum(5, 7));
        }
    }
}
