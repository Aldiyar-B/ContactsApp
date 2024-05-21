using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using ContactApp;
using NUnit.Framework.Legacy;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class SerializerTests
    {
        private const string FileName = "testfile.json";

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }
        }

        [Test(Description = "Тест метода SaveToFile")]
        public void SaveToFile_WhenCalled_SavesDataToFile()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new Contact("Смирнов", "Иван", "ivan.smirnov@example.com", "ivan_vk", new DateTime(1990, 1, 1), "71234567890")
            };

            // Act
            Serializer.SaveToFile(contacts, FileName);

            // Assert
            ClassicAssert.IsTrue(File.Exists(FileName), "Файл не был создан");
        }

        [Test(Description = "Тест метода LoadFromFile при существующем файле")]
        public void LoadFromFile_WhenFileExists_ReturnsListOfContacts()
        {
            // Arrange
            var contacts = new List<Contact>
            {
                new Contact("Смирнов", "Иван", "ivan.smirnov@example.com", "ivan_vk", new DateTime(1990, 1, 1), "71234567890")
            };
            Serializer.SaveToFile(contacts, FileName);

            // Act
            var result = Serializer.LoadFromFile(FileName);

            // Assert
            ClassicAssert.AreEqual(contacts.Count, result.Count, "Количество контактов не совпадает");
            ClassicAssert.AreEqual(contacts[0].Surname, result[0].Surname, "Фамилии не совпадают");
        }

        [Test(Description = "Тест метода LoadFromFile при отсутствии файла")]
        public void LoadFromFile_WhenFileDoesNotExist_ReturnsEmptyList()
        {
            // Act
            var result = Serializer.LoadFromFile("nonexistentfile.json");

            // Assert
            ClassicAssert.IsEmpty(result, "Список должен быть пустым");
        }
    }
}
