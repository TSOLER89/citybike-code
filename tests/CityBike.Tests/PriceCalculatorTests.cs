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


    [Fact]
    public void Calculate_0Seconds_ReturnsUnlockFee10()
    {
        // Arrange
        int seconds = 0;

        // Act
        decimal price = _calculator.Calculate(seconds);

        // Assert
        Assert.Equal(10m, price);
    }

    [Fact]
    public void Calculate_100Minutes_ReturnsMaxPrice250()
    {
        // Arrange
        int seconds = 100 * 60;

        // Act
        decimal price = _calculator.Calculate(seconds);

        // Assert
        Assert.Equal(250m, price);
    }

    [Fact]
    public void Calculate_61Seconds_Returns15()
    {
        // Arrange
        int seconds = 61;

        // Act
        decimal price = _calculator.Calculate(seconds);

        // Assert
        Assert.Equal(15m, price);
    }

    [Fact]
    public void Calculate_NegativeSeconds_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        int seconds = -1;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(
            () => _calculator.Calculate(seconds));
    }
}