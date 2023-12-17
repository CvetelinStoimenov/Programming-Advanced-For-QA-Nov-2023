using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;
        Dictionary<int, int> expected = new Dictionary<int, int>();

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 8;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            {8, 1 }
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 123456789;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            {1, 1},
            {2, 1},
            {3, 1},
            {4, 1},
            {5, 1},
            {6, 1},
            {7, 1},
            {8, 1},
            {9, 1},
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -8;
        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            {8, 1 }
        };

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
