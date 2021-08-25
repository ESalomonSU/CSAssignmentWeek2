using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Activity
{
    public class Student
    {
        public string Name;
        public string Major;
        Subjects SemesterSubj = new Subjects();

        public void AddSubjects(params string[] subjects)
        {
            SemesterSubj.Subjects = subjects; 
        }
        public void PrintStudentInfo() 
        {
            Console.WriteLine("Student Name: {0}", Name);
            Console.WriteLine("Major for the student: {0}", Major);
            Console.WriteLine("The classes for this term are:");
            SemesterSubj.Term1();
        }
    }
}