using ContactsApp;

namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             
            // Создание экземпляра класса Contact с помощью конструктора с параметрами
            Contact contact = new Contact("Иванов", "Иван", "ivanov@example.com", "ivanov_vk", new DateTime(1990, 5, 15), "123456789");

            // Формирование строки с информацией о контакте
            string contactInfo = $"Фамилия: {contact.Surname}\n" +
                                 $"Имя: {contact.Name}\n" +
                                 $"Эл.почта: {contact.Email}\n" +
                                 $"VkID: {contact.VkID}\n" +
                                 $"День рождения: {contact.Birthday}\n" +
                                 $"Номер телефона: {contact.Phone.Number}";

            // Вывод информации о контакте в TextBox
            label1.Text = contactInfo;
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vkId = txtVkId.Text; // Получение данных из TextBox

            if (!string.IsNullOrEmpty(vkId))
            {
                Contact contact = new Contact();
                contact.VkID = vkId;

                // Сохранение данных в файл
                List<Contact> contacts = new List<Contact>();
                contacts.Add(contact);
                Serializer.SaveToFile(contacts, "contacts.json");

                MessageBox.Show("Данные успешно сериализованы и сохранены в файл contacts.json");
            }
            else
            {
                MessageBox.Show("Введите VkID в TextBox");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Загрузка данных из файла
            List<Contact> loadedContacts = Serializer.LoadFromFile("contacts.json");

            if (loadedContacts.Count > 0)
            {
                Contact loadedContact = loadedContacts[0];
                MessageBox.Show($"VkID из загруженного объекта: {loadedContact.VkID}");
            }
            else
            {
                MessageBox.Show("Нет данных для десериализации");
            }
        }

        private void textBoxContactInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
