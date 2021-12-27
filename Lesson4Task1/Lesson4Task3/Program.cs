using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *
Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

 * */

namespace Lesson4Task3
{
    public enum Seasons
    {
        Winter =2,
        Spring = 5,
        Summer = 8,
        Autumn = 11
        }
    static Seasons GetSeason(int month)
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца: ");
            string numMonth = Console.ReadLine();
            int month = Int32.Parse(numMonth);
            while (month < 0 || month > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12!");
                numMonth = Console.ReadLine();
                month = Int32.Parse(numMonth);
            }

        }
    }
}
