using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {

            // Arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // Act
            var result = book.GetStatistics();

            // Assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High,1 );
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);

        }

        [Fact]
        public void AddedGradeIsBetween0And100()
        {
            var book = new InMemoryBook("");
            book.AddGrade(100);
            book.AddGrade(0);
            book.AddGrade(101);
            book.AddGrade(-1);

            var result = book.GetStatistics();

            Assert.Equal(0, result.Low);
            Assert.Equal(100, result.High);
            Assert.Equal(50, result.Average);
        }
    }
}
