using AutoReleaseNotesGenerator.Interfaces;

namespace AutoReleaseNotesGenerator.Logic
{
    public class DoubleCalc : ICalc<double>
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            return b / a;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
