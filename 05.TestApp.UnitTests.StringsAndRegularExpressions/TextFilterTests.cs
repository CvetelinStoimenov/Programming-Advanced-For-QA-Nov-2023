using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { "bear" };
        string input = "The quick brown fox jumps over the lazy dog";
        string assertResult = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = {"quick" };
        string input = "The quick brown fox jumps over the lazy dog";
        string assertResult = "The ***** brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string input = "The quick brown fox jumps over the lazy dog";
        string assertResult = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = { "quick " };
        string input = "The quick brown fox jumps over the lazy dog";
        string assertResult = "The ******brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.AreEqual(assertResult, result);
    }
}