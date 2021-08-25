using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Activity
{
    public class Program
    {
        public string[] Subjects;

        public void Term1()
        {
            for(int i = 0; i< Subjects.Length; i++)
            {
                Console.WriteLine(Subjects[i]);
            }
        }
    }
}