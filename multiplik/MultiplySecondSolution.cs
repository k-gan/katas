namespace Multiplik
{
    public class MultiplySecondSolution : IMultiply
    {
        public long Multiply(int first, int second)
        {
            var positive = (first < 0 && second < 0) || (first >= 0 && second >= 0);

            if(first < 0) first = -first;
            if(second < 0) second = -second;

            var sum = 0;
            for(var i = 0; i < first; i++)
                sum += second;
            
            return positive ? sum : -sum;
        }
    }
}