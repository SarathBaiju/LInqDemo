using System;
using System.Collections.Generic;
using System.Text;

namespace LInqDemo
{
    class WithOutLInq
    {
        static void Main()
        {
            var numbersArray = new int[] { 1, 20, 30, 4, 55, 43, 34, 36, 43, 90, 80, 2, 99 };

            var count = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > 30)
                {
                    count++;
                }
            }

            var outputArray = new int[count];
            var index = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > 30)
                {
                    outputArray[index] = numbersArray[i];
                    index++;
                }
            }

            foreach (var output in outputArray)
            {
                Console.Write(output + ", ");
            }
        }
    }
}
