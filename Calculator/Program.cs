using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static double Sum(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        static double Minus(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }

        static double Mult(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        static double Division(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите оператор");
            string oper = Console.ReadLine();

            Console.WriteLine("Введите второе значение");
            double b = double.Parse(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    Console.WriteLine("Сумма = " + Sum(a, b));
                    break;
                case "-":
                    Console.WriteLine("Разница = " + Minus(a, b));
                    break;
                case "*":
                    Console.WriteLine("Произведение = " + Mult(a, b));
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя");
                    }
                    else
                    {
                        Console.WriteLine("Частное = " + Division(a, b));
                    }
                    break;
                default:
                    Console.WriteLine("Введите корректные значения.");
                    break;
            }
        }
    }
}