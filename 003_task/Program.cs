//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой создайте два строковых массива с именами A и B (размерностью
//4 элемента). Массив A заполняется в цикле пользователем. Получить результирующий массив B,
//обратный к исходному массиву A (элементы массива B идут в обратном порядке по отношению к
//массиву A).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 4;
            string[] arrA = new string[length];
            string[] arrB = new string[length];
            Console.WriteLine("Enter elemets of the array one by one:");
            int j = length - 1;
            for(int i = 0; i < arrA.Length; i++) 
            {
                arrA[i] = Console.ReadLine();
                arrB[j--] = arrA[i]; 
            }
            Console.WriteLine("Array A is:");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write(arrA[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Array B is:");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write(arrB[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
