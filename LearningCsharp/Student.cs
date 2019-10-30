using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    public class Student
    {
        public String Name { get; private set; }
        public String Surname { get; private set; }
        public int[] Marks { get; private set; }
        private int StartCount = 0;

        public Student(string firstName, string lastName) 
        {
            Name = firstName;
            Surname = lastName;
            Marks = new int[1];
        }

        public void AddMark(int mark)
        {
            if (mark >= 1 && mark <= 12)
            {
                if (Marks.Length == StartCount)
                {
                    int[] temporaryMarks = new int[(Marks.Length + 1)];
                    Array.Copy(Marks, temporaryMarks, Marks.Length);
                    Marks = temporaryMarks;
                }

                Marks[StartCount] = mark;
                StartCount++;                               
            }           
        }
         
        public int[] GetMarks()
        {
            return Marks;
        }
    }
}
