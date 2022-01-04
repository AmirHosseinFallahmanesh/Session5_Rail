using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            int number2 = int.Parse(Console.ReadLine());

            Sum(number1, number2);
            Min(number1, number2);
            Mul(number1, number2);
            Div(number1, number2);


        }
        static void Sum(int a ,int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }

        static void Div(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }

        static void Mul(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        static void Min(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}
