//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте программу, в которой создайте метод, который в качестве параметра принимает слово,
//а возвращает тоже слово, но с измененным порядком букв в слове на обратный.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_task
{
    internal class Program
    {
        static string abds(string word)
        {
            string reverse_word = "";
            for(int i = word.Length - 1;i >= 0; i--) 
            {
                reverse_word += word[i];
            }
           return(reverse_word);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(abds("hello"));
            
        }
    }
}
