using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "wwwHi no Valid. url";
        List<string> assertResult = new();

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "https://regex101.com/";
        List<string> assertResult = new() { "https://regex101.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "https://regex101.com/, https://www.abv.bg/ https://softuni.bg/trainings/live/details?trainingLabId=97";
        List<string> assertResult = new() { "https://regex101.com", "https://www.abv.bg", "https://softuni.bg" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.AreEqual(assertResult, result);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "https://softuni.bg/trainings/live/details?trainingLabId=97";
        List<string> assertResult = new() { "https://softuni.bg" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.AreEqual(assertResult, result);
    }
}
