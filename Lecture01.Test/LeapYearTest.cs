using System;
using Xunit;

namespace Lecture01.Test
{
    public class LeapYearTest
    {
        [Fact]
        public void YearManager_is_leap_year_returns_correct_leap_year()
        {
            // Arrange
            YearManager yearManager = new YearManager();

            // Act & Assert
            foreach (int correct in new int[] {2000, 1600, 2024})
            {
                Assert.True(yearManager.IsLeapYear(correct));
            }

            foreach (int incorrect in new int[] {1700, 1500, 2023})
            {
                Assert.False(yearManager.IsLeapYear(incorrect));
            }
        }
    }
}
