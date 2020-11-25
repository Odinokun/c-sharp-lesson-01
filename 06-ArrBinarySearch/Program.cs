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

        //static int BinarySearch(int[] array, int searchValue, int minValue, int maxValue)
        //{
        //    SortArray(array); //сортируем массив 

        //    if (searchValue > maxValue || searchValue < minValue)
        //    {
        //        Console.WriteLine("Искомого значения нет в массиве");

        //        return -1;
        //    }

        //    int middleValue = (minValue + maxValue) / 2; //делим массив пополам
        //    int arrMiddleValue = array[middleValue]; //узнаем значение среднего элемента

        //    if (arrMiddleValue == searchValue) //если значение среднего элемента = искомому числу
        //    {
        //        Console.WriteLine("arrMiddleValue = " + arrMiddleValue);
        //        return arrMiddleValue;
        //    } else
        //    {
        //        if (middleValue > searchValue)
        //        {
        //            ищем в левой половине, рекурсивно вызывая функцию
        //            return BinarySearch(array, searchValue, minValue, middleValue - 1);
        //        }
        //        else
        //        {
        //            ищем в правой половине, рекурсивно вызывая функцию
        //            return BinarySearch(array, searchValue, middleValue + 1, maxValue);
        //        }
        //    }


        //}

        static int BinarySearch(int[] array, int key)
        {
            SortArray(array); //сортируем массив

            int minNum = 0;
            int maxNum = array.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;

                if (key == array[mid])
                {
                    Console.WriteLine("result = " + array[mid]);
                    return ++mid;
                }
                else if (key < array[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
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
            //BinarySearch(testArr, searchValue, 0, testArr.Length - 1);
        }
    }
}
