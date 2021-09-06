using System;

namespace Lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write the year you wish to check is a leap-year");
            
            var input = Console.ReadLine();
            int year;

            try {
                year = Convert.ToInt32(input);

                if (year < 1582) {
                    Console.WriteLine("You must use a year that is more than 1582");
                    return;
                }
            }
            catch (Exception e) {
                Console.WriteLine("You did not enter a number");
                return;
            }

            Console.WriteLine(new YearManager().IsLeapYear(year));
        }
    }
}
