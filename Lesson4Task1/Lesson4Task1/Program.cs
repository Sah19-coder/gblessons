using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
 * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
 * */
namespace Lesson4Task1
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string[] FIO = { firstName,  lastName, patronymic };
            string Result = string.Join(" ", FIO);
            return Result;
        }
        static string GetWordFromUser(string What)
        {
            Console.WriteLine(What);
            string Result = Console.ReadLine();
            return Result;
        }
        static string GetFIO()
        {
            string Name = GetWordFromUser("Введите Имя: ");
            string LastName = GetWordFromUser("Введите Фамилию: ");
            string Patronymic = GetWordFromUser("Введите Отчество: ");
            string FIO = GetFullName(Name, LastName, Patronymic);
            return FIO;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте познакомимся!");
            string YouFIO = GetFIO();
            Console.WriteLine($"Здравствуйте, уважаемый {YouFIO}!");
            Console.WriteLine("Представте вашего друга.");
            string Frend1 = GetFIO();
            Console.WriteLine("Представте вашего второго друга.");
            string Frend2 = GetFIO();
            Console.WriteLine("Представте вашу подругу.");
            string GirlFrend = GetFIO();
            Console.WriteLine($"Приятно познакомиться, уважаемый {Frend1},\nуважаемый {Frend2},\nуважаемая {GirlFrend}.");
        }
    }
}
