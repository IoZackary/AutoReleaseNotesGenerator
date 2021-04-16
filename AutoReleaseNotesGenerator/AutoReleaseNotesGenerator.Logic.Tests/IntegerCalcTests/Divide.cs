using AutoReleaseNotesGenerator.Logic;
using Xunit;

namespace IntegerCalcTests
{
    public class Divide
    {
        private readonly IntegerCalc integerCalc;

        public Divide()
        {
            integerCalc = new IntegerCalc();
        }
        [Theory]
        [InlineData(1, 3, 3)]
        [InlineData(52, 46, 0)]
        [InlineData(19, 5, 0)]
        [InlineData(16, 16, 1)]
        [InlineData(1, 70, 70)]
        public void Test1(int a, int b, int result)
        {
            // Arrange

            // Act
            var actual_result = integerCalc.Divide(a, b);

            // Assert
            Assert.Equal(result, actual_result);
        }
    }
}