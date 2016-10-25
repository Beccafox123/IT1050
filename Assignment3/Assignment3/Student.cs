using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student() { Grade = 0; }
        public int GetGrade() { return this.Grade; }
        public void SetGrade(int x) { this.Grade = x; }

        public Student(string name, Instructor theTeacher) { this.Name = name; this.Teacher = theTeacher; }


        public void PrintStudentInfo()
        { System.Console.WriteLine("Name : " + this.Name + "  Grade: " + this.Grade + "  Teacher: " + Teacher.GetNameAndCourse()); }

        

        



    }
}
