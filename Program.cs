using System;



namespace TryProject
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Логин: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Добро пожаловать, {name}\n");
            System.Threading.Thread.Sleep(1200);
            Console.Clear();
            while (true)
            {
                Console.WriteLine($"Введите первое число: ");
                string frist = Console.ReadLine();
                int a = Convert.ToInt32(frist);
                System.Threading.Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("Введите действие - +,-,*,/: ");
                string charz = Console.ReadLine();
                char z = Convert.ToChar(charz);
                System.Threading.Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("Введите второе число: ");
                string second = Console.ReadLine();
                int b = Convert.ToInt32(second);
                System.Threading.Thread.Sleep(500);
                Console.Clear();


                if (z == '+')
                {
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                }

                if (z == '-')
                {
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                }

                if (z == '*')
                {
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                }

                if (z == '/')
                {
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                }
                Console.WriteLine($"\nДля продолжения введите - q: ");

                string countq = Console.ReadLine();
                char q = Convert.ToChar(countq);

                if (q == 'q')
                {
                    System.Threading.Thread.Sleep(1200);
                    Console.Clear();
                }

            }

        }

    }

}