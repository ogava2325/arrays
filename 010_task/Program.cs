//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой создайте массив целых чисел размерности 10х10 и заполните его
//случайными элементами. Выведете на консоль полученный массив. Найдите суммы элементов
//каждой строки, произведения элементов каждого столбца, и максимальный элемент главной
//диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int height = 10;
            int width = 10; 
            int[,] a = new int[height, width];
            for(int i = 0; i < height;i++)
            {
                for(int j = 0; j < width; j++)
                {
                    a[i, j] = rand.Next(100);
                }
                
            }
            for(int i = 0; i < height;i++) 
            {
                for(int j = 0; j < width;j++)
                {
                    Console.Write(a[i,j] + " ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
