//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев. После чего
//пользователь вводит диапазон (например, 3 и 6 – поиск между 3-м и 6-м месяцем). Необходимо
//определить месяц, в котором прибыль была максимальна и месяц, в котором прибыль была
//минимальна с учетом выбранного диапазона.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] profit = new float[12 + 1];
            Console.WriteLine("Введіть прибуток за кожний місяць");
            for(int i = 0; i < profit.Length;i++)
            {
                profit[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введіть проміжок місяців");
            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine());
            float max = profit[a];
            float min = profit[a];
            for(int i = a + 1; i <= b; i++) 
            {
                if (profit[i] > max) max = profit[i];
                if (profit[i] < min) min = profit[i];
            }
            Console.WriteLine($"Місяць з мінімальним прибутком {min}");
            Console.WriteLine($"Місяць з максимальним прибутком {max}");
        }
    }
}
