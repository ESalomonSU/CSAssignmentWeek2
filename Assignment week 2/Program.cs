using System;

namespace Week2Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            var student2 = new Student();
            student1.Name = "Esteban Salomon";
            student1.Major = "Web Dev.";
            student1.AddSubjects("English", "C#", "OOP", "JS");
            student1.PrintStudentInfo();

            student2.Name = "Salomon";
            student2.Major = "Economy";
            student2.AddSubjects("intro to economy");
            student2.PrintStudentInfo();
        }
    }
}