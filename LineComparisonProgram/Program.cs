namespace LineComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Program");
            CalculateLength calculateLength = new CalculateLength();
            calculateLength.CalculateLengthOfLine();

        }
    }
}