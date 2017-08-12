using System;
using System.Linq;

namespace Multiplik
{
    public class MultiplyThirdSolution : IMultiply
    {
        public long Multiply(int first, int second)
        {
            var sum = Enumerable.Repeat(second, Math.Abs(first)).Sum();

            return first < 0 ? -sum : sum;
        }
    }
}