using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LInqDemo
{
    class WithLinqLambda
    {
        static void Main()
        {
            var numbersArray = new int[] { 1, 20, 30, 4, 55, 43, 34, 36, 43, 90, 80, 2, 99 };

            var outputArray = numbersArray.Where(s => s > 30).OrderByDescending(s => s);

            foreach (var item in outputArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
