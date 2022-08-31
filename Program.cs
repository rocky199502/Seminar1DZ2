using System;

namespace DZseminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string first = Console.ReadLine();
            int number1 = int.Parse(first);
            Console.WriteLine("Введите второе число:");
            string second = Console.ReadLine();
            int number2 = int.Parse(second);
            Console.WriteLine("Введите третье число:");
            string three = Console.ReadLine();
            int number3 = int.Parse(three);
            if (number1>number2 && number1>number3)
            {
                 Console.WriteLine("Большее число: "+number1);
            }
            else if (number2>number1 && number2>number3)
            {
                 Console.WriteLine("Большее число: "+number2);
            }
            else if (number3>number1 && number3>number2)
            {
                 Console.WriteLine("Большее число: "+number3);
            } 
        }
    }
}
