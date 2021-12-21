using System;
namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите любое число:");
            int Any = int.Parse(Console.ReadLine());

           if(Any%2 == 0)
            Console.WriteLine("Ваше число - четное");
           else
                Console.WriteLine("Ваше число - нечетное");
        }
    }
}
