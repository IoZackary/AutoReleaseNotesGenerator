using AutoReleaseNotesGenerator.Logic;
using Xunit;

namespace DoubleCalcTests
{
    public class Multiply
    {
        private readonly DoubleCalc doubleCalc;

        public Multiply()
        {
            doubleCalc = new DoubleCalc();
        }
        [Theory]
        [InlineData(7.8, 5.3, 41.339999999999996)]
        [InlineData(5.2, 4.6, 23.919999999999998)]
        [InlineData(1.9, 5, 9.5)]
        [InlineData(1.6, 1.6, 2.5600000000000005)]
        [InlineData(.1, .7, 0.06999999999999999)]
        public void Test1(double a, double b, double result)
        {
            // Arrange

            // Act
            var actual_result = doubleCalc.Multiply(a, b);

            // Assert
            Assert.Equal(result, actual_result);
        }
    }
}