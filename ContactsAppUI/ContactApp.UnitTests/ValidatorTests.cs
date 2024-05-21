using NUnit.Framework;
using System;
using ContactApp;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test(Description = "Тест метода CheckMaxLength при превышении длины")]
        public void CheckMaxLength_WhenWordExceedsMaxLength_ThrowsArgumentException()
        {
            // Arrange
            var word = "ThisIsAVeryLongWord";
            var maxLength = 10;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Validator.CheckMaxLength(word, maxLength), "Исключение не было брошено при превышении длины");
        }

        [Test(Description = "Тест метода CheckMaxLength при корректной длине")]
        public void CheckMaxLength_WhenWordIsWithinMaxLength_DoesNotThrow()
        {
            // Arrange
            var word = "Short";
            var maxLength = 10;

            // Act & Assert
            Assert.DoesNotThrow(() => Validator.CheckMaxLength(word, maxLength), "Исключение было брошено при корректной длине");
        }

        [Test(Description = "Тест метода CheckBirthday при дате в будущем")]
        public void CheckBirthday_WhenDateIsInFuture_ThrowsArgumentException()
        {
            // Arrange
            var futureDate = DateTime.Now.AddYears(1);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Validator.CheckBirthday(futureDate), "Исключение не было брошено при дате в будущем");
        }

        [Test(Description = "Тест метода CheckBirthday при корректной дате")]
        public void CheckBirthday_WhenDateIsValid_DoesNotThrow()
        {
            // Arrange
            var validDate = DateTime.Now.AddYears(-25);

            // Act & Assert
            Assert.DoesNotThrow(() => Validator.CheckBirthday(validDate), "Исключение было брошено при корректной дате");
        }

        [Test(Description = "Тест метода CheckNumber при невалидном номере")]
        public void CheckNumber_WhenNumberIsInvalid_ThrowsArgumentException()
        {
            // Arrange
            var invalidNumber = "8123456789"; // Invalid length and starting digit

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Validator.CheckNumber(invalidNumber), "Исключение не было брошено для невалидного номера");
        }

        [Test(Description = "Тест метода CheckNumber при валидном номере")]
        public void CheckNumber_WhenNumberIsValid_DoesNotThrow()
        {
            // Arrange
            var validNumber = "71234567890";

            // Act & Assert
            Assert.DoesNotThrow(() => Validator.CheckNumber(validNumber), "Исключение было брошено для валидного номера");
        }
    }
}
