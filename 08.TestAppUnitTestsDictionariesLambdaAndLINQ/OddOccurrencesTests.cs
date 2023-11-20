using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[0];

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "the", "the"};

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = { "hi"};

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("hi"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = { "hi", "aa", "the", "the", "asda", "aa aa" };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("hi ");
        stringBuilder.Append("aa ");
        stringBuilder.Append("asda ");
        stringBuilder.Append("aa ");
        stringBuilder.Append("aa ");

        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "Hi", "aa", "ASda" };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("hi ");
        stringBuilder.Append("aa ");
        stringBuilder.Append("asda");

        string expected = stringBuilder.ToString().Trim();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithEmptyArrayString_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
