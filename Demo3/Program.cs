using System;
using System.Collections.Generic;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value=Sum(12, 16);
            Console.WriteLine(value);

            List<string> names = new List<string>();
            names.Add("amir");
            names.Add("reza");
            names.Add("sina");

        
        }

        static bool FindInNames(List<string> data,string search)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i]==search)
                {
                    return true;
                }
            }
            return false;
        }

        static int Sum(int a ,int b)
        {
            Console.WriteLine("This Call Inside Method");
            return a + b;
        }
    }
}
