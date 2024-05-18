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

            // Добавляем обработчики событий для защиты от неправильного ввода
            textBox_Surname.KeyPress += TextBox_Surname_KeyPress;
            textBox_Name.KeyPress += TextBox_Name_KeyPress;
            textBox_Phone.KeyPress += TextBox_Phone_KeyPress;

            textBox_Surname.Validating += TextBox_Surname_Validating;
            textBox_Name.Validating += TextBox_Name_Validating;
            textBox_Birthday.Validating += TextBox_Birthday_Validating;
            textBox_Phone.Validating += TextBox_Phone_Validating;
            textBox_Email.Validating += TextBox_Email_Validating;
            textBox_Vk.Validating += TextBox_Vk_Validating;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }
        private void EditContactForm_Load(object sender, EventArgs e)
        {
        }

        // Запрет ввода некорректных символов
        private void TextBox_Surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Проверка после потери фокуса
        private void TextBox_Surname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox((TextBox)sender, 50);
        }

        private void TextBox_Name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox((TextBox)sender, 50);
        }

        private void TextBox_Birthday_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (DateTime.TryParse(((TextBox)sender).Text, out DateTime date))
                {
                    Validator.CheckBirthday(date);
                    ((TextBox)sender).BackColor = SystemColors.Window;
                }
                else
                {
                    throw new ArgumentException("Неверный формат даты.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                ((TextBox)sender).BackColor = Color.Red;
                e.Cancel = true;
            }
        }

        private void TextBox_Phone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatePhoneNumber((TextBox)sender);
        }

        private void TextBox_Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox((TextBox)sender, 50);
        }

        private void TextBox_Vk_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextBox((TextBox)sender, 15);
        }

        // Методы валидации для текстовых полей
        private void ValidateTextBox(TextBox textBox, int maxLength)
        {
            try
            {
                Validator.CheckMaxLength(textBox.Text, maxLength);
                textBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                textBox.BackColor = Color.Red;
            }
        }

        private void ValidatePhoneNumber(TextBox textBox)
        {
            try
            {
                Validator.CheckNumber(textBox.Text);
                textBox.BackColor = SystemColors.Window;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                textBox.BackColor = Color.Red;
            }
        }
        private void button_Save_Click_1(object sender, EventArgs e)
        {
          
        }

        

        private void button_Save_Click_2(object sender, EventArgs e)
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
