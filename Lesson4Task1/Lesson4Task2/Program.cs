using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
Ввести данные с клавиатуры и вывести результат на экран.
 * */
namespace Lesson4Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку целых чисел через пробел.");
            string inputStr = Console.ReadLine();
            string[] Nums = inputStr.Split(' ');
            int sum = 0;
            foreach(var snum in Nums)
            {
                sum += Int32.Parse(snum);
            }
            Console.WriteLine($"Сумма всех чисел= {sum}");
        }
    }
}
