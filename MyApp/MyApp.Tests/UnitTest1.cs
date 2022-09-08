using Xunit;
using System;
namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void isleapYearTrue()
    {
        //Arrange
        var p = new Program();
        //Act
        bool result = p.IsLeapYear(20);
        //Assert
        Assert.True(result);
    }

    [Fact]
    public void isleapYearFalse()
    {
        //Arrange
        var p = new Program();
        //Act
        bool result = p.IsLeapYear(19);
        //Assert
        Assert.False(result);
    }
}