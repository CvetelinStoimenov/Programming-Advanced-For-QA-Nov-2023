using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string csvData = "";
        string[] expectedResult = Array.Empty<string>();

        // Act
        string[] result = CsvParser.ParseCsv(csvData);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string csvData = "csvparse";
        string[] expectedResult = { "csvparse" };

        // Act
        string[] result = CsvParser.ParseCsv(csvData);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string csvData = "Parsecsv,Multiple,Fields,Returns,Array,With,Multiple,Elements";
        string[] expectedResult = { "Parsecsv", "Multiple", "Fields", "Returns", "Array", "With", "Multiple", "Elements" };

        // Act
        string[] result = CsvParser.ParseCsv(csvData);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string csvData = "Parsecsv   ,   Multiple   ,   Fields  , Returns , Array  ,  With ,   Multiple  ,      Elements";
        string[] expectedResult = { "Parsecsv", "Multiple", "Fields", "Returns", "Array", "With", "Multiple", "Elements" };

        // Act
        string[] result = CsvParser.ParseCsv(csvData);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
