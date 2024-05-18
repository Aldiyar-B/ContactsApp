namespace ContactsAppUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtVkId = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addContactToolStripMenuItem = new ToolStripMenuItem();
            editContactToolStripMenuItem = new ToolStripMenuItem();
            removeContactToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_Surname = new TextBox();
            textBox_Name = new TextBox();
            textBox_Birthday = new TextBox();
            textBox_Phone = new TextBox();
            textBox_Email = new TextBox();
            textBox_Vk = new TextBox();
            button_Add = new Button();
            button_Edit = new Button();
            button_Remove = new Button();
            ContactsListBox = new ListBox();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtVkId
            // 
            txtVkId.Location = new Point(63, 43);
            txtVkId.Name = "txtVkId";
            txtVkId.Size = new Size(125, 27);
            txtVkId.TabIndex = 0;
            txtVkId.TextChanged += txtVkId_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(462, 366);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 1;
            button1.Text = "Добавить тестовый";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(169, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addContactToolStripMenuItem, editContactToolStripMenuItem, removeContactToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            addContactToolStripMenuItem.Size = new Size(201, 26);
            addContactToolStripMenuItem.Text = "Add Contact";
            // 
            // editContactToolStripMenuItem
            // 
            editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            editContactToolStripMenuItem.Size = new Size(201, 26);
            editContactToolStripMenuItem.Text = "Edit Contact";
            // 
            // removeContactToolStripMenuItem
            // 
            removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            removeContactToolStripMenuItem.Size = new Size(201, 26);
            removeContactToolStripMenuItem.Text = "Remove Contact";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.F1;
            aboutToolStripMenuItem.Size = new Size(157, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 3;
            label1.Text = "Find:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 43);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 73);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 107);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 6;
            label4.Text = "Birthday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 140);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 7;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 177);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 209);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 9;
            label7.Text = "Vk.com:";
            // 
            // textBox_Surname
            // 
            textBox_Surname.Location = new Point(441, 39);
            textBox_Surname.Name = "textBox_Surname";
            textBox_Surname.ReadOnly = true;
            textBox_Surname.Size = new Size(314, 27);
            textBox_Surname.TabIndex = 10;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(441, 73);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.ReadOnly = true;
            textBox_Name.Size = new Size(314, 27);
            textBox_Name.TabIndex = 11;
            // 
            // textBox_Birthday
            // 
            textBox_Birthday.Location = new Point(441, 107);
            textBox_Birthday.Name = "textBox_Birthday";
            textBox_Birthday.ReadOnly = true;
            textBox_Birthday.Size = new Size(125, 27);
            textBox_Birthday.TabIndex = 12;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(441, 140);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.ReadOnly = true;
            textBox_Phone.Size = new Size(314, 27);
            textBox_Phone.TabIndex = 13;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(441, 177);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.ReadOnly = true;
            textBox_Email.Size = new Size(314, 27);
            textBox_Email.TabIndex = 14;
            // 
            // textBox_Vk
            // 
            textBox_Vk.Location = new Point(441, 210);
            textBox_Vk.Name = "textBox_Vk";
            textBox_Vk.ReadOnly = true;
            textBox_Vk.Size = new Size(314, 27);
            textBox_Vk.TabIndex = 15;
            // 
            // button_Add
            // 
            button_Add.ForeColor = Color.White;
            button_Add.Image = (Image)resources.GetObject("button_Add.Image");
            button_Add.Location = new Point(28, 444);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(57, 49);
            button_Add.TabIndex = 16;
            button_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Edit
            // 
            button_Edit.ForeColor = Color.White;
            button_Edit.Image = (Image)resources.GetObject("button_Edit.Image");
            button_Edit.Location = new Point(91, 444);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(57, 49);
            button_Edit.TabIndex = 17;
            button_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Remove
            // 
            button_Remove.ForeColor = Color.White;
            button_Remove.Image = (Image)resources.GetObject("button_Remove.Image");
            button_Remove.Location = new Point(154, 444);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(57, 49);
            button_Remove.TabIndex = 18;
            button_Remove.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            // 
            // ContactsListBox
            // 
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.ItemHeight = 20;
            ContactsListBox.Location = new Point(28, 93);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(295, 344);
            ContactsListBox.TabIndex = 19;
            ContactsListBox.SelectedIndexChanged += ContactsListBox_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(661, 366);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 20;
            button2.Text = "Загрузить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(button2);
            Controls.Add(ContactsListBox);
            Controls.Add(button_Remove);
            Controls.Add(button_Edit);
            Controls.Add(button_Add);
            Controls.Add(textBox_Vk);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Phone);
            Controls.Add(textBox_Birthday);
            Controls.Add(textBox_Name);
            Controls.Add(textBox_Surname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtVkId);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Главная форма";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVkId;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem addContactToolStripMenuItem;
        private ToolStripMenuItem editContactToolStripMenuItem;
        private ToolStripMenuItem removeContactToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_Surname;
        private TextBox textBox_Name;
        private TextBox textBox_Birthday;
        private TextBox textBox_Phone;
        private TextBox textBox_Email;
        private TextBox textBox_Vk;
        private Button button_Add;
        private Button button_Edit;
        private Button button_Remove;
        private ListBox ContactsListBox;
        private Button button2;
    }
}
