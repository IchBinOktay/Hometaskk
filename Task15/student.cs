using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    internal class Student
    {
        private Grade[] grades;
        public Grade[] Grades { get => grades; }
        public Student()
        {
            grades = new Grade[0];
        }

        public void Add(Grade grade)
        {
            Array.Resize(ref grades, grades.Length + 1);
            grades[grades.Length - 1] = grade;

        }

        public void GetAll()
        {
            foreach (var grade in grades)
            {
                grade.GetDetails();
            }
        }
    }
}
