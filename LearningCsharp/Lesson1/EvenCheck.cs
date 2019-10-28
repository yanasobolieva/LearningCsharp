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
            Console.Write("Введите число:");
            int someDigit = Convert.ToInt32(Console.ReadLine());
            if (someDigit % 2 == 0)
            {
                Console.Write("Введено четное число");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Введено нечетное число");
                Console.ReadKey();
            }
        }
    }
}
