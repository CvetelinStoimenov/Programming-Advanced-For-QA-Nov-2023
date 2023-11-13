using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("abcdef", 2, "aBcDeFaBcDeF")]
    [TestCase("abc", 1, "aBc")]
    [TestCase("abcdef", 10, "aBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeF")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repetitionFactor = 10;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abcdef";
        int repetitionFactor = -20;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);

    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abcdef";
        int repetitionFactor = 0;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }
}
