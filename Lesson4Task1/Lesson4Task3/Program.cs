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
    class Program
    {
        public enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        /* static Seasons GetSeason(int month)
         {
             Seasons[] yea = { Seasons.Winter, Seasons.Winter, Seasons.Spring, Seasons.Spring, Seasons.Spring, Seasons.Summer, Seasons.Summer, Seasons.Summer,
                 Seasons.Autumn, Seasons.Autumn, Seasons.Autumn, Seasons.Winter };
         }
         */
        static Seasons GetSeason(int month)
        {
            Seasons Result = 0;
            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Result = Seasons.Winter;
                    break;

                case 3:
                case 4:
                case 5:
                    Result = Seasons.Spring;
                    break;

                case 6:
                case 7:
                case 8:
                    Result = Seasons.Summer;
                    break;

                case 9:
                case 10:
                case 11:
                    Result = Seasons.Autumn;
                    break;
            }
            return Result;
        }

        static string GetSeasonRus(Seasons season)
        {
            string[] seasonsRus = { "Зима", "Весна", "Лето", "Осень", };
            string Result = seasonsRus[(int)season];
            return Result;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца: ");
            string numMonth = Console.ReadLine();
            int month = Int32.Parse(numMonth);
            while (month < 1 || month > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12!");
                numMonth = Console.ReadLine();
                month = Int32.Parse(numMonth);
            }
            Seasons season = GetSeason(month);
            string sName = GetSeasonRus(season);
            Console.WriteLine($"Это {sName}");

        }
    }
}
