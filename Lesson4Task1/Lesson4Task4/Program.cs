using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Task4
{
    class Program
    {
        static int CalcFib(int what)
        {
            int Result = 0;
            if (what < 1)
                return 0;
            if (what == 1)
                return 1;

            Result = CalcFib(what - 1) + CalcFib(what - 2);
            Console.WriteLine($" {Result}, ");
            return Result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число для вывода ряда Фибоначчи:");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("ряд Фибоначчи:");
            CalcFib(input);
        }
    }
}
