using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialBalance = 250.00;

        // Act
        BankAccount account = new BankAccount(initialBalance);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(250.00));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initialBalance = 25000.00;
        BankAccount account = new BankAccount(initialBalance);
        double depositAmount = 500.00;
        double expectedBalance = initialBalance + depositAmount;

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(expectedBalance));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(35400.00);

        // Act & Assert
        Assert.That(()=> account.Deposit(-400.00), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialBalance = 35400.00;
        BankAccount account = new BankAccount(initialBalance);
        double withdrawalAmount = 400.00;
        double expectedBalance = initialBalance - withdrawalAmount;

        // Act
        account.Withdraw(withdrawalAmount);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(expectedBalance));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(35400.00);

        // Act & Assert
        Assert.That(() => account.Deposit(-400.00), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        BankAccount account = new BankAccount(35400.00);

        // Act & Assert
        Assert.That(() => account.Withdraw(35500.00), Throws.ArgumentException);
    }
}
