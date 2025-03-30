namespace WorkTrack
{
    partial class AddFormEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormEmployees));
            labelTitle = new Label();
            buttonSave = new Button();
            textBoxFullName = new TextBox();
            labelBirthDate = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            textBoxBirthPlace = new TextBox();
            labelPassportSeries = new Label();
            textBoxPassportSeries = new TextBox();
            textBoxPassportNumber = new TextBox();
            labelPhone = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            textBoxEmail = new TextBox();
            textBoxINN = new TextBox();
            labelPostID = new Label();
            comboBoxPostID = new ComboBox();
            comboBoxGenderID = new ComboBox();
            labelGenderID = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(219, 20);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(218, 46);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "Сотрудники";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(10, 189, 188);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(49, 563);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 46);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFullName.Location = new Point(111, 115);
            textBoxFullName.Margin = new Padding(4, 3, 4, 3);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.PlaceholderText = "ФИО Сотрудника";
            textBoxFullName.Size = new Size(455, 33);
            textBoxFullName.TabIndex = 0;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.BackColor = Color.FromArgb(81, 95, 106);
            labelBirthDate.Font = new Font("Segoe UI", 15F);
            labelBirthDate.ForeColor = Color.White;
            labelBirthDate.Location = new Point(196, 61);
            labelBirthDate.Margin = new Padding(4, 0, 4, 0);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(157, 28);
            labelBirthDate.TabIndex = 14;
            labelBirthDate.Text = "Дата рождения:";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerBirthDate.Location = new Point(111, 184);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(455, 33);
            dateTimePickerBirthDate.TabIndex = 1;
            // 
            // textBoxBirthPlace
            // 
            textBoxBirthPlace.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBirthPlace.Location = new Point(111, 223);
            textBoxBirthPlace.Margin = new Padding(4, 3, 4, 3);
            textBoxBirthPlace.Name = "textBoxBirthPlace";
            textBoxBirthPlace.PlaceholderText = "Место рождения";
            textBoxBirthPlace.Size = new Size(455, 33);
            textBoxBirthPlace.TabIndex = 2;
            // 
            // labelPassportSeries
            // 
            labelPassportSeries.AutoSize = true;
            labelPassportSeries.BackColor = Color.FromArgb(81, 95, 106);
            labelPassportSeries.Font = new Font("Segoe UI", 15F);
            labelPassportSeries.ForeColor = Color.White;
            labelPassportSeries.Location = new Point(222, 169);
            labelPassportSeries.Margin = new Padding(4, 0, 4, 0);
            labelPassportSeries.Name = "labelPassportSeries";
            labelPassportSeries.Size = new Size(93, 28);
            labelPassportSeries.TabIndex = 16;
            labelPassportSeries.Text = "Паспорт:";
            // 
            // textBoxPassportSeries
            // 
            textBoxPassportSeries.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassportSeries.Location = new Point(111, 292);
            textBoxPassportSeries.Margin = new Padding(4, 3, 4, 3);
            textBoxPassportSeries.Name = "textBoxPassportSeries";
            textBoxPassportSeries.PlaceholderText = "Серия";
            textBoxPassportSeries.Size = new Size(139, 33);
            textBoxPassportSeries.TabIndex = 3;
            // 
            // textBoxPassportNumber
            // 
            textBoxPassportNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassportNumber.Location = new Point(258, 292);
            textBoxPassportNumber.Margin = new Padding(4, 3, 4, 3);
            textBoxPassportNumber.Name = "textBoxPassportNumber";
            textBoxPassportNumber.PlaceholderText = "Номер";
            textBoxPassportNumber.Size = new Size(308, 33);
            textBoxPassportNumber.TabIndex = 4;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = Color.FromArgb(81, 95, 106);
            labelPhone.Font = new Font("Segoe UI", 15F);
            labelPhone.ForeColor = Color.White;
            labelPhone.Location = new Point(222, 239);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(95, 28);
            labelPhone.TabIndex = 18;
            labelPhone.Text = "Телефон:";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Segoe UI", 14.25F);
            maskedTextBoxPhone.Location = new Point(111, 362);
            maskedTextBoxPhone.Mask = "+7 (999) 999-99-99";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(455, 33);
            maskedTextBoxPhone.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmail.Location = new Point(111, 404);
            textBoxEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Почта";
            textBoxEmail.Size = new Size(455, 33);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxINN
            // 
            textBoxINN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxINN.Location = new Point(111, 449);
            textBoxINN.Margin = new Padding(4, 3, 4, 3);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.PlaceholderText = "ИНН";
            textBoxINN.Size = new Size(455, 33);
            textBoxINN.TabIndex = 7;
            // 
            // labelPostID
            // 
            labelPostID.AutoSize = true;
            labelPostID.BackColor = Color.FromArgb(81, 95, 106);
            labelPostID.Font = new Font("Segoe UI", 15F);
            labelPostID.ForeColor = Color.White;
            labelPostID.Location = new Point(211, 397);
            labelPostID.Margin = new Padding(4, 0, 4, 0);
            labelPostID.Name = "labelPostID";
            labelPostID.Size = new Size(119, 28);
            labelPostID.TabIndex = 21;
            labelPostID.Text = "Должность:";
            // 
            // comboBoxPostID
            // 
            comboBoxPostID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPostID.Font = new Font("Segoe UI", 14.25F);
            comboBoxPostID.FormattingEnabled = true;
            comboBoxPostID.Items.AddRange(new object[] { "Менеджер", "Инженер", "Оператор", "Бухгалтер", "Директор" });
            comboBoxPostID.Location = new Point(111, 520);
            comboBoxPostID.Name = "comboBoxPostID";
            comboBoxPostID.Size = new Size(455, 33);
            comboBoxPostID.TabIndex = 8;
            // 
            // comboBoxGenderID
            // 
            comboBoxGenderID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenderID.Font = new Font("Segoe UI", 14.25F);
            comboBoxGenderID.FormattingEnabled = true;
            comboBoxGenderID.Items.AddRange(new object[] { "Мужской", "Женский" });
            comboBoxGenderID.Location = new Point(111, 592);
            comboBoxGenderID.Name = "comboBoxGenderID";
            comboBoxGenderID.Size = new Size(455, 33);
            comboBoxGenderID.TabIndex = 9;
            // 
            // labelGenderID
            // 
            labelGenderID.AutoSize = true;
            labelGenderID.BackColor = Color.FromArgb(81, 95, 106);
            labelGenderID.Font = new Font("Segoe UI", 15F);
            labelGenderID.ForeColor = Color.White;
            labelGenderID.Location = new Point(243, 469);
            labelGenderID.Margin = new Padding(4, 0, 4, 0);
            labelGenderID.Name = "labelGenderID";
            labelGenderID.Size = new Size(53, 28);
            labelGenderID.TabIndex = 22;
            labelGenderID.Text = "Пол:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 95, 106);
            panel1.Controls.Add(labelBirthDate);
            panel1.Controls.Add(labelPassportSeries);
            panel1.Controls.Add(labelPhone);
            panel1.Controls.Add(labelPostID);
            panel1.Controls.Add(labelGenderID);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(62, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 636);
            panel1.TabIndex = 23;
            // 
            // AddFormEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 75, 86);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(661, 771);
            Controls.Add(labelTitle);
            Controls.Add(textBoxFullName);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(textBoxBirthPlace);
            Controls.Add(textBoxPassportSeries);
            Controls.Add(textBoxPassportNumber);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxINN);
            Controls.Add(comboBoxPostID);
            Controls.Add(comboBoxGenderID);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormEmployees";
            Text = "Добавить сотрудника";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonSave;
        private TextBox textBoxFullName;
        private Label labelBirthDate;
        private DateTimePicker dateTimePickerBirthDate;
        private TextBox textBoxBirthPlace;
        private Label labelPassportSeries;
        private TextBox textBoxPassportSeries;
        private TextBox textBoxPassportNumber;
        private Label labelPhone;
        private MaskedTextBox maskedTextBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxINN;
        private Label labelPostID;
        private ComboBox comboBoxPostID;
        private ComboBox comboBoxGenderID;
        private Label labelGenderID;
        private Panel panel1;
    }
}