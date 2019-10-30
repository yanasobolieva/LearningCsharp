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
        public List<int> Marks { get; private set; }

        public Student(string firstName, string lastName) 
        {
            Name = firstName;
            Surname = lastName;
            Marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            if (mark >= 1 && mark <= 12)
            {
                Marks.Add(mark);
            }           
        }
         
        public List<int> GetMarks()
        {
            return Marks;
        }
    }
}
