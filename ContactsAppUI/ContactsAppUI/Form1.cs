using ContactsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System;

namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        private List<Contact> _contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Главное окно программы";
            this.Size = new Size(800, 650);

        }

        private void Form1_Load(object sender, EventArgs e)
        {




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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtVkId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            using (AddContactForm addContactForm = new AddContactForm())
            {
                if (addContactForm.ShowDialog() == DialogResult.OK)
                {
                    Contact newContact = addContactForm.NewContact;
                    _contacts.Add(newContact);

                    var contactsListBox = this.Controls["ContactsListBox"] as ListBox;
                    if (contactsListBox != null)
                    {
                        contactsListBox.Items.Add(newContact.Name);
                    }
                }
            }
        }


        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                Contact selectedContact = _contacts[ContactsListBox.SelectedIndex];
                textBox_Surname.Text = selectedContact.Surname;
                textBox_Name.Text = selectedContact.Name;
                textBox_Birthday.Text = selectedContact.Birthday.ToShortDateString(); // Преобразуем дату в строку и выводим в TextBox
                textBox_Phone.Text = selectedContact.Phone.Number;
                textBox_Email.Text = selectedContact.Email;
                textBox_Vk.Text = selectedContact.VkID;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
