using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");
            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);


            Jane.PrintStudentInfo();
            System.Console.WriteLine();
            Joe.PrintStudentInfo();
            System.Console.WriteLine();
            Melissa.PrintStudentInfo();
            System.Console.WriteLine();
            Matt.PrintStudentInfo();

            System.Threading.Thread.Sleep(8000);

        }
    }
}
