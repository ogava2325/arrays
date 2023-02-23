//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой создайте массив размера N элементов (размер массива задет
//пользователь), заполнить его произвольными целыми значениями. Вывести на экран:
//наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов,
//среднее арифметическое всех элементов, вывести все нечетные значения.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine("Enter length of the array: ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            Console.WriteLine("Array is ");
            for(int i = 0; i < N; i++) 
            {
                arr[i] = rand.Next(20);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine($"\nMax of the array is {arr.Max()}");
            Console.WriteLine($"Min of the array is {arr.Min()}");
            Console.WriteLine($"Summary of the array is {arr.Sum()}");
            Console.WriteLine($"Average of the array is {arr.Average()}");
            Console.WriteLine("Odds in array");
            for (int i = 0; i < N; i++)
            {
                
                if(arr[i]%2 != 0) Console.Write(arr[i] + " ");
            }

        }
    }
}
