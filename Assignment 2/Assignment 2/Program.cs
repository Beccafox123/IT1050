using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Count = 0;

            Person p1 = new Person();
            Person p2 = new Person();

            System.Console.WriteLine(" -===+ p1 Information +===- ");
            System.Console.WriteLine();

            p1.InfoNeeded();
            p1.SpouseInfo();

            System.Console.WriteLine();

            System.Console.WriteLine(" -===+ p2 Information +===- ");
            System.Console.WriteLine();

            p2.InfoNeeded();
            p2.SpouseInfo();

            System.Console.WriteLine();

            System.Console.WriteLine(" -===+ Summary +===- ");
            System.Console.WriteLine();

            p1.PrintNameAndAge();
            p2.PrintNameAndAge();

            System.Console.WriteLine();

            System.Console.WriteLine("Average Age = " + Person.AverageAge());

            System.Threading.Thread.Sleep(8000);
        }
    }
}
