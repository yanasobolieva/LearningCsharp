using System;

namespace LearningCsharp.Lesson1
{
    public class SpeedCounter
    {     
        public void Count()
        {
            Console.Write("Please, enter the distance to the airport in kilometers and press Enter:");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please, enter the time in hours and press Enter:");
            double time = Convert.ToDouble(Console.ReadLine());
            double speed = CountedDriverSpeed(distance, time);
            Console.Write($"You need to drive with speed '{speed} km/h'");
            Console.ReadKey();
        }

        private double CountedDriverSpeed(double Distance, double Time)
        {
            return Distance / Time;
        }
    }    
}
