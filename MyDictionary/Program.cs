using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryManager<int, string> takmaisim = new DictionaryManager<int, string>();
            takmaisim.Add(43,"Kütahya");
            takmaisim.Add(10, "Balıkkesir");
            takmaisim.Add(09, "Aydın");

            takmaisim.listeleme();

            Console.WriteLine("---------------------------  ");
            Console.WriteLine("SMTcoder");
        }
    }
}
