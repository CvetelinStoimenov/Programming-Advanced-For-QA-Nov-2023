using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] inputString = Array.Empty<string>();
        string assertResult = "";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputString);

        // Assert
        CollectionAssert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] inputString = { "hello" };
        string assertResult = "hello";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputString);

        // Assert
        CollectionAssert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] inputString = { "hello", "my", "name", "is" };
        string assertResult = "isnamemyhello";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputString);

        // Assert
        CollectionAssert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] inputString = null;
        string assertResult = "";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputString);

        // Assert
        CollectionAssert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        string[] inputString = { "hello ", "my ", " name", " is" };
        string assertResult = " is namemy hello ";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputString);

        // Assert
        CollectionAssert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        string[] inputString = { "hello ", "my ", " name", " is" };
        string assertResult = " is namemy hello ";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputString);

        // Assert
        CollectionAssert.AreEqual(assertResult, result);
    }
}
