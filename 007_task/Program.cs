//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой создает метод, который в качестве аргументов принимает:
//1)целочисленный массив(int[] array), 2)целочисленный индекс(int index), 3)количество
//элементов(int count), возвращает целочисленный массив элементов(int [] subArray).
//Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции
//указанной в аргументе index, размерностью, которая соответствует значению аргумента count.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_task
{
    internal class Program
    {
        static int[] Method(int[] array, int index, int count)
        {
            int size = 0;
            if (index <= array.Length)
            {
                if (index + count <= array.Length) size = count;
                else size = array.Length - index;
                int[] subArray = new int[size];
                for(int i = 0; i < size; i++)
                {
                    subArray[i] = array[index++];
                }
                return subArray;
            }
            else Console.WriteLine("Індекс за межами масиву");
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 45, 4, 5, 6, };
            Console.WriteLine(Method(array,1, 3));
        }
    }
}
