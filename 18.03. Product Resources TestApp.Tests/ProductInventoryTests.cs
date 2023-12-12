using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string name = "Rice";
        double price = 100;
        int quantity = 10;

        string expectedResult = $"Product Inventory:{Environment.NewLine}{name} - Price: ${price:f2} - Quantity: {quantity}";

        // Act
        this._inventory.AddProduct(name, price, quantity);

        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange

        // Act

        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo("Product Inventory:"));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string firstName = "Rice";
        double firstPrice = 19.601959672;
        int firstQuantity = 11;

        string secondName = "Banana";
        double secondPrice = 15.545472;
        int secondQuantity = 10;

        string expectedResult = $"Product Inventory:" +
            $"{Environment.NewLine}{firstName} - Price: ${firstPrice:f2} - Quantity: {firstQuantity}" +
            $"{Environment.NewLine}{secondName} - Price: ${secondPrice:f2} - Quantity: {secondQuantity}";

        // Act
        this._inventory.AddProduct(firstName, firstPrice, firstQuantity);
        this._inventory.AddProduct(secondName, secondPrice, secondQuantity);

        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expectedResult = 0;

        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string firstName = "Rice";
        double firstPrice = 3;
        int firstQuantity = 10;

        string secondName = "Banana";
        double secondPrice = 5;
        int secondQuantity = 10;

        double expectedResult = 80;

        // Act
        this._inventory.AddProduct(firstName, firstPrice, firstQuantity);
        this._inventory.AddProduct(secondName, secondPrice, secondQuantity);

        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
