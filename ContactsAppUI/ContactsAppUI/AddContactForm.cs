using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class AddContactForm : Form
    {
        public Contact NewContact { get; private set; }

        public AddContactForm()
        {
            InitializeComponent();
            this.Text = "Добавить контакт";
            this.Size = new Size(400, 400);

            Label lblSurname = new Label { Text = "Фамилия", Location = new Point(10, 10) };
            TextBox txtSurname = new TextBox { Location = new Point(150, 10), Width = 100 };

            Label lblName = new Label { Text = "Имя", Location = new Point(10, 40) };
            TextBox txtName = new TextBox { Location = new Point(150, 40), Width = 100 };

            Label lblPhone = new Label { Text = "Телефон", Location = new Point(10, 70) };
            TextBox txtPhone = new TextBox { Location = new Point(150, 70), Width = 100 };

            Label lblEmail = new Label { Text = "Email", Location = new Point(10, 100) };
            TextBox txtEmail = new TextBox { Location = new Point(150, 100), Width = 100 };

            Label lblVkID = new Label { Text = "VkID", Location = new Point(10, 130) };
            TextBox txtVkID = new TextBox { Location = new Point(150, 130), Width = 100 };

            Label lblBirthday = new Label { Text = "Дата рождения", Location = new Point(10, 160) };
            DateTimePicker dtpBirthday = new DateTimePicker { Location = new Point(150, 160), Width = 100 };

            Button btnAdd = new Button { Text = "Добавить", Location = new Point(150, 200) };
            btnAdd.Click += (sender, e) =>
            {
                try
                {
                    string phone = txtPhone.Text;
                    Validator.CheckNumber(phone);

                    NewContact = new Contact
                    {
                        Surname = txtSurname.Text,
                        Name = txtName.Text,
                        Phone = new PhoneNumber(phone),
                        Email = txtEmail.Text,
                        VkID = txtVkID.Text,
                        Birthday = dtpBirthday.Value
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Добавляем обработчики событий для валидации
            txtSurname.KeyPress += TextBox_KeyPress_LettersOnly;
            txtName.KeyPress += TextBox_KeyPress_LettersOnly;
            txtPhone.KeyPress += TextBox_KeyPress_NumbersOnly;

            txtSurname.Validating += TextBox_Validating;
            txtName.Validating += TextBox_Validating;
            txtPhone.Validating += TextBox_Validating;
            txtEmail.Validating += TextBox_Validating;
            txtVkID.Validating += TextBox_Validating;
            dtpBirthday.Validating += DtpBirthday_Validating;

            this.Controls.Add(lblSurname);
            this.Controls.Add(txtSurname);
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblPhone);
            this.Controls.Add(txtPhone);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblVkID);
            this.Controls.Add(txtVkID);
            this.Controls.Add(lblBirthday);
            this.Controls.Add(dtpBirthday);
            this.Controls.Add(btnAdd);
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
        }

        // Запрет ввода некорректных символов
        private void TextBox_KeyPress_LettersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_KeyPress_NumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Проверка после потери фокуса
        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string name = textBox.Name;
                try
                {
                    switch (name)
                    {
                        case "txtSurname":
                        case "txtName":
                            Validator.CheckMaxLength(textBox.Text, 50);
                            break;
                        case "txtPhone":
                            Validator.CheckNumber(textBox.Text);
                            break;
                        case "txtEmail":
                            Validator.CheckMaxLength(textBox.Text, 50);
                            break;
                        case "txtVkID":
                            Validator.CheckMaxLength(textBox.Text, 15);
                            break;
                    }
                    textBox.BackColor = SystemColors.Window;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    textBox.BackColor = Color.Red;
                    e.Cancel = true;
                }
            }
        }

        private void DtpBirthday_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            if (dtp != null)
            {
                try
                {
                    Validator.CheckBirthday(dtp.Value);
                    dtp.BackColor = SystemColors.Window;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                    dtp.BackColor = Color.Red;
                    e.Cancel = true;
                }
            }
        }
    }
}
