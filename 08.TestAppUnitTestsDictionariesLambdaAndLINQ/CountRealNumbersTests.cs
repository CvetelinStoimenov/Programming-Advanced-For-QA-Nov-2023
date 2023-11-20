using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{

    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] nums = new int[0];

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = { 1 };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("1 -> 1");
        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = { 2, 5, 1, 18, 1, 5, 2, 2 };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("1 -> 2");
        stringBuilder.AppendLine("2 -> 3");
        stringBuilder.AppendLine("5 -> 2");
        stringBuilder.AppendLine("18 -> 1");
        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = { -1, -2, -3, -1, -2, -1, -3, -2 };

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine("-3 -> 2");
        stringBuilder.AppendLine("-2 -> 3");
        stringBuilder.AppendLine("-1 -> 3");
        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = { 0, 0, 0, 0 };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("0 -> 4");
        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
