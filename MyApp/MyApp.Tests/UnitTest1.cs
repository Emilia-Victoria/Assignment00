using Xunit;
using System;
namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void isleapYearTrue()
    {
        //Arrange
        
        //Act
        bool result = Program.IsLeapYear(2000);
        //Assert
        Assert.True(result);
    }

    [Fact]
    public void isleapYearFalse()
    {
        //Arrange
        
        //Act
        bool result = Program.IsLeapYear(1999);
        //Assert
        Assert.False(result);
    }
}