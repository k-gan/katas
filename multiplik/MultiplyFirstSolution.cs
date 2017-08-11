using System;

namespace Multiplik
{
    public class MultiplyFirstSolution : IMultiply
    {
        public long Multiply(int first, int second)
        {
            var firstAbs = Math.Abs(first);
            var secondAbs = Math.Abs(second);

            var sum = 0;
            for(var i = 0; i < firstAbs; i++)
                sum += secondAbs;
            
            if(first < 0) sum = -sum;
            if(second < 0) sum = -sum;

            return sum;
        }
    }
}