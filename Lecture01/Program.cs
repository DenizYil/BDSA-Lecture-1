using System;

namespace Lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write the year you wish to check is a leap-year");
            
            var input = Console.ReadLine();
            var year = Convert.ToInt32(input);

            Console.WriteLine(new YearManager().IsLeapYear(year));
        }
    }
}
