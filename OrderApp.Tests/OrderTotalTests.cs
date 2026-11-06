using Xunit;

namespace OrderApp.Tests;

public class OrderTotalTests
{
    [Theory]
    [InlineData(20, 3, 0, 60)]
    [InlineData(20, 3, 10, 54)]
    [InlineData(25, 2, 20, 40)]
    public void CalculateAppliesPercentageDiscount(
        decimal unitPrice, int quantity, decimal discountPercent, decimal expected)
    {
        var actual = OrderTotal.Calculate(unitPrice, quantity, discountPercent);

        Assert.Equal(expected, actual);
    }
}
