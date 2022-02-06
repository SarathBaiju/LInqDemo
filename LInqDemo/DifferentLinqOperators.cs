using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LInqDemo
{
    class DifferentLinqOperators
    {
        public static void Main()
        {
            var names = new string[]
            {
                "sarath", "nandu", "arun","rahul","hari", "aathira","arjun","Aby"
            };

            var students = new List<Student>()
            {
                new Student{Id =1, Name = "sarath"},
                new Student{Id =2, Name = "arun"},
                new Student{Id =3, Name = "hari"},
                new Student{Id =4, Name = "rahul"},
                new Student{Id =5, Name = "nandu"}
            };

            #region Where
            //Where operator
            // i want the names that starts with "a" (arun, aathira, arjun)

            //Lambda expression format
            var namesStartWithA = names.Where(name => name.StartsWith("a"));

            //sql query like syntax
            var namesStartWithAQuery = from name in names
                                       where name.StartsWith("a")
                                       select name;

            //foreach (var name in namesStartWithAQuery)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Aggregation operator

            //var numbers = new int[]
            //{
            //    1,2,34,45,7,8,90,87,23,12,17
            //};

            //// i want to count the elements in numbers array
            //var count = numbers.Count();
            //Console.WriteLine("Count =" + count);

            //// i want to count even  number in the numbers array
            //var countOfEvenNumbers = numbers.Count(number => (number % 2 == 0));
            //Console.WriteLine("Count of even numbers =" + countOfEvenNumbers);



            ////i want to find the sum of all the elements in the numbers array
            //var sum = numbers.Sum();
            //Console.WriteLine("Sum =" + sum);

            ////i want to find the average of the numbers array elements
            //var average = numbers.Average();
            //Console.WriteLine("Avg =" + average);

            ////i want to find the minimum and maximum values in numbers array
            //var minimumValue = numbers.Min();
            //var maximumValue = numbers.Max();
            //Console.WriteLine("Minimum value = " + minimumValue);
            //Console.WriteLine("Maximum value = " + maximumValue);

            #endregion

            #region Projection

            var studentNames = students.Select(student => student.Name);
            var studentIds = students.Select(student => student.Id);

            //foreach (var id in studentIds)
            //{
            //    Console.WriteLine(id);
            //}

            #endregion

            #region Partitioning

            var colors = new string[]
            {
                "violet", "indigo", "red", "green", "yellow", "Blue", "While"
            };

            var colorsBySkipFirstTwo = colors.Skip(2);
            var colorsBySkipFirstTwoAndTakeFour = colors.Skip(2).Take(4);

            //foreach (var color in colorsBySkipFirstTwoAndTakeFour)
            //{
            //    Console.WriteLine(color);
            //}

            #endregion

            #region Ordering: OrderBy, Reverse

            var studentsAscInName = students.OrderBy(student => student.Name);
            var studentsDescInName = students.OrderByDescending(student => student.Name);

            students.Reverse();
            #endregion

            #region GroupBy

            var employees = new List<Employee>()
            {
                new Employee{Id =1, Name = "sarath", Country="India"},
                new Employee{Id =2, Name = "Nandu", Country="India"},
                new Employee{Id =3, Name = "Fabian", Country="Switz"},
                new Employee{Id =4, Name = "Luka", Country="Spain"},
                new Employee{Id =5, Name = "Stefano", Country="Switz"}
            };

            var employeesGroupByCountry = employees.GroupBy(emp => emp.Country);

            foreach (var employeeGroup in employeesGroupByCountry)
            {
                var key = employeeGroup.Key;

                Console.WriteLine(key);

                foreach (var employee in employeeGroup)
                {
                    Console.WriteLine(employee.Name);
                }
                Console.WriteLine("-------------");
                Console.WriteLine();
            }
            
            #endregion
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
