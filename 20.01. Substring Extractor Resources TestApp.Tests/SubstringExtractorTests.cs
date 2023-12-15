using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "aaabbbccc";
        string startMarker = "aaa";
        string endMarker = "ccc";
        string expectedResult = "bbb";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaabbbccc";
        string startMarker = "fff";
        string endMarker = "ccc";
        string expectedResult = "Substring not found";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaabbbccc";
        string startMarker = "aaa";
        string endMarker = "ggg";
        string expectedResult = "Substring not found";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaabbbccc";
        string startMarker = "fff";
        string endMarker = "ggg";
        string expectedResult = "Substring not found";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "";
        string startMarker = "aaa";
        string endMarker = "ggg";
        string expectedResult = "Substring not found";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "aaabbbccc";
        string startMarker = "aaab";
        string endMarker = "bbb";
        string expectedResult = "Substring not found";

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
