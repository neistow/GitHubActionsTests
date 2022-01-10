using Xunit;

namespace Application.Tests;

public class CalculatorTests
{
    private readonly ICalculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, -1)]
    [InlineData(-1, 0)]
    public void Add_AddingTwoNumbers_ReturnCorrectResult(int a, int b)
    {
        var result = _calculator.Add(a, b);
        Assert.Equal(result, a + b);
    }
}