using AutoReleaseNotesGenerator.Logic;
using Xunit;

namespace DoubleCalcTests
{
    public class Subtract
    {
        private readonly DoubleCalc doubleCalc;

        public Subtract()
        {
            doubleCalc = new DoubleCalc();
        }
        [Theory]
        [InlineData(7.8, 5.3, 2.5)]
        [InlineData(5.2, 4.6, 0.6000000000000005)]
        [InlineData(1.9, 5, -3.1)]
        [InlineData(1.6, 1.6, 0)]
        [InlineData(.1, .7, -.6)]
        public void Test1(double a, double b, double result)
        {
            // Arrange

            // Act
            var actual_result = doubleCalc.Subtract(a, b);

            // Assert
            Assert.Equal(result, actual_result);
        }
    }
}