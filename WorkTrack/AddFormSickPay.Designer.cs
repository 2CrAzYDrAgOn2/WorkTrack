namespace WorkTrack
{
    partial class AddFormSickPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormSickPay));
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelEmployeeIDSickPay = new Label();
            textBoxEmployeeIDSickPay = new TextBox();
            labelSickStartDate = new Label();
            dateTimePickerSickStartDate = new DateTimePicker();
            labelSickEndDate = new Label();
            dateTimePickerSickEndDate = new DateTimePicker();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(243, 9);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(244, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 8;
            label1.Text = "Больничный";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(330, 762);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelEmployeeIDSickPay
            // 
            labelEmployeeIDSickPay.AutoSize = true;
            labelEmployeeIDSickPay.BackColor = Color.Transparent;
            labelEmployeeIDSickPay.ForeColor = Color.Black;
            labelEmployeeIDSickPay.Location = new Point(172, 458);
            labelEmployeeIDSickPay.Margin = new Padding(4, 0, 4, 0);
            labelEmployeeIDSickPay.Name = "labelEmployeeIDSickPay";
            labelEmployeeIDSickPay.Size = new Size(114, 15);
            labelEmployeeIDSickPay.TabIndex = 9;
            labelEmployeeIDSickPay.Text = "Номер сотрудника:";
            // 
            // textBoxEmployeeIDSickPay
            // 
            textBoxEmployeeIDSickPay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDSickPay.Location = new Point(292, 447);
            textBoxEmployeeIDSickPay.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDSickPay.Name = "textBoxEmployeeIDSickPay";
            textBoxEmployeeIDSickPay.Size = new Size(455, 33);
            textBoxEmployeeIDSickPay.TabIndex = 0;
            // 
            // labelSickStartDate
            // 
            labelSickStartDate.AutoSize = true;
            labelSickStartDate.BackColor = Color.Transparent;
            labelSickStartDate.ForeColor = Color.Black;
            labelSickStartDate.Location = new Point(132, 510);
            labelSickStartDate.Margin = new Padding(4, 0, 4, 0);
            labelSickStartDate.Name = "labelSickStartDate";
            labelSickStartDate.Size = new Size(154, 15);
            labelSickStartDate.TabIndex = 10;
            labelSickStartDate.Text = "Дата начала больничного:";
            // 
            // dateTimePickerSickStartDate
            // 
            dateTimePickerSickStartDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerSickStartDate.Location = new Point(292, 496);
            dateTimePickerSickStartDate.Name = "dateTimePickerSickStartDate";
            dateTimePickerSickStartDate.Size = new Size(455, 33);
            dateTimePickerSickStartDate.TabIndex = 1;
            // 
            // labelSickEndDate
            // 
            labelSickEndDate.AutoSize = true;
            labelSickEndDate.BackColor = Color.Transparent;
            labelSickEndDate.ForeColor = Color.Black;
            labelSickEndDate.Location = new Point(133, 544);
            labelSickEndDate.Margin = new Padding(4, 0, 4, 0);
            labelSickEndDate.Name = "labelSickEndDate";
            labelSickEndDate.Size = new Size(148, 15);
            labelSickEndDate.TabIndex = 11;
            labelSickEndDate.Text = "Дата конца больничного:";
            // 
            // dateTimePickerSickEndDate
            // 
            dateTimePickerSickEndDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerSickEndDate.Location = new Point(292, 538);
            dateTimePickerSickEndDate.Name = "dateTimePickerSickEndDate";
            dateTimePickerSickEndDate.Size = new Size(455, 33);
            dateTimePickerSickEndDate.TabIndex = 2;
            // 
            // AddFormSickPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelEmployeeIDSickPay);
            Controls.Add(textBoxEmployeeIDSickPay);
            Controls.Add(labelSickStartDate);
            Controls.Add(dateTimePickerSickStartDate);
            Controls.Add(labelSickEndDate);
            Controls.Add(dateTimePickerSickEndDate);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormSickPay";
            Text = "Добавить больничный";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelEmployeeIDSickPay;
        private TextBox textBoxEmployeeIDSickPay;
        private Label labelSickStartDate;
        private DateTimePicker dateTimePickerSickStartDate;
        private Label labelSickEndDate;
        private DateTimePicker dateTimePickerSickEndDate;
    }
}