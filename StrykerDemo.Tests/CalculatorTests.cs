using Xunit;

namespace StrykerDemo.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator = new();

        [Theory]
        [InlineData(1, 1, 1)]
        public void GivenTwoNumbers_WhenMultipled_ThenResultShouldBeAsExpected(int a, int b, int expected)
        {
            var result = _calculator.Mulitple(a, b);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        public void GivenTwoNumbers_WhenDivided_ThenResultShouldBeAsExpected(int a, int b, int expected)
        {
            var result = _calculator.Divide(a, b);

            Assert.Equal(expected, result);
        }
    }
}