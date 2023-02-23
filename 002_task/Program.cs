//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран
//все элементы массива в обратном порядке.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, -1, 3, 4, 5 };
            Console.WriteLine("Normal array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nReversed array: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
