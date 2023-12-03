using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "Пусть", "задан", "массив", "содержащий", "Строки" };
            for (int i = 0; i < strings.Length; i++)
            {
                string str= strings[i];
                if ((Char.IsUpper(str, 0)))
                {
                    Console.WriteLine($"{i} эллемент начинается с большой буквы {str}");
                }
                
            }
        }
    }
}
