using System;

namespace Demo1
{

    class Program
    {
        static void Main(string[] args)
        {
            Welcome();            
            Welcome();            
            Welcome();
            Welcome1("amir");
            Welcome1("reza");
            Welcome1("sina");
            Welcome2("amir", "amiri");
            Welcome2("reza", "rezaii");
            Sum(12, 16);

        }

        static void Welcome()
        {
            Console.WriteLine("Hello To All");
        }
        static void Welcome1(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static void Welcome2(string name,string surname)
        {
            Console.WriteLine($"Hello {name} {surname}");
        }

        static void Sum(int a,int b)
        {
            Console.WriteLine($"The Sum Result is {a+b}"); ;
        }
    }
}
