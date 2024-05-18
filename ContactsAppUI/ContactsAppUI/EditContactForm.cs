using System;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class EditContactForm : Form
    {
        public Contact Contact { get; private set; }

        public EditContactForm(Contact contact)
        {
            InitializeComponent();
            Contact = contact;

            // Заполняем поля текущими данными контакта
            textBox_Surname.Text = contact.Surname;
            textBox_Name.Text = contact.Name;
            textBox_Birthday.Text = contact.Birthday.ToShortDateString();
            textBox_Phone.Text = contact.Phone.Number;
            textBox_Email.Text = contact.Email;
            textBox_Vk.Text = contact.VkID;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
          
        }

        private void button_Save_Click_1(object sender, EventArgs e)
        {
            // Обновляем данные контакта
            Contact.Surname = textBox_Surname.Text;
            Contact.Name = textBox_Name.Text;
            Contact.Birthday = DateTime.Parse(textBox_Birthday.Text);
            Contact.Phone = new PhoneNumber(textBox_Phone.Text);
            Contact.Email = textBox_Email.Text;
            Contact.VkID = textBox_Vk.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
