using CoreExamples.Examples.XUnitTestExample;
using System;
using Xunit;

namespace CoreExamplesTests
{
    public class XUnitTestExampleTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(-1, 1, 0)]
        [InlineData(long.MaxValue - 1, 1, long.MaxValue)]
        [InlineData(long.MinValue + 1, -1, long.MinValue)]
        public void SummatorTest(long value1, long value2, long expectedSumm)
        {
            //Act
            long actualSumm = Summator.Summ(value1, value2);

            //Assert
            Assert.Equal(expectedSumm, actualSumm);
        }

        [Theory]
        [InlineData(long.MaxValue, 1)]
        [InlineData(long.MinValue, -1)]
        public void SummatorTestOutOfRange(long value1, long value2)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Summator.Summ(value1, value2));
        }
    }
}