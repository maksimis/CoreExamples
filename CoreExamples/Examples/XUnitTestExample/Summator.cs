using System;

namespace CoreExamples.Examples.XUnitTestExample
{
    public static class Summator
    {
        public static long Summ(long value1, long value2)
        {
            var result = value1 + value2;

            if (value1 > 0 && value2 > 0 && result < 0) throw new ArgumentOutOfRangeException();
            if (value1 < 0 && value2 < 0 && result > 0) throw new ArgumentOutOfRangeException();

            return value1 + value2;
        }
    }
}