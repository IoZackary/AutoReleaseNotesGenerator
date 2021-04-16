using AutoReleaseNotesGenerator.Logic;
using Xunit;

namespace IntegerCalcTests
{
    public class Multiply
    {
        private readonly IntegerCalc integerCalc;

        public Multiply()
        {
            integerCalc = new IntegerCalc();
        }
        [Theory]
        [InlineData(1, 3, 3)]
        [InlineData(52, 46, 2392)]
        [InlineData(19, 5, 95)]
        [InlineData(16, 16, 256)]
        [InlineData(1, 70, 70)]
        public void Test1(int a, int b, int result)
        {
            // Arrange

            // Act
            var actual_result = integerCalc.Multiply(a, b);

            // Assert
            Assert.Equal(result, actual_result);
        }
    }
}
