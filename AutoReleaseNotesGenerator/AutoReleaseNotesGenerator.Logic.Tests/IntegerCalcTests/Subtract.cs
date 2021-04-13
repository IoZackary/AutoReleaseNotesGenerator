using AutoReleaseNotesGenerator.Logic;
using Xunit;

namespace IntegerCalcTests
{
    public class Subtract
    {
        private readonly IntegerCalc integerCalc;

        public Subtract()
        {
            integerCalc = new IntegerCalc();
        }
        [Theory]
        [InlineData(1, 3, -2)]
        [InlineData(52, 46, 6)]
        [InlineData(19, 5, 14)]
        [InlineData(16, 16, 0)]
        [InlineData(1, 70, -69)]
        public void Test1(int a, int b, int result)
        {
            // Arrange

            // Act
            var actual_result = integerCalc.Subtract(a, b);

            // Assert
            Assert.Equal(result, actual_result);
        }
    }
}
