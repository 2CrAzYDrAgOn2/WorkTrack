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
            label1 = new Label();
            buttonSave = new Button();
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            labelBirthDate = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            labelBirthPlace = new Label();
            textBoxBirthPlace = new TextBox();
            labelPassportSeries = new Label();
            textBoxPassportSeries = new TextBox();
            labelPassportNumber = new Label();
            textBoxPassportNumber = new TextBox();
            labelPhone = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelINN = new Label();
            textBoxINN = new TextBox();
            labelPostID = new Label();
            comboBoxPostID = new ComboBox();
            labelGenderID = new Label();
            comboBoxGenderID = new ComboBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(239, 9);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(240, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 12;
            label1.Text = "Сотрудник";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(326, 762);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.BackColor = Color.Transparent;
            labelFullName.ForeColor = Color.Black;
            labelFullName.Location = new Point(179, 323);
            labelFullName.Margin = new Padding(4, 0, 4, 0);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(103, 15);
            labelFullName.TabIndex = 13;
            labelFullName.Text = "ФИО сотрудника:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFullName.Location = new Point(288, 312);
            textBoxFullName.Margin = new Padding(4, 3, 4, 3);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(455, 33);
            textBoxFullName.TabIndex = 0;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.BackColor = Color.Transparent;
            labelBirthDate.ForeColor = Color.Black;
            labelBirthDate.Location = new Point(189, 371);
            labelBirthDate.Margin = new Padding(4, 0, 4, 0);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(93, 15);
            labelBirthDate.TabIndex = 14;
            labelBirthDate.Text = "Дата рождения:";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerBirthDate.Location = new Point(288, 357);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(455, 33);
            dateTimePickerBirthDate.TabIndex = 1;
            // 
            // labelBirthPlace
            // 
            labelBirthPlace.AutoSize = true;
            labelBirthPlace.BackColor = Color.Transparent;
            labelBirthPlace.ForeColor = Color.Black;
            labelBirthPlace.Location = new Point(174, 413);
            labelBirthPlace.Margin = new Padding(4, 0, 4, 0);
            labelBirthPlace.Name = "labelBirthPlace";
            labelBirthPlace.Size = new Size(103, 15);
            labelBirthPlace.TabIndex = 15;
            labelBirthPlace.Text = "Место рождения:";
            // 
            // textBoxBirthPlace
            // 
            textBoxBirthPlace.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxBirthPlace.Location = new Point(288, 402);
            textBoxBirthPlace.Margin = new Padding(4, 3, 4, 3);
            textBoxBirthPlace.Name = "textBoxBirthPlace";
            textBoxBirthPlace.Size = new Size(455, 33);
            textBoxBirthPlace.TabIndex = 2;
            // 
            // labelPassportSeries
            // 
            labelPassportSeries.AutoSize = true;
            labelPassportSeries.BackColor = Color.Transparent;
            labelPassportSeries.ForeColor = Color.Black;
            labelPassportSeries.Location = new Point(179, 458);
            labelPassportSeries.Margin = new Padding(4, 0, 4, 0);
            labelPassportSeries.Name = "labelPassportSeries";
            labelPassportSeries.Size = new Size(98, 15);
            labelPassportSeries.TabIndex = 16;
            labelPassportSeries.Text = "Серия паспорта:";
            // 
            // textBoxPassportSeries
            // 
            textBoxPassportSeries.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassportSeries.Location = new Point(288, 447);
            textBoxPassportSeries.Margin = new Padding(4, 3, 4, 3);
            textBoxPassportSeries.Name = "textBoxPassportSeries";
            textBoxPassportSeries.Size = new Size(455, 33);
            textBoxPassportSeries.TabIndex = 3;
            // 
            // labelPassportNumber
            // 
            labelPassportNumber.AutoSize = true;
            labelPassportNumber.BackColor = Color.Transparent;
            labelPassportNumber.ForeColor = Color.Black;
            labelPassportNumber.Location = new Point(175, 502);
            labelPassportNumber.Margin = new Padding(4, 0, 4, 0);
            labelPassportNumber.Name = "labelPassportNumber";
            labelPassportNumber.Size = new Size(102, 15);
            labelPassportNumber.TabIndex = 17;
            labelPassportNumber.Text = "Номер паспорта:";
            // 
            // textBoxPassportNumber
            // 
            textBoxPassportNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassportNumber.Location = new Point(288, 491);
            textBoxPassportNumber.Margin = new Padding(4, 3, 4, 3);
            textBoxPassportNumber.Name = "textBoxPassportNumber";
            textBoxPassportNumber.Size = new Size(455, 33);
            textBoxPassportNumber.TabIndex = 4;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = Color.Transparent;
            labelPhone.ForeColor = Color.Black;
            labelPhone.Location = new Point(219, 547);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(58, 15);
            labelPhone.TabIndex = 18;
            labelPhone.Text = "Телефон:";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Segoe UI", 14.25F);
            maskedTextBoxPhone.Location = new Point(288, 536);
            maskedTextBoxPhone.Mask = "+7 (999) 999-99-99";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(455, 33);
            maskedTextBoxPhone.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.ForeColor = Color.Black;
            labelEmail.Location = new Point(229, 592);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 15);
            labelEmail.TabIndex = 19;
            labelEmail.Text = "Почта:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmail.Location = new Point(288, 581);
            textBoxEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(455, 33);
            textBoxEmail.TabIndex = 6;
            // 
            // labelINN
            // 
            labelINN.AutoSize = true;
            labelINN.BackColor = Color.Transparent;
            labelINN.ForeColor = Color.Black;
            labelINN.Location = new Point(240, 637);
            labelINN.Margin = new Padding(4, 0, 4, 0);
            labelINN.Name = "labelINN";
            labelINN.Size = new Size(37, 15);
            labelINN.TabIndex = 20;
            labelINN.Text = "ИНН:";
            // 
            // textBoxINN
            // 
            textBoxINN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxINN.Location = new Point(288, 626);
            textBoxINN.Margin = new Padding(4, 3, 4, 3);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(455, 33);
            textBoxINN.TabIndex = 7;
            // 
            // labelPostID
            // 
            labelPostID.AutoSize = true;
            labelPostID.BackColor = Color.Transparent;
            labelPostID.ForeColor = Color.Black;
            labelPostID.Location = new Point(205, 683);
            labelPostID.Margin = new Padding(4, 0, 4, 0);
            labelPostID.Name = "labelPostID";
            labelPostID.Size = new Size(72, 15);
            labelPostID.TabIndex = 21;
            labelPostID.Text = "Должность:";
            // 
            // comboBoxPostID
            // 
            comboBoxPostID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPostID.Font = new Font("Segoe UI", 14.25F);
            comboBoxPostID.FormattingEnabled = true;
            comboBoxPostID.Items.AddRange(new object[] { "Менеджер", "Инженер", "Оператор", "Бухгалтер", "Директор" });
            comboBoxPostID.Location = new Point(288, 672);
            comboBoxPostID.Name = "comboBoxPostID";
            comboBoxPostID.Size = new Size(455, 33);
            comboBoxPostID.TabIndex = 8;
            // 
            // labelGenderID
            // 
            labelGenderID.AutoSize = true;
            labelGenderID.BackColor = Color.Transparent;
            labelGenderID.ForeColor = Color.WhiteSmoke;
            labelGenderID.Location = new Point(244, 728);
            labelGenderID.Margin = new Padding(4, 0, 4, 0);
            labelGenderID.Name = "labelGenderID";
            labelGenderID.Size = new Size(33, 15);
            labelGenderID.TabIndex = 22;
            labelGenderID.Text = "Пол:";
            // 
            // comboBoxGenderID
            // 
            comboBoxGenderID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenderID.Font = new Font("Segoe UI", 14.25F);
            comboBoxGenderID.FormattingEnabled = true;
            comboBoxGenderID.Items.AddRange(new object[] { "Мужской", "Женский" });
            comboBoxGenderID.Location = new Point(288, 717);
            comboBoxGenderID.Name = "comboBoxGenderID";
            comboBoxGenderID.Size = new Size(455, 33);
            comboBoxGenderID.TabIndex = 9;
            // 
            // AddFormEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelFullName);
            Controls.Add(textBoxFullName);
            Controls.Add(labelBirthDate);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(labelBirthPlace);
            Controls.Add(textBoxBirthPlace);
            Controls.Add(labelPassportSeries);
            Controls.Add(textBoxPassportSeries);
            Controls.Add(labelPassportNumber);
            Controls.Add(textBoxPassportNumber);
            Controls.Add(labelPhone);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelINN);
            Controls.Add(textBoxINN);
            Controls.Add(labelPostID);
            Controls.Add(comboBoxPostID);
            Controls.Add(labelGenderID);
            Controls.Add(comboBoxGenderID);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormEmployees";
            Text = "Добавить сотрудника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelBirthDate;
        private DateTimePicker dateTimePickerBirthDate;
        private Label labelBirthPlace;
        private TextBox textBoxBirthPlace;
        private Label labelPassportSeries;
        private TextBox textBoxPassportSeries;
        private Label labelPassportNumber;
        private TextBox textBoxPassportNumber;
        private Label labelPhone;
        private MaskedTextBox maskedTextBoxPhone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelINN;
        private TextBox textBoxINN;
        private Label labelPostID;
        private ComboBox comboBoxPostID;
        private Label labelGenderID;
        private ComboBox comboBoxGenderID;
    }
}