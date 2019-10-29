using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp.Lesson1
{
    class EvenCheck
    {
        public void Check()
        {
            Console.Write("Please, enter some digit and press Enter:");
            int someDigit = Convert.ToInt32(Console.ReadLine());
            if (someDigit % 2 == 0)
            {
                Console.Write("You have entered an even digit!");
                Console.ReadKey();
            }
            else
            {
                Console.Write("You have entered an odd digit!");
                Console.ReadKey();
            }
        }
    }
}
