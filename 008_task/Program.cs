//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой создайте метод, который будет выполнять увеличение длины
//массива переданного в качестве аргумента, на 1 элемент. Метод, должен принимает два
//аргумента, первый аргумент - типа int[] array, второй аргумент - типа int value. В теле
//метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0,
//при этом длина нового массива, должна увеличиться на 1 элемент, а элементы получаемого
//массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса
//- 1.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_task
{
    internal class Program
    {
        static void push_back(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            for(int i = 0; i < array.Length;i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = value;

            array = newArray;
        }
        static void push_front(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i+1] = array[i];
            }
            newArray[0] = value;

            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < array.Length;i++) 
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            push_back(ref array, 100);
            push_front(ref array, 111);
            push_front(ref array, 112);
            push_front(ref array, 10);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
