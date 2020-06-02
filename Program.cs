using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneuEntry me = new MoneuEntry();


            Console.WriteLine("Привет");
            Console.Write("Введите сумму: ");

            string amount = Console.ReadLine();

            Console.Write("Введите дату: ");
            string date = Console.ReadLine();

            me.InitWithString(amount, date);

            Console.WriteLine("Ваша запись: ");
            Console.WriteLine(me.ToString());

            if (me.IsDebit)
                Console.WriteLine("У вас новый доход.");
            else
                Console.WriteLine("У вас расход");
        }
    }
}
