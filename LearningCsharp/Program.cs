﻿using System;

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

            Console.WriteLine(jack.GetMarksQuantity());
            double avg = sum / (double)jack.GetMarksQuantity();
            Console.WriteLine($"{jack.Name} {jack.Surname} has average mark: {avg}");

            // Console.WriteLine(jack.Marks.Length);
            // double avg = sum / (double)jack.Marks.Length;
            // Console.WriteLine($"{jack.Name} {jack.Surname} has average mark: {avg}");
        }
    }
}    