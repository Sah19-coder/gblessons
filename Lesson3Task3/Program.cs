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
namespace Lesson3Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i > 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
