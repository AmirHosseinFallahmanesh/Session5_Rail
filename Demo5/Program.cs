using System;
using System.Collections.Generic;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            while (true)
            {
              
                Menu();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddName(ref names);
                        break;

                    case "2":
                        EditName(ref names);
                        break;

                    case "3":
                        DeleteName(ref names);
                        break;

                    case "4":
                        
                        PrintNames(names);
                        break;
                    case "5":
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("try again");
                        Console.ReadKey();
                        break;
                }
            }

        }


        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1)Add Name");
            Console.WriteLine("2)Edit Name");
            Console.WriteLine("3)Delete Name");
            Console.WriteLine("4)Print Names");
            Console.WriteLine("5)Search Names");
            Console.WriteLine("6)Exit");
        }

        private static void AddName(ref List<string> data)
        {
            Console.Clear();
            Console.WriteLine("Enter New Name");
            string name = Console.ReadLine();
            data.Add(name);

            Console.WriteLine("Insert Successfully");
            Console.ReadKey();
        }
        private static void EditName(ref List<string> data)
        {
            Console.Clear();
            Console.WriteLine("Enter Name");
            string searchName = Console.ReadLine();
            int index= FindName(data, searchName);
            if (index>-1)
            {
                Console.WriteLine("Entyer Name");
                data[index] = Console.ReadLine();
                Console.WriteLine("Update Successfully");
            }
            else
            {
                Console.WriteLine("Name Not Found");
            }

            Console.ReadKey();
        }    
            
        
        private static void DeleteName(ref List<string> data)
        {
            Console.Clear();
            Console.WriteLine("Enter Name");
            string searchName = Console.ReadLine();
            int index=FindName(data, searchName);
            if (index>-1)
            {
                data.RemoveAt(index);
                Console.WriteLine("Delete Successfully");
            }
            else
            {
                Console.WriteLine("Name Not Found");
            }
            Console.ReadKey();

        }
        private static void PrintNames(List<string> data)
        {
            Console.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
                Console.WriteLine("--------------------");
            }
            Console.ReadKey();

        }

        private static int FindName(List<string>data,string name)
        {
            int index = -1;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == name)
                {
                    index = i;
                }
            }
            return index;
        }


    }
}
//DRY do not repeat your self


