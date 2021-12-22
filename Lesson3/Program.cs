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
namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MyNums   = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, {13,14,15,16 } };
            int rows        = MyNums.GetUpperBound(0) + 1;
            int columns     = MyNums.Length / rows; 

                for(int it=0; it < rows; it++)
                {
                Console.WriteLine("");
                for (int it2 =0; it2 <  columns; it2++)
                    {
                    if(it2==it) //Мы на диагонали?
                        Console.Write($"    {MyNums[it, it2]}");
                    else
                        Console.Write("    ");
                    }

                }
        }
    }
}
