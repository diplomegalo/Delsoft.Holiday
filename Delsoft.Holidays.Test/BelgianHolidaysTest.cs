using System;
using Shouldly;
using Xunit;

namespace Delsoft.Holiday.Test;

public class BelgianHolidaysTest
{
    [Fact]
    public void Can_Get_NewYear()
    {
        // Arrange
        var expected = new DateTime(DateTime.Today.Year, 1, 1);

        // Assert
        Holidays.Belgian.NewYear.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Can_Get_Easter()
    {
        // Arrange
        var expected = new DateTime(2022, 04, 17);

        // Assert
        Holidays.Belgian.ForYear(2022).Easter.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Can_Get_EasterMonday()
    {
        // Arrange
        var expected = new DateTime(2022, 4, 18);
        
        // Assert
        Holidays.Belgian.ForYear(2022).EasterMonday.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Can_Get_LaborDay()
    {
        // Arrange
        var expected = new DateTime(DateTime.Today.Year, 5, 1);
        
        // Assert
        Holidays.Belgian.LaborDay.ShouldBeEquivalentTo(expected);
    }

    [Fact]
    public void Can_Get_Ascent()
    {
        // Arrange
        var expected = new DateTime(2022, 5, 26);
        
        // Assert
        Holidays.Belgian.ForYear(2022).Ascent.ShouldBeEquivalentTo(expected);
    }
    
    [Fact]
    public void Can_Get_PentecostMonday()
    {
        // Arrange
        var expected = new DateTime(2022, 6, 6);
        
        // Assert
        Holidays.Belgian.ForYear(2022).PentecostMonday.ShouldBeEquivalentTo(expected);
    }
    
    [Fact]
    public void Can_Get_NationalHoliday()
    {
        // Arrange
        var expected = new DateTime(DateTime.Today.Year, 7, 21);
        
        // Assert
        Holidays.Belgian.NationalHoliday.ShouldBeEquivalentTo(expected);
    }
    
    [Fact]
    public void Can_Get_Assumption()
    {
        // Arrange
        var expected = new DateTime(DateTime.Today.Year, 8, 15);
        
        // Assert
        Holidays.Belgian.Assumption.ShouldBeEquivalentTo(expected);
    }
    
    [Fact]
    public void Can_Get_Toussaint()
    {
        // Arrange
        var expected = new DateTime(DateTime.Today.Year, 11, 1);
        
        // Assert
        Holidays.Belgian.Toussaint.ShouldBeEquivalentTo(expected);
    }
    
    [Fact]
    public void Can_Get_Armistice()
    {
        // Arrange
        var expected = new DateTime(DateTime.Today.Year, 11, 11);
        
        // Assert
        Holidays.Belgian.Armistice1918.ShouldBeEquivalentTo(expected);
    }
    
    [Fact]
    public void Can_Get_Christmas()
    {
        // Arrange
        var expected = new DateTime(DateTime.Today.Year, 12, 25);
        
        // Assert
        Holidays.Belgian.Christmas.ShouldBeEquivalentTo(expected);
    }
}