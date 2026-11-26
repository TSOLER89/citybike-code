using CityBike.Core;
using Xunit;

namespace CityBike.Tests;

public class PriceCalculatorTests
{
    //Arrange
    private readonly PriceCalculator _calculator = new();

    [Fact]
    public void Calculate_18Minutes_Returns55()
    {
        //Act
        decimal price = _calculator.Calculate(18 * 60);

        //Assert
        Assert.Equal(55m, price);
    }
}