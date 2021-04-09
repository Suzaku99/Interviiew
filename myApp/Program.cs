using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name1 = { "Mary", "John", "Peter", "Ann", "Barbara"};
            List<string> list1 = new List<string>(name1);
            list1 = list1.OrderBy(i => Guid.NewGuid()).ToList();
            for(int i = 0; i<list1.Count; i++)
            {
                try
                {
                    Console.WriteLine($"{list1[i]}, {list1[i+1]}");
                }
                catch {
                    Console.WriteLine($"{list1[4]}, {list1[0]}");
                }
            }
        }
    }
}
