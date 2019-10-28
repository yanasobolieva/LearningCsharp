using System;

namespace LearningCsharp.Lesson1
{
    public class SpeedCounter
    {     
        public void Count()
        {
            Console.Write("Введите расстояние до аэропорта в километрах и нажмите Enter:");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время за которое нужно добраться до аэропорта в часах и нажмите Enter:");
            double time = Convert.ToDouble(Console.ReadLine());
            double speed = CountedDriverSpeed(distance, time);
            Console.Write($"Вы должны ехать со скоростью {speed} км/ч");
            Console.ReadKey();
        }

        private double CountedDriverSpeed(double Distance, double Time)
        {
            return Distance / Time;
        }
    }    
}
