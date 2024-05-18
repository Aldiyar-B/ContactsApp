using ContactsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System;

namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        private List<Contact> _contacts = new List<Contact>();
        private string _filePath = "contacts.json";
        private About About;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Главное окно программы";
            this.Size = new Size(800, 650);

            LoadContacts();


            txtVkId.TextChanged += new EventHandler(txtVkId_TextChanged);
            // Добавляем обработчик для кнопки редактирования (карандашик)
            button_Edit.Click += new EventHandler(button_Edit_Click);
            // Добавляем обработчик для кнопки удаления
            button_Remove.Click += new EventHandler(button_Remove_Click);

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact
            {
                Name = "Test",
                Surname = "User",
                Birthday = DateTime.Now,
                Phone = new PhoneNumber("79139999999"),
                Email = "test@example.com",
                VkID = "testvk"
            };

            _contacts.Add(contact);
            SaveContacts();
            UpdateContactsListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadContacts(); // Обновляем список контактов при нажатии на кнопку загрузки
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
            string searchText = txtVkId.Text.ToLower();
            UpdateContactsListBox(searchText);
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
            var contactsListBox = sender as ListBox;
            if (contactsListBox != null && contactsListBox.SelectedIndex != -1)
            {
                Contact selectedContact = _contacts[contactsListBox.SelectedIndex];
                textBox_Surname.Text = selectedContact.Surname;
                textBox_Name.Text = selectedContact.Name;
                textBox_Birthday.Text = selectedContact.Birthday.ToShortDateString(); // Преобразуем дату в строку и выводим в TextBox
                textBox_Phone.Text = selectedContact.Phone.Number;
                textBox_Email.Text = selectedContact.Email;
                textBox_Vk.Text = selectedContact.VkID;
            }
        }

        private void SaveContacts()
        {
            try
            {
                Serializer.SaveToFile(_contacts, _filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void LoadContacts()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    _contacts = Serializer.LoadFromFile(_filePath);
                    UpdateContactsListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }
        private void UpdateContactsListBox(string searchText = "")
        {
            var contactsListBox = this.Controls["ContactsListBox"] as ListBox;
            if (contactsListBox != null)
            {
                contactsListBox.Items.Clear();
                foreach (var contact in _contacts)
                {
                    if (string.IsNullOrEmpty(searchText) || contact.Name.ToLower().Contains(searchText) || contact.Surname.ToLower().Contains(searchText))
                    {
                        contactsListBox.Items.Add(contact.Name);
                    }
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveContacts(); // Сохраняем контакты при закрытии формы
            base.OnFormClosing(e);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var contactsListBox = this.Controls["ContactsListBox"] as ListBox;
            if (contactsListBox != null && contactsListBox.SelectedIndex != -1)
            {
                Contact selectedContact = _contacts[contactsListBox.SelectedIndex];

                using (EditContactForm editContactForm = new EditContactForm(selectedContact))
                {
                    if (editContactForm.ShowDialog() == DialogResult.OK)
                    {
                        // Обновляем список контактов после редактирования
                        SaveContacts();
                        UpdateContactsListBox();
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите контакт для редактирования.");
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            var contactsListBox = this.Controls["ContactsListBox"] as ListBox;
            if (contactsListBox != null && contactsListBox.SelectedIndex != -1)
            {
                int selectedIndex = contactsListBox.SelectedIndex;
                Contact selectedContact = _contacts[selectedIndex];

                // Показать предупреждающее сообщение
                DialogResult result = MessageBox.Show(
                    $"Вы действительно хотите удалить контакт: {selectedContact.Surname}?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                // Удалить контакт, если пользователь подтвердил
                if (result == DialogResult.Yes)
                {
                    _contacts.RemoveAt(selectedIndex);
                    SaveContacts();
                    UpdateContactsListBox();
                }
            }
            /*
              else
             {
                 MessageBox.Show("Пожалуйста, выберите контакт для удаления.");
             }
            */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, было ли создано окно "About" ранее
            if (About == null || About.IsDisposed)
            {
                // Если нет, создаем новое окно "About"
                About = new About();
            }

            // Показываем окно "About"
            About.ShowDialog();
        }
    }
}
