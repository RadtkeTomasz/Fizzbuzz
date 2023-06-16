namespace Oponeo.UnitTests.Implementation
{
    public class Fibonacci
    {
        public int CalculateFibonacciIndexValue(int index)
        {
            if ( index < 0 )
                throw new ArgumentOutOfRangeException();
            if ( index == 0 || index == 1 )
                return index;
            return CalculateFibonacciIndexValue(index - 1) + CalculateFibonacciIndexValue(index - 2);
        }
    }
}
