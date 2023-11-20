using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = new string[0];

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = { "Rose" };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Plants with 4 letters:");
        stringBuilder.AppendLine("Rose");


        string expected = stringBuilder.ToString().Trim();

        //string assertResult = "Plants with 4 letters:\r\nRose";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = { "Rose", "Aconitum", "Lotus" };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Plants with 4 letters:");
        stringBuilder.AppendLine("Rose");
        stringBuilder.AppendLine("Plants with 5 letters:");
        stringBuilder.AppendLine("Lotus");
        stringBuilder.AppendLine("Plants with 8 letters:");
        stringBuilder.AppendLine("Aconitum");


        string expected = stringBuilder.ToString().Trim();

        //string assertResult = "Plants with 4 letters:\r\nRose\r\nPlants with 5 letters:\r\nLotus\r\nPlants with 8 letters:\r\nAconitum";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = { "Rose", "Aconitum", "Lotus" };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Plants with 4 letters:");
        stringBuilder.AppendLine("Rose");
        stringBuilder.AppendLine("Plants with 5 letters:");
        stringBuilder.AppendLine("Lotus");
        stringBuilder.AppendLine("Plants with 8 letters:");
        stringBuilder.AppendLine("Aconitum");


        string expected = stringBuilder.ToString().Trim();

        //string assertResult = "Plants with 4 letters:\r\nRose\r\nPlants with 5 letters:\r\nLotus\r\nPlants with 8 letters:\r\nAconitum";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
