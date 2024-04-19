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
    }
}
