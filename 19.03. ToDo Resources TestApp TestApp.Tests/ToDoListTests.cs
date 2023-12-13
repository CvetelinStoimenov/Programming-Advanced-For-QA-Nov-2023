using System;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "New task";
        DateTime dueDat = DateTime.Today;
        this._toDoList .AddTask(title, dueDat);

        // Act
        string result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[ ] New task - Due:"));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title1 = "New task2";
        DateTime dueDat1 = DateTime.Today;
        this._toDoList.AddTask(title1, dueDat1);
        this._toDoList.CompleteTask("New task2");

        // Act
        string? result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[✓] New task2 - Due:"));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string title1 = "New task2";

        // Act & Assert
        Assert.That(() => this._toDoList.CompleteTask("New task"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string? result = this._toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo("To-Do List:"));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string title = "New task";
        DateTime dueDat = DateTime.Today;
        this._toDoList.AddTask(title, dueDat);

        string title1 = "New task2";
        DateTime dueDat1 = DateTime.Today;
        this._toDoList.AddTask(title1, dueDat1);

        // Act
        string? result = this._toDoList.DisplayTasks();

        // Assert
        Assert.IsTrue(result.Contains("To-Do List:"));
        Assert.IsTrue(result.Contains("[ ]"));
        Assert.IsTrue(result.Contains($"{title} - Due: "));
        Assert.IsTrue(result.Contains($"{title1} - Due: "));
    }
}
