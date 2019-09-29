using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var book = new Book("Ryan's Grade Book");

            while (true)
            {
                Console.WriteLine("Enter a grade or type 'q' to quit.");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                else
                {
                    book.AddGrade(double.Parse(input));
                }
                
            }
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
