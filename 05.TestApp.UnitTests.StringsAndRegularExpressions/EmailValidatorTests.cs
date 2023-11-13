using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("gotin11@abv.bg")]
    [TestCase("IakaKaka85@yagoo.com")]
    [TestCase("malkoKote00@zamunda.co.uk")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("kukvica@abv@gmail.com")]
    [TestCase("www.abv.bg")]
    [TestCase("")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
