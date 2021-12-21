using System;
namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            int UNP = 300359960;
            int Reg = 310007752;
            int KSA = 000453;
            int OP  = 002378598;

            double Cheese      = 1.34;
            double Milk        = 1.74;
            double sourCream   = 2.26;

            string Name = "ОАО МойТорг";


            Console.WriteLine($"       {Name}     ");
            Console.WriteLine("************************************");
            Console.WriteLine($"УНП                            {UNP}");
            Console.WriteLine($"РЕГ #                          {Reg}");
            Console.WriteLine($"# КСА                          {KSA}");
            Console.WriteLine("         Платежный документ             ");
            Console.WriteLine("             Чек продажи                ");
            Console.WriteLine($"Творог классический  5% 180г      2Х{Cheese}");
            Console.WriteLine($"                                    {2*Cheese}");

            Console.WriteLine($"Сметана Сафийка стакан 15% 400г   1Х{sourCream}");
            Console.WriteLine($"                                    {sourCream}");
            Console.WriteLine($"Молоко Сафийка 2.5% 950 мл бутылка 1Х{Milk}");
            Console.WriteLine($"                                     {Milk}");
            Console.WriteLine($"ИТОГ                                 {2*Cheese + sourCream + Milk}");
            Console.WriteLine("ПЛАСТ. КАРТ");
            Console.WriteLine($"Оператор 01                    #{OP}");
        }
    }
}
