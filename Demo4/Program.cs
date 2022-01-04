using System;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine("The Number is "+number);
            Change(ref number);
            Console.WriteLine("The Number is " + number);

        }
        static void Change(ref int value)
        {
            value = 15;
            Console.WriteLine("The Value Inside Method is "+value);
        }
    }
}
