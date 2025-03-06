using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void IsEven_ShouldReturnTrueForEvenNumbers()
        {
            Assert.True(_calculator.IsEven(2));
            Assert.False(_calculator.IsEven(3));
        }

        [Fact]
        public void Greet_ShouldReturnGreetingMessage()
        {
            Assert.Equal("Hello, hashem!", _calculator.Greet("hashem"));
            Assert.Contains("hashem", _calculator.Greet("hashem"));
            Assert.StartsWith("Hello", _calculator.Greet("hashem"));
        }

        [Fact]
        public void GetEvenNumbers_ShouldReturnAllEvenNumbersUpToMax()
        {
            Assert.Equal([2, 4], _calculator.GetEvenNumbers(5));
            Assert.Empty(_calculator.GetEvenNumbers(0));
            Assert.All(
                _calculator.GetEvenNumbers(5),
                item => Assert.True(item % 2 == 0)
                );
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 4, 6)]
        public void Add_ShouldReturnSumOfTwoNumbers(int x, int y, int expected)
        {
            Assert.Equal(expected, _calculator.Add(x, y));

        }

        [Fact]
        public void GetResultAsObject_ShouldReturnCorrectTypes()
        {
            Assert.IsType<int>(_calculator.GetResultAsObject(true));
            Assert.IsType<string>(_calculator.GetResultAsObject(false));
        }
        [Fact]
        public void GetReference_ShouldReturnSameOrNullReference()
        {
            Assert.Null(_calculator.GetReference(true));
            Assert.Same(_calculator, _calculator.GetReference(false));
        }
    }
}
