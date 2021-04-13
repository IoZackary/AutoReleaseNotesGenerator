namespace AutoReleaseNotesGenerator.Interfaces
{
    public interface ICalc<T>
    {
        public T Add(T a, T b);
        public T Subtract(T a, T b);
        public T Multiply(T a, T b);
        public T Divide(T a, T b);
    }
}