using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1. Написать программу, выводящую элементы двумерного массива по диагонали.
2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email.
3. Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
 * */
namespace Lesson3Task2
{
    class Program
    {
      public  string[,] TelDic = { {"Alla", "+375295673546"}, { "Bella", "+375332954967" }, { "David", "+375253458956" }, { "Pamella", "+375334891425" },
                { "Evgen", "+491234758" }, { "Kontora", "alsng@gmail.com" }, { "sister", "+375295894034" }, { "mother", "+375331092639" },
                { "work", "+3752910983940" }, { "Abraham", "+4920947890" } };
        public void PrintDic()
        {
            
        }
        public static bool SeachAndPrintTel(string Name)
        {
            return true;
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Тел. справочник. Введите:\n s для поиска по имени,\n p для печати всего справочника,\n esc для выхода.");
        ConsoleKeyInfo command = Console.ReadKey();
            while(command.Key != ConsoleKey.Escape)
            {
                switch (command.Key)
                {
                    case ConsoleKey.S:
                        Console.WriteLine("Введите имя абонента для поиска:");
                        string Name = Console.ReadLine();
                        if(SeachAndPrintTel(Name);
                            break;
                    case ConsoleKey.P:
                        PrintDic();
                        break;
                }
            }
            
        }
    }
}
