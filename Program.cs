using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            double b;
            double c;
            char oper;

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());


            
            if (oper == '+')
            {
                c = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + c + ".");
            }

            else if (oper == '-')
            {
                c = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + c + ".");
            }

            else if (oper == '*')
            {
                c = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + c + ".");
            }

            else if (oper == '/')
            {
                c = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + c + ".");
            }
            else if (oper == '%')
            {
                c = a % b;
                Console.WriteLine("Остаток " + a + " от " + b + " будет " + c + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
                Console.ReadKey();
            }
        }
    }
}
