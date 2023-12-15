using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            ["Victor"] = 2,
            ["Angel"] = 5,
            ["Gosho"] = 3,
            ["Pesho"] = 6,
            ["Iana"] = 4
        };
        string expectedResult = $"Pesho with average grade 6.00{Environment.NewLine}" +
            $"Angel with average grade 5.00{Environment.NewLine}" +
            $"Iana with average grade 4.00";

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>();
        string expectedResult = "";

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            ["Angel"] = 5,
            ["Pesho"] = 6,
        };
        string expectedResult = $"Pesho with average grade 6.00{Environment.NewLine}" +
            $"Angel with average grade 5.00";

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            ["Victor"] = 6,
            ["Angel"] = 6,
            ["Gosho"] = 6,
            ["Pesho"] = 6,
            ["Iana"] = 6

        };
        string expectedResult = $"Angel with average grade 6.00{Environment.NewLine}" +
            $"Gosho with average grade 6.00{Environment.NewLine}" +
            $"Iana with average grade 6.00";

        //Act
        string result = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(expectedResult, Is.EqualTo(result));
    }
}
