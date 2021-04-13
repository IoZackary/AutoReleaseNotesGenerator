using Xunit;

namespace AutoReleaseNotesGenerator.Logic.Tests.DoubleCalcTests
{
    public class Add
    {
        private readonly DoubleCalc doubleCalc;

        public Add()
        {
            doubleCalc = new DoubleCalc();
        }
        [Theory]
        [InlineData(1, 3, 4)]
        [InlineData(52, 46, 98)]
        [InlineData(19, 5, 24)]
        [InlineData(16, 16, 32)]
        [InlineData(1, 70, 71)]
        public void Test1(int a, int b, int result)
        {
            // Arrange

            // Act
            var actual_result = doubleCalc.Add(a, b);

            // Assert
            Assert.Equal(result, actual_result);
        }
    }
}
