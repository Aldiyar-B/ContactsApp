using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using ContactsApp; // Замените на правильное пространство имен

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            // Arrange
            var expected = "Смирнов";
            var contact = new Contact { Surname = expected };

            // Act
            var actual = contact.Surname;

            // ClassicAssert
            ClassicAssert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            // Arrange
            var expected = "john.doe@example.com";
            var contact = new Contact { Email = expected };

            // Act
            var actual = contact.Email;

            // ClassicAssert
            ClassicAssert.AreEqual(expected, actual, "Геттер Email возвращает неправильный адрес");
        }

        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void Constructor_WithParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var surname = "Смирнов";
            var name = "Иван";
            var email = "ivan.smirnov@example.com";
            var vkId = "ivan_vk";
            var birthday = new DateTime(1990, 1, 1);
            var phone = "71234567890";

            // Act
            var contact = new Contact(surname, name, email, vkId, birthday, phone);

            // ClassicAssert
            ClassicAssert.AreEqual(surname, contact.Surname, "Конструктор устанавливает неправильную фамилию");
            ClassicAssert.AreEqual(name, contact.Name, "Конструктор устанавливает неправильное имя");
            ClassicAssert.AreEqual(email, contact.Email, "Конструктор устанавливает неправильный адрес эл. почты");
            ClassicAssert.AreEqual(vkId, contact.VkID, "Конструктор устанавливает неправильный vkID");
            ClassicAssert.AreEqual(birthday, contact.Birthday, "Конструктор устанавливает неправильную дату рождения");
            ClassicAssert.AreEqual(phone, contact.Phone.Number, "Конструктор устанавливает неправильный номер телефона");
        }
    }
}
