using System;

namespace LearningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student jack = new Student("Jack", "Unknown");
            jack.AddMark(5);
            jack.AddMark(4);
            jack.AddMark(-4); // в массив такое число не добавляем.
            int sum = 0;
            foreach (var mark in jack.GetMarks())
            {
                sum += mark;
            }
            Console.WriteLine(jack.GetMarks().Length);
            double avg = sum / (double)jack.GetMarks().Length;
            Console.WriteLine($"{jack.Name} {jack.Surname} has average mark: {avg}");
        }
    }
}    