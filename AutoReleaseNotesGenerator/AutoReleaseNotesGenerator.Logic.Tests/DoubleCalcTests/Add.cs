using AutoReleaseNotesGenerator.Logic;
using Xunit;

namespace DoubleCalcTests
{
    public class Add
    {
        private readonly DoubleCalc doubleCalc;

        public Add()
        {
            doubleCalc = new DoubleCalc();
        }
        [Theory]
        [InlineData(7.8, 5.3, 13.1)]
        [InlineData(5.2, 4.6, 9.8)]
        [InlineData(1.9, 5, 6.9)]
        [InlineData(1.6, 1.6, 3.2)]
        [InlineData(8.1, 7.7, 15.8)]
        public void Test1(double a, double b, double result)
        {
            // Arrange

            // Act
            var actual_result = doubleCalc.Add(a, b);

            // Assert
            Assert.Equal(result, actual_result);
        }
    }
}