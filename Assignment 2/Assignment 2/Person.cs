using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public static int Count;
        public static double SumOfAllAges;

        public static double AverageAge()
        {
            return Person.SumOfAllAges / Person.Count;
        }

        public void InfoNeeded()
        {
            System.Console.Write("Enter Your First Name: ");
            FirstName = System.Console.ReadLine();

            System.Console.Write("Enter Your Last Name: ");
            LastName = System.Console.ReadLine();

            System.Console.Write("Enter Your Age: ");
            Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += Age;
        }

        public void SpouseInfo()
        {
            this.Spouse = new Person();

            System.Console.Write("Enter Your Spouse's First Name: ");
            Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("Enter Your Spouse's Age: ");
            Spouse.Age = int.Parse(System.Console.ReadLine());

            Person.Count++;
            Person.SumOfAllAges += Age;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetSpouseFullName()
        {   
            return Spouse.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + " " + (Age));
            System.Console.WriteLine(GetSpouseFullName() + " " + (Spouse.Age));
        }



    }
}
