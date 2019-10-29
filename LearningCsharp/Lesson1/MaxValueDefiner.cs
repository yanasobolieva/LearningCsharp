using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp.Lesson1
{
    class MaxValueDefiner
    {

        public void DefineMaxValue()
        { 
            int[] enteredDigits = new int[7];
            for (int i = 0; i < enteredDigits.Length; i++)
            {
                Console.Write("Please, enter integer and press Enter:");
                enteredDigits[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"You have entered '{enteredDigits[i]}'. Please, continue \n");
            }
            Console.Write($"The max entered digit is '{enteredDigits.Max()}'");
            Console.ReadKey();
        }
    }
}
