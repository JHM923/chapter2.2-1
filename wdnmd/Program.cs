using System;

namespace wdnmd
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintNames(GenerateNames());
           Console.ReadKey();
        }
         static string[] GenerateNames()
       {
           string[] names = new string[4];
           names[0] = "Gamma";
           names[1] = "Vlissides";
           names[2] = "Johnson";
           names[3] = "Helm";
           return names;
       }
       static void PrintNames(String[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
