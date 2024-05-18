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
            this.Size = new Size(300, 300);

            Label lblSurname = new Label { Text = "Фамилвия", Location = new Point(10, 10) };
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
    }
}
