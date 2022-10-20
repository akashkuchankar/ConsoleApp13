using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  double salary = 33000.56;

            //  StringBuilder sb = new StringBuilder("hello to all");
            // sb.Append("welcome to C# class");

            //  sb.AppendFormat("salary is {0:C}", salary);
            //  Console.WriteLine(sb);

            // sb.Insert(13, "Good Morning");
            //  Console.WriteLine(sb);

            //  sb.Remove(0, 12);
            //sb.Replace("Good Morning", "Good Day");
            // Console.WriteLine(sb);
            Book[] book = new Book[3]
            {
                new Book { Id = 1, Name = "GK", Publisher = "gupta", Price = 300 },
                 new Book { Id = 2, Name = "current affair", Publisher = "jk gupta", Price = 150 },
                  new Book { Id = 3, Name = "static Gk", Publisher = "honda", Price = 145 }

            };
            foreach (Book b in book)
            {
                Console.WriteLine($"{b.Id}{b.Name}{b.Publisher}{b.Price}");

            }
            Course[] c = new Course[3]
            {
                new Course { Id = 1, Name = ".Net", Duration = 2, Fees = 3000000 },
                 new Course{ Id = 2, Name = "Java", Duration = 3, Fees = 1500000 },
                  new Course{ Id = 3, Name = "c++", Duration = 2, Fees = 1450000 }

            };
            foreach (Course b in c)
            {
                Console.WriteLine($"{b.Id}{b.Name}{b.Duration}{b.Fees}");

            }
        }    }
}
