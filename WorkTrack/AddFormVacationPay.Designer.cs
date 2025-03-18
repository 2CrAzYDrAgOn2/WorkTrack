namespace WorkTrack
{
    partial class AddFormVacationPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormVacationPay));
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelEmployeeIDVacationPay = new Label();
            textBoxEmployeeIDVacationPay = new TextBox();
            labelVacationStartDate = new Label();
            dateTimePickerVacationStartDate = new DateTimePicker();
            labelVacationEndDate = new Label();
            dateTimePickerVacationEndDate = new DateTimePicker();
            labelAverageDailyEarnings = new Label();
            textBoxAverageDailyEarnings = new TextBox();
            labelTotalVacationPay = new Label();
            textBoxTotalVacationPay = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(242, 9);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(243, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 7;
            label1.Text = "Отпускные";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(329, 762);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelEmployeeIDVacationPay
            // 
            labelEmployeeIDVacationPay.AutoSize = true;
            labelEmployeeIDVacationPay.BackColor = Color.Transparent;
            labelEmployeeIDVacationPay.ForeColor = Color.Black;
            labelEmployeeIDVacationPay.Location = new Point(166, 458);
            labelEmployeeIDVacationPay.Margin = new Padding(4, 0, 4, 0);
            labelEmployeeIDVacationPay.Name = "labelEmployeeIDVacationPay";
            labelEmployeeIDVacationPay.Size = new Size(114, 15);
            labelEmployeeIDVacationPay.TabIndex = 8;
            labelEmployeeIDVacationPay.Text = "Номер сотрудника:";
            // 
            // textBoxEmployeeIDVacationPay
            // 
            textBoxEmployeeIDVacationPay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDVacationPay.Location = new Point(291, 447);
            textBoxEmployeeIDVacationPay.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDVacationPay.Name = "textBoxEmployeeIDVacationPay";
            textBoxEmployeeIDVacationPay.Size = new Size(455, 33);
            textBoxEmployeeIDVacationPay.TabIndex = 0;
            // 
            // labelVacationStartDate
            // 
            labelVacationStartDate.AutoSize = true;
            labelVacationStartDate.BackColor = Color.Transparent;
            labelVacationStartDate.ForeColor = Color.Black;
            labelVacationStartDate.Location = new Point(157, 509);
            labelVacationStartDate.Margin = new Padding(4, 0, 4, 0);
            labelVacationStartDate.Name = "labelVacationStartDate";
            labelVacationStartDate.Size = new Size(123, 15);
            labelVacationStartDate.TabIndex = 9;
            labelVacationStartDate.Text = "Дата начала отпуска:";
            // 
            // dateTimePickerVacationStartDate
            // 
            dateTimePickerVacationStartDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerVacationStartDate.Location = new Point(291, 495);
            dateTimePickerVacationStartDate.Name = "dateTimePickerVacationStartDate";
            dateTimePickerVacationStartDate.Size = new Size(455, 33);
            dateTimePickerVacationStartDate.TabIndex = 1;
            // 
            // labelVacationEndDate
            // 
            labelVacationEndDate.AutoSize = true;
            labelVacationEndDate.BackColor = Color.Transparent;
            labelVacationEndDate.ForeColor = Color.Black;
            labelVacationEndDate.Location = new Point(163, 551);
            labelVacationEndDate.Margin = new Padding(4, 0, 4, 0);
            labelVacationEndDate.Name = "labelVacationEndDate";
            labelVacationEndDate.Size = new Size(117, 15);
            labelVacationEndDate.TabIndex = 10;
            labelVacationEndDate.Text = "Дата конца отпуска:";
            // 
            // dateTimePickerVacationEndDate
            // 
            dateTimePickerVacationEndDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerVacationEndDate.Location = new Point(291, 537);
            dateTimePickerVacationEndDate.Name = "dateTimePickerVacationEndDate";
            dateTimePickerVacationEndDate.Size = new Size(455, 33);
            dateTimePickerVacationEndDate.TabIndex = 2;
            // 
            // labelAverageDailyEarnings
            // 
            labelAverageDailyEarnings.AutoSize = true;
            labelAverageDailyEarnings.BackColor = Color.Transparent;
            labelAverageDailyEarnings.ForeColor = Color.Black;
            labelAverageDailyEarnings.Location = new Point(114, 593);
            labelAverageDailyEarnings.Margin = new Padding(4, 0, 4, 0);
            labelAverageDailyEarnings.Name = "labelAverageDailyEarnings";
            labelAverageDailyEarnings.Size = new Size(166, 15);
            labelAverageDailyEarnings.TabIndex = 11;
            labelAverageDailyEarnings.Text = "Средний дневной заработок:";
            // 
            // textBoxAverageDailyEarnings
            // 
            textBoxAverageDailyEarnings.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAverageDailyEarnings.Location = new Point(291, 582);
            textBoxAverageDailyEarnings.Margin = new Padding(4, 3, 4, 3);
            textBoxAverageDailyEarnings.Name = "textBoxAverageDailyEarnings";
            textBoxAverageDailyEarnings.Size = new Size(455, 33);
            textBoxAverageDailyEarnings.TabIndex = 3;
            // 
            // labelTotalVacationPay
            // 
            labelTotalVacationPay.AutoSize = true;
            labelTotalVacationPay.BackColor = Color.Transparent;
            labelTotalVacationPay.ForeColor = Color.Black;
            labelTotalVacationPay.Location = new Point(237, 638);
            labelTotalVacationPay.Margin = new Padding(4, 0, 4, 0);
            labelTotalVacationPay.Name = "labelTotalVacationPay";
            labelTotalVacationPay.Size = new Size(43, 15);
            labelTotalVacationPay.TabIndex = 12;
            labelTotalVacationPay.Text = "Итого:";
            // 
            // textBoxTotalVacationPay
            // 
            textBoxTotalVacationPay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTotalVacationPay.Location = new Point(291, 627);
            textBoxTotalVacationPay.Margin = new Padding(4, 3, 4, 3);
            textBoxTotalVacationPay.Name = "textBoxTotalVacationPay";
            textBoxTotalVacationPay.ReadOnly = true;
            textBoxTotalVacationPay.Size = new Size(455, 33);
            textBoxTotalVacationPay.TabIndex = 4;
            // 
            // AddFormVacationPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelEmployeeIDVacationPay);
            Controls.Add(textBoxEmployeeIDVacationPay);
            Controls.Add(labelVacationStartDate);
            Controls.Add(dateTimePickerVacationStartDate);
            Controls.Add(labelVacationEndDate);
            Controls.Add(dateTimePickerVacationEndDate);
            Controls.Add(labelAverageDailyEarnings);
            Controls.Add(textBoxAverageDailyEarnings);
            Controls.Add(labelTotalVacationPay);
            Controls.Add(textBoxTotalVacationPay);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormVacationPay";
            Text = "Добавить отпускные";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelEmployeeIDVacationPay;
        private TextBox textBoxEmployeeIDVacationPay;
        private Label labelVacationStartDate;
        private DateTimePicker dateTimePickerVacationStartDate;
        private Label labelVacationEndDate;
        private DateTimePicker dateTimePickerVacationEndDate;
        private Label labelAverageDailyEarnings;
        private TextBox textBoxAverageDailyEarnings;
        private Label labelTotalVacationPay;
        private TextBox textBoxTotalVacationPay;
    }
}