using System;

namespace Multiplik
{
    public class TestMultiply
    {
        private static void AssertEqual(long actual, long expected)
        {
            if(expected != actual)
                throw new InvalidOperationException(
                    $"Actual ({actual}) is not equal expected ({expected}).");

            // Console.WriteLine($"Expected ({expected}) equals actual ({actual}).");
        }

        public int CheckSolution(IMultiply multiply)
        {
            AssertEqual(multiply.Multiply(1, 2), 2);
            AssertEqual(multiply.Multiply(1, -2), -2);
            AssertEqual(multiply.Multiply(-1, -2), 2);
            AssertEqual(multiply.Multiply(-1, 2), -2);
            AssertEqual(multiply.Multiply(10, 5), 50);
            AssertEqual(multiply.Multiply(-10,  5), -50);
            AssertEqual(multiply.Multiply(10, -5), -50);
            AssertEqual(multiply.Multiply(-10, -5), 50);

            return 8; // number of tests (AssertEqual) performed
        }
    }
}
