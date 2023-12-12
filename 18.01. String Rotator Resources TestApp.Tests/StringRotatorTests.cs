using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int positions = 2;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "ExamPreparation";
        int positions = 0;
        string expectedResult = "ExamPreparation";

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "ExamPreparation";
        int positions = 2;
        string expectedResult = "onExamPreparati";

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "ExamPreparation";
        int positions = -2;
        string expectedResult = "onExamPreparati";

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "ExamPreparation";
        int positions = 17;
        string expectedResult = "onExamPreparati";

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
