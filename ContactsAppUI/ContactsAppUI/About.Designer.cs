namespace ContactsAppUI
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 53);
            label1.Name = "label1";
            label1.Size = new Size(199, 46);
            label1.TabIndex = 0;
            label1.Text = "ContactApp";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 116);
            label2.Name = "label2";
            label2.Size = new Size(34, 12);
            label2.TabIndex = 1;
            label2.Text = "V. 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 161);
            label3.Name = "label3";
            label3.Size = new Size(182, 23);
            label3.TabIndex = 2;
            label3.Text = "Автор: Батаев Алдияр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 207);
            label4.Name = "label4";
            label4.Size = new Size(220, 23);
            label4.TabIndex = 3;
            label4.Text = "Email: aimamadiev@mail.ru";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(98, 245);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 4;
            label5.Text = "Github:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(84, 418);
            label6.Name = "label6";
            label6.Size = new Size(101, 12);
            label6.TabIndex = 5;
            label6.Text = "2024 Батаев Алдияр (с)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(170, 245);
            label7.Name = "label7";
            label7.Size = new Size(439, 23);
            label7.TabIndex = 6;
            label7.Text = "https://github.com/Aldiyar-B/ContactsApp/tree/develop";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "About";
            Text = "About";
            Load += About_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}