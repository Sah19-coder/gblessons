// See https://aka.ms/new-console-template for more information
using System;
namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру:");
            int MaxTemp = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру:");
            int MinTemp = int.Parse(Console.ReadLine());
            int Calc = (MaxTemp + MinTemp) / 2;
            Console.WriteLine($"Средняя температура= {Calc}");
        }
    }
}