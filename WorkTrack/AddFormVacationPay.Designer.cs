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
            label1 = new Label();
            buttonSave = new Button();
            textBoxEmployeeIDVacationPay = new TextBox();
            dateTimePickerVacationStartDate = new DateTimePicker();
            dateTimePickerVacationEndDate = new DateTimePicker();
            labelVacationEndDate = new Label();
            labelVacationStartDate = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(228, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 46);
            label1.TabIndex = 7;
            label1.Text = "Отпускные";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(10, 189, 188);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(39, 224);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 46);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textBoxEmployeeIDVacationPay
            // 
            textBoxEmployeeIDVacationPay.BackColor = SystemColors.Window;
            textBoxEmployeeIDVacationPay.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmployeeIDVacationPay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDVacationPay.ForeColor = Color.Black;
            textBoxEmployeeIDVacationPay.Location = new Point(39, 26);
            textBoxEmployeeIDVacationPay.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDVacationPay.Name = "textBoxEmployeeIDVacationPay";
            textBoxEmployeeIDVacationPay.PlaceholderText = "Номер сотрудника";
            textBoxEmployeeIDVacationPay.Size = new Size(170, 33);
            textBoxEmployeeIDVacationPay.TabIndex = 0;
            textBoxEmployeeIDVacationPay.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePickerVacationStartDate
            // 
            dateTimePickerVacationStartDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerVacationStartDate.Location = new Point(39, 93);
            dateTimePickerVacationStartDate.Name = "dateTimePickerVacationStartDate";
            dateTimePickerVacationStartDate.Size = new Size(455, 33);
            dateTimePickerVacationStartDate.TabIndex = 1;
            // 
            // dateTimePickerVacationEndDate
            // 
            dateTimePickerVacationEndDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerVacationEndDate.Location = new Point(39, 168);
            dateTimePickerVacationEndDate.Name = "dateTimePickerVacationEndDate";
            dateTimePickerVacationEndDate.Size = new Size(455, 33);
            dateTimePickerVacationEndDate.TabIndex = 2;
            // 
            // labelVacationEndDate
            // 
            labelVacationEndDate.AutoSize = true;
            labelVacationEndDate.BackColor = Color.Transparent;
            labelVacationEndDate.Font = new Font("Segoe UI", 15F);
            labelVacationEndDate.ForeColor = Color.White;
            labelVacationEndDate.Location = new Point(159, 137);
            labelVacationEndDate.Margin = new Padding(4, 0, 4, 0);
            labelVacationEndDate.Name = "labelVacationEndDate";
            labelVacationEndDate.Size = new Size(195, 28);
            labelVacationEndDate.TabIndex = 10;
            labelVacationEndDate.Text = "Дата конца отпуска:";
            // 
            // labelVacationStartDate
            // 
            labelVacationStartDate.AutoSize = true;
            labelVacationStartDate.BackColor = Color.Transparent;
            labelVacationStartDate.Font = new Font("Segoe UI", 15F);
            labelVacationStartDate.ForeColor = Color.White;
            labelVacationStartDate.Location = new Point(159, 62);
            labelVacationStartDate.Margin = new Padding(4, 0, 4, 0);
            labelVacationStartDate.Name = "labelVacationStartDate";
            labelVacationStartDate.Size = new Size(203, 28);
            labelVacationStartDate.TabIndex = 9;
            labelVacationStartDate.Text = "Дата начала отпуска:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 95, 106);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePickerVacationEndDate);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(dateTimePickerVacationStartDate);
            panel1.Controls.Add(textBoxEmployeeIDVacationPay);
            panel1.Controls.Add(labelVacationStartDate);
            panel1.Controls.Add(labelVacationEndDate);
            panel1.Location = new Point(56, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 298);
            panel1.TabIndex = 11;
            // 
            // AddFormVacationPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 75, 86);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(649, 457);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormVacationPay";
            Text = "Добавить отпускные";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonSave;
        private TextBox textBoxEmployeeIDVacationPay;
        private DateTimePicker dateTimePickerVacationStartDate;
        private DateTimePicker dateTimePickerVacationEndDate;
        private Label labelVacationEndDate;
        private Label labelVacationStartDate;
        private Panel panel1;
    }
}