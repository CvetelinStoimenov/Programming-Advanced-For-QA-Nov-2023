using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> nums = new List<int>();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int>() { 2, 1, 3, 5, 4 };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Even numbers: 2, 4");
        stringBuilder.AppendLine("Odd numbers: 1, 3, 5");

        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int>() { 2, 6, 4, 8, 4 };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Even numbers: 2, 6, 4, 8, 4");

        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int>() { 7, 1, 3, 5, 9 };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Odd numbers: 7, 1, 3, 5, 9");

        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int>() { -2, -1, -3, -5, -4 };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Even numbers: -2, -4");
        stringBuilder.AppendLine("Odd numbers: -1, -3, -5");

        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
