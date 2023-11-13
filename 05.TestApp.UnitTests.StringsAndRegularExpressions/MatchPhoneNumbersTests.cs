using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        string result = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string expected = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = "+359 -2-124-5678, +359 2  986 5432, +359-2-5545-55555";
        string result = "";

        // Act
        string expected = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = "";
        string result = "";

        // Act
        string expected = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, 43049059, +359 2 986 5432, +00359-39-18-9874, +359-2-555-5555";
        string result = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string expected = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
