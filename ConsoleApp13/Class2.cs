using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            ArrayList list = new ArrayList();
            list.Add(45);  
            list.Add(67);
            list.Add(11);
            list.Add(88);
            list.Insert(1, 15);

            list.Remove("hello");
            list.RemoveAt(3);

            list.Sort();
            list.Reverse();
            list.AddRange(arr);

            list.RemoveRange(2, 3);
            list.Clear();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total elements {list.Count}");
        }

    }
}

