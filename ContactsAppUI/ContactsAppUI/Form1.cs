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
            this.Text = "������� ���� ���������";
            this.Size = new Size(800, 650);

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vkId = txtVkId.Text; // ��������� ������ �� TextBox

            if (!string.IsNullOrEmpty(vkId))
            {
                Contact contact = new Contact();
                contact.VkID = vkId;

                // ���������� ������ � ����
                List<Contact> contacts = new List<Contact>();
                contacts.Add(contact);
                Serializer.SaveToFile(contacts, "contacts.json");

                MessageBox.Show("������ ������� ������������� � ��������� � ���� contacts.json");
            }
            else
            {
                MessageBox.Show("������� VkID � TextBox");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �������� ������ �� �����
            List<Contact> loadedContacts = Serializer.LoadFromFile("contacts.json");

            if (loadedContacts.Count > 0)
            {
                Contact loadedContact = loadedContacts[0];
                MessageBox.Show($"VkID �� ������������ �������: {loadedContact.VkID}");
            }
            else
            {
                MessageBox.Show("��� ������ ��� ��������������");
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
                textBox_Birthday.Text = selectedContact.Birthday.ToShortDateString(); // ����������� ���� � ������ � ������� � TextBox
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
