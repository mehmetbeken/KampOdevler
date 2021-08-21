using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(23, "Mehmet");
            isimler.Add(44, "Hamza");
            foreach (var item in isimler.value)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(isimler.Count);
                
        }
    }
}
