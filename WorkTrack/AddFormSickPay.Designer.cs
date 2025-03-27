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
            label1 = new Label();
            buttonSave = new Button();
            textBoxEmployeeIDSickPay = new TextBox();
            labelSickStartDate = new Label();
            dateTimePickerSickStartDate = new DateTimePicker();
            labelSickEndDate = new Label();
            dateTimePickerSickEndDate = new DateTimePicker();
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
            label1.Location = new Point(302, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 46);
            label1.TabIndex = 8;
            label1.Text = "Больничный";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(10, 189, 188);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(42, 225);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 46);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textBoxEmployeeIDSickPay
            // 
            textBoxEmployeeIDSickPay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDSickPay.Location = new Point(42, 21);
            textBoxEmployeeIDSickPay.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDSickPay.Name = "textBoxEmployeeIDSickPay";
            textBoxEmployeeIDSickPay.PlaceholderText = "Номер сотрудника";
            textBoxEmployeeIDSickPay.Size = new Size(170, 33);
            textBoxEmployeeIDSickPay.TabIndex = 0;
            // 
            // labelSickStartDate
            // 
            labelSickStartDate.AutoSize = true;
            labelSickStartDate.BackColor = Color.Transparent;
            labelSickStartDate.Font = new Font("Segoe UI", 15F);
            labelSickStartDate.ForeColor = Color.White;
            labelSickStartDate.Location = new Point(140, 66);
            labelSickStartDate.Margin = new Padding(4, 0, 4, 0);
            labelSickStartDate.Name = "labelSickStartDate";
            labelSickStartDate.Size = new Size(256, 28);
            labelSickStartDate.TabIndex = 10;
            labelSickStartDate.Text = "Дата начала больничного:";
            // 
            // dateTimePickerSickStartDate
            // 
            dateTimePickerSickStartDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerSickStartDate.Location = new Point(42, 97);
            dateTimePickerSickStartDate.Name = "dateTimePickerSickStartDate";
            dateTimePickerSickStartDate.Size = new Size(455, 33);
            dateTimePickerSickStartDate.TabIndex = 1;
            // 
            // labelSickEndDate
            // 
            labelSickEndDate.AutoSize = true;
            labelSickEndDate.BackColor = Color.Transparent;
            labelSickEndDate.Font = new Font("Segoe UI", 15F);
            labelSickEndDate.ForeColor = Color.White;
            labelSickEndDate.Location = new Point(140, 140);
            labelSickEndDate.Margin = new Padding(4, 0, 4, 0);
            labelSickEndDate.Name = "labelSickEndDate";
            labelSickEndDate.Size = new Size(248, 28);
            labelSickEndDate.TabIndex = 11;
            labelSickEndDate.Text = "Дата конца больничного:";
            // 
            // dateTimePickerSickEndDate
            // 
            dateTimePickerSickEndDate.Font = new Font("Segoe UI", 14.25F);
            dateTimePickerSickEndDate.Location = new Point(42, 171);
            dateTimePickerSickEndDate.Name = "dateTimePickerSickEndDate";
            dateTimePickerSickEndDate.Size = new Size(455, 33);
            dateTimePickerSickEndDate.TabIndex = 2;
            dateTimePickerSickEndDate.ValueChanged += dateTimePickerSickEndDate_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 95, 106);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePickerSickStartDate);
            panel1.Controls.Add(textBoxEmployeeIDSickPay);
            panel1.Controls.Add(labelSickStartDate);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(labelSickEndDate);
            panel1.Controls.Add(dateTimePickerSickEndDate);
            panel1.Location = new Point(131, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 298);
            panel1.TabIndex = 12;
            // 
            // AddFormSickPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 75, 86);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 474);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormSickPay";
            Text = "Добавить больничный";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonSave;
        private TextBox textBoxEmployeeIDSickPay;
        private Label labelSickStartDate;
        private DateTimePicker dateTimePickerSickStartDate;
        private Label labelSickEndDate;
        private DateTimePicker dateTimePickerSickEndDate;
        private Panel panel1;
    }
}