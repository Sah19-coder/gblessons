using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Task4
{
    class Program
    {
        static int CalcFib(int n)
        {
            
            if (n < 2)
                return 1;
 
            int Result = CalcFib(n - 1) + CalcFib(n - 2);
            Console.Write($" {Result}, ");
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
