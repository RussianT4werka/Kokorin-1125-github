using System;

namespace Кокорин_1125_github
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int b = rand.Next(100);
            int count = 1;
            Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуйте отгадать его за три попытки.");
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            while (count <= 1000)
            {
                if (b == a)
                {
                    Console.WriteLine("Да! Компьютер загадал число " + a + "!");
                    break;
                }
                { 
                    if (b > a) Console.WriteLine("Больше!");
                    if (b < a) Console.WriteLine("Меньше!");
                    a = Convert.ToInt32(Console.ReadLine());  
                }
            }
            Console.ReadLine();
        }
    }
}
