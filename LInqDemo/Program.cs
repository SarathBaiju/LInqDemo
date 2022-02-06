//using System;
//using System.Linq;

//namespace LInqDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var numbersArray = new int[] { 1, 20, 30, 4, 55, 43, 34, 36, 43, 90, 80, 2, 99 };

//            var outputArray = from output in numbersArray
//                              where output > 30
//                              orderby output descending
//                              select output;

//            foreach (var output in outputArray)
//            {
//                Console.Write(output + " ");
//            }
//        }

//    }
//}
