using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ArrBinarySearch
{
    class Program
    {
        static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    if (array[k + 1] < array[k])
                    {
                        int temp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = temp;
                    }
                }
            }
        }

        static int BinarySearch(int[] array, int key)
        {
            SortArray(array); //сортируем массив

            int minNum = 0;
            int maxNum = array.Length - 1;

            while (minNum <= maxNum)
            {
                int middleVal = (minNum + maxNum) / 2; //среднее значение

                if (key == array[middleVal])
                {
                    Console.WriteLine("result = " + array[middleVal]);
                    return ++middleVal;
                }
                else if (key < array[middleVal])
                {
                    maxNum = middleVal - 1;
                }
                else
                {
                    minNum = middleVal + 1;
                }
            }

            Console.WriteLine("Number don`t found");
            return -1;
        }

        static void Main(string[] args)
        {
            int[] testArr = { 45, 10, 55, 65, 4, 22, 8, 57, 44, 21, 73, 14, 1, 87, 23, 33, 97 };

            Console.Write("Введите значение которое требуется найти: ");
            int searchValue = int.Parse(Console.ReadLine());

            BinarySearch(testArr, searchValue);
        }
    }
}
