using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrAddElement
{
    class Program
    {

        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = value;

            for (int i = 0; i < index; i++) //элементы до вставляемого числа
                newArray[i] = array[i];

            for (int i = index; i < array.Length; i++) //элементы после вставляемого числа
                newArray[i + 1] = array[i];

            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] testArray = { 45, 10, 55, 1, 87, 23 };

            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write(testArray[i] + ", ");
            }

            Insert(ref testArray, 777, 3);

            Console.WriteLine();

            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write(testArray[i] + ", ");
            }

        }
    }
}
