using Xunit;

namespace AutoReleaseNotesGenerator.Logic.Tests.DoubleCalcTests
{

    public class Divide
    {
        private readonly DoubleCalc doubleCalc;

        public Divide()
        {
            doubleCalc = new DoubleCalc();
        }
        [Theory]
        [InlineData(7.8, 5.3, 0.67948717948717948717948717948718)]
        [InlineData(5.2, 4.6, 0.8846153846153845)]
        [InlineData(1.9, 5, 2.6315789473684211)]
        [InlineData(1.6, 1.6, 1)]
        [InlineData(.1, .7, 6.999999999999999)]
        public void Test1(double a, double b, double result)
        {
            // Arrange

            // Act
            var actual_result = doubleCalc.Divide(a, b);

            // Assert
            Assert.Equal(result, actual_result);
        }
    }
}