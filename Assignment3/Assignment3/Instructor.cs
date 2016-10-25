using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public string GetNameAndCourse() { return this.Name + " who teaches " + this.CourseName; }

        public Instructor(string teacherFirstName , string courseName)
        { this.Name = teacherFirstName; this.CourseName = courseName; }

        public void SetStudentGrade(Student student, int grade) { student.SetGrade(grade); }

        public void PrintNameAndCourse() { System.Console.WriteLine(GetNameAndCourse()); }

    }
}
