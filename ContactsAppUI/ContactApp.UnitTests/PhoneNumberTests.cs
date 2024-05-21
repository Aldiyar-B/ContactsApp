using NUnit.Framework;
using System;
using ContactApp;
using NUnit.Framework.Legacy;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class PhoneNumberTests
    {
        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void Constructor_WithParameters_SetsNumberCorrectly()
        {
            // Arrange
            var number = "71234567890";

            // Act
            var phoneNumber = new PhoneNumber(number);

            // Assert
            ClassicAssert.AreEqual(number, phoneNumber.Number, "Конструктор устанавливает неправильный номер телефона");
        }

        [Test(Description = "Позитивный тест сеттера Number")]
        public void Number_Setter_ValidatesNumber()
        {
            // Arrange
            var phoneNumber = new PhoneNumber();
            var validNumber = "71234567890";

            // Act & Assert
            Assert.DoesNotThrow(() => phoneNumber.Number = validNumber, "Сеттер Number бросает исключение для валидного номера");
        }

        [Test(Description = "Негативный тест сеттера Number")]
        public void Number_Setter_InvalidNumber_ThrowsException()
        {
            // Arrange
            var phoneNumber = new PhoneNumber();
            var invalidNumber = "8123456789"; // Invalid length and starting digit

            // Act & Assert
            Assert.Throws<ArgumentException>(() => phoneNumber.Number = invalidNumber, "Сеттер Number не бросает исключение для невалидного номера");
        }
    }
}
