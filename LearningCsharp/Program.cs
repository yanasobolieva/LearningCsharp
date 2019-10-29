using System;

namespace LearningCsharp.Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIfDigitIsEven();
            CalculateDistance();
            CalculateResistance();
            FindMaxValue();
            Console.ReadKey();
        }

        static void CheckIfDigitIsEven()
        {
            Console.WriteLine("Please, enter some digit and press Enter:");
            int someDigit = Convert.ToInt32(Console.ReadLine());
            EvenCheck evenCheck = new EvenCheck();
            if (evenCheck.IsEven(someDigit))
            {
                Console.WriteLine("You have entered an even digit!");
            }
            else
            {
                Console.WriteLine("You have entered an odd digit!");
            }
        }

        static void CalculateDistance()
        {
            Console.WriteLine("Please, enter the distance to the airport in kilometers and press Enter:");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, enter the time in hours and press Enter:");
            double time = Convert.ToDouble(Console.ReadLine());
            SpeedCounter speedCounter = new SpeedCounter();
            double speed = speedCounter.CountDriverSpeed(distance, time);
            Console.WriteLine($"You need to drive with speed '{speed} km/h'");
        }

        static void CalculateResistance()
        {
            ResistanceCounter resistanceCounter = new ResistanceCounter();
            Console.WriteLine($"The resistance R0 value is '{resistanceCounter.CountResistance(2, 4, 8)}' \n");
        }

        static void FindMaxValue()
        {
            bool firstInput = true;
            int maxValue = 0;
            for (int i = 0; i < 7; i++)
            {
                var currentEnteredValue = Convert.ToInt32(Console.ReadLine());
                if (firstInput)
                {
                    maxValue = currentEnteredValue;
                    firstInput = false;
                }
                else if (currentEnteredValue > maxValue)
                {
                    maxValue = currentEnteredValue;
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
