using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruitDictionary = new Dictionary<string, int>()
        {
            ["lemon"] = 10,
            ["orange"] = 20,
            ["banana"] = 30,
        };
        string fruitName = "banana";
        int expectedResult = 30;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new Dictionary<string, int>()
        {
            { "lemon", 10 },
            { "orange", 20},
            { "banana", 30}
        };
        string? fruitName = "kiwi";
        int expectedResult = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new Dictionary<string, int>();
        string? fruitName = "banana";
        int expectedResult = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = null;
        string? fruitName = "banana";
        int expectedResult = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new Dictionary<string, int>()
        {
            { "lemon", 10 },
            { "orange", 20},
            { "banana", 30}
        };
        string? fruitName = null;
        int expectedResult = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
