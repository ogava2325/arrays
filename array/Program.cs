//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран
//все элементы массива.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, -1, 3, 4, 5 };
            for(int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
