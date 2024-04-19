using System;

namespace ContactsApp
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            // Инициализация экземпляра класса Contact с помощью конструктора с параметрами
            Contact contact1 = new Contact("Иванов", "Иван", "ivanov@example.com", "ivanov_vk", new DateTime(1990, 5, 15), "123456789");

            // Второй экземпляр класса Contact с использованием конструктора без параметров
            Contact contact2 = new Contact();

            // Установка значений свойств для второго контакта
            contact2.Surname = "Петров";
            contact2.Name = "Петр";
            contact2.Email = "petrov@example.com";
            contact2.VkID = "petrov_vk";
            contact2.Birthday = new DateTime(1985, 10, 20);
            contact2.Phone = new PhoneNumber("987654321");

            // Вывод информации о контактах
            Console.WriteLine("Контакт 1:");
            Console.WriteLine($"Фамилия: {contact1.Surname}");
            Console.WriteLine($"Имя: {contact1.Name}");
            Console.WriteLine($"Эл.почта: {contact1.Email}");
            Console.WriteLine($"VkID: {contact1.VkID}");
            Console.WriteLine($"День рождения: {contact1.Birthday}");
            Console.WriteLine($"Номер телефона: {contact1.Phone.Number}");

            Console.WriteLine("\nКонтакт 2:");
            Console.WriteLine($"Фамилия: {contact2.Surname}");
            Console.WriteLine($"Имя: {contact2.Name}");
            Console.WriteLine($"Эл.почта: {contact2.Email}");
            Console.WriteLine($"VkID: {contact2.VkID}");
            Console.WriteLine($"День рождения: {contact2.Birthday}");
            Console.WriteLine($"Номер телефона: {contact2.Phone.Number}");
        }
    }
}
