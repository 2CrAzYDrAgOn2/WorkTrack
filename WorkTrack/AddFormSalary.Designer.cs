namespace WorkTrack
{
    partial class AddFormSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormSalary));
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelSalaryID = new Label();
            textBoxSalaryID = new TextBox();
            labelSalaryAccrualIDSalary = new Label();
            textBoxSalaryAccrualIDSalary = new TextBox();
            labelEmployeeIDSalary = new Label();
            textBoxEmployeeIDSalary = new TextBox();
            labelAllDays = new Label();
            textBoxAllDays = new TextBox();
            labelAllHours = new Label();
            textBoxAllHours = new TextBox();
            labelPieceworkCharges = new Label();
            textBoxPieceworkCharges = new TextBox();
            labelHourlyCharges = new Label();
            textBoxHourlyCharges = new TextBox();
            labelVacationPay = new Label();
            textBoxVacationPay = new TextBox();
            labelSickPay = new Label();
            textBoxSickPay = new TextBox();
            labelPersonalIncomeTax = new Label();
            textBoxPersonalIncomeTax = new TextBox();
            labelContributions = new Label();
            textBoxContributions = new TextBox();
            labelTotal = new Label();
            textBoxTotal = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(243, 9);
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
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(244, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 21);
            label1.TabIndex = 12;
            label1.Text = "Начисление зарплаты";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.WhiteSmoke;
            buttonSave.Location = new Point(330, 762);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelSalaryID
            // 
            labelSalaryID.AutoSize = true;
            labelSalaryID.BackColor = Color.Transparent;
            labelSalaryID.ForeColor = Color.Black;
            labelSalaryID.Location = new Point(233, 307);
            labelSalaryID.Margin = new Padding(4, 0, 4, 0);
            labelSalaryID.Name = "labelSalaryID";
            labelSalaryID.Size = new Size(48, 15);
            labelSalaryID.TabIndex = 37;
            labelSalaryID.Text = "Номер:";
            // 
            // textBoxSalaryID
            // 
            textBoxSalaryID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSalaryID.Location = new Point(292, 293);
            textBoxSalaryID.Margin = new Padding(4, 3, 4, 3);
            textBoxSalaryID.Name = "textBoxSalaryID";
            textBoxSalaryID.Size = new Size(455, 33);
            textBoxSalaryID.TabIndex = 25;
            // 
            // labelSalaryAccrualIDSalary
            // 
            labelSalaryAccrualIDSalary.AutoSize = true;
            labelSalaryAccrualIDSalary.BackColor = Color.Transparent;
            labelSalaryAccrualIDSalary.ForeColor = Color.Black;
            labelSalaryAccrualIDSalary.Location = new Point(183, 342);
            labelSalaryAccrualIDSalary.Margin = new Padding(4, 0, 4, 0);
            labelSalaryAccrualIDSalary.Name = "labelSalaryAccrualIDSalary";
            labelSalaryAccrualIDSalary.Size = new Size(103, 15);
            labelSalaryAccrualIDSalary.TabIndex = 38;
            labelSalaryAccrualIDSalary.Text = "Номер зарплаты:";
            // 
            // textBoxSalaryAccrualIDSalary
            // 
            textBoxSalaryAccrualIDSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSalaryAccrualIDSalary.Location = new Point(292, 331);
            textBoxSalaryAccrualIDSalary.Margin = new Padding(4, 3, 4, 3);
            textBoxSalaryAccrualIDSalary.Name = "textBoxSalaryAccrualIDSalary";
            textBoxSalaryAccrualIDSalary.Size = new Size(455, 33);
            textBoxSalaryAccrualIDSalary.TabIndex = 26;
            // 
            // labelEmployeeIDSalary
            // 
            labelEmployeeIDSalary.AutoSize = true;
            labelEmployeeIDSalary.BackColor = Color.Transparent;
            labelEmployeeIDSalary.ForeColor = Color.Black;
            labelEmployeeIDSalary.Location = new Point(172, 380);
            labelEmployeeIDSalary.Margin = new Padding(4, 0, 4, 0);
            labelEmployeeIDSalary.Name = "labelEmployeeIDSalary";
            labelEmployeeIDSalary.Size = new Size(114, 15);
            labelEmployeeIDSalary.TabIndex = 39;
            labelEmployeeIDSalary.Text = "Номер сотрудника:";
            // 
            // textBoxEmployeeIDSalary
            // 
            textBoxEmployeeIDSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDSalary.Location = new Point(292, 369);
            textBoxEmployeeIDSalary.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDSalary.Name = "textBoxEmployeeIDSalary";
            textBoxEmployeeIDSalary.Size = new Size(455, 33);
            textBoxEmployeeIDSalary.TabIndex = 27;
            // 
            // labelAllDays
            // 
            labelAllDays.AutoSize = true;
            labelAllDays.BackColor = Color.Transparent;
            labelAllDays.ForeColor = Color.Black;
            labelAllDays.Location = new Point(183, 419);
            labelAllDays.Margin = new Padding(4, 0, 4, 0);
            labelAllDays.Name = "labelAllDays";
            labelAllDays.Size = new Size(105, 15);
            labelAllDays.TabIndex = 40;
            labelAllDays.Text = "Дней отработано:";
            // 
            // textBoxAllDays
            // 
            textBoxAllDays.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAllDays.Location = new Point(292, 408);
            textBoxAllDays.Margin = new Padding(4, 3, 4, 3);
            textBoxAllDays.Name = "textBoxAllDays";
            textBoxAllDays.ReadOnly = true;
            textBoxAllDays.Size = new Size(455, 33);
            textBoxAllDays.TabIndex = 28;
            // 
            // labelAllHours
            // 
            labelAllHours.AutoSize = true;
            labelAllHours.BackColor = Color.Transparent;
            labelAllHours.ForeColor = Color.Black;
            labelAllHours.Location = new Point(176, 458);
            labelAllHours.Margin = new Padding(4, 0, 4, 0);
            labelAllHours.Name = "labelAllHours";
            labelAllHours.Size = new Size(110, 15);
            labelAllHours.TabIndex = 41;
            labelAllHours.Text = "Часов отработано:";
            // 
            // textBoxAllHours
            // 
            textBoxAllHours.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAllHours.Location = new Point(292, 447);
            textBoxAllHours.Margin = new Padding(4, 3, 4, 3);
            textBoxAllHours.Name = "textBoxAllHours";
            textBoxAllHours.ReadOnly = true;
            textBoxAllHours.Size = new Size(455, 33);
            textBoxAllHours.TabIndex = 29;
            // 
            // labelPieceworkCharges
            // 
            labelPieceworkCharges.AutoSize = true;
            labelPieceworkCharges.BackColor = Color.Transparent;
            labelPieceworkCharges.ForeColor = Color.Black;
            labelPieceworkCharges.Location = new Point(167, 497);
            labelPieceworkCharges.Margin = new Padding(4, 0, 4, 0);
            labelPieceworkCharges.Name = "labelPieceworkCharges";
            labelPieceworkCharges.Size = new Size(114, 15);
            labelPieceworkCharges.TabIndex = 42;
            labelPieceworkCharges.Text = "Сдельная зарплата:";
            // 
            // textBoxPieceworkCharges
            // 
            textBoxPieceworkCharges.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPieceworkCharges.Location = new Point(292, 486);
            textBoxPieceworkCharges.Margin = new Padding(4, 3, 4, 3);
            textBoxPieceworkCharges.Name = "textBoxPieceworkCharges";
            textBoxPieceworkCharges.Size = new Size(455, 33);
            textBoxPieceworkCharges.TabIndex = 30;
            // 
            // labelHourlyCharges
            // 
            labelHourlyCharges.AutoSize = true;
            labelHourlyCharges.BackColor = Color.Transparent;
            labelHourlyCharges.ForeColor = Color.Black;
            labelHourlyCharges.Location = new Point(164, 535);
            labelHourlyCharges.Margin = new Padding(4, 0, 4, 0);
            labelHourlyCharges.Name = "labelHourlyCharges";
            labelHourlyCharges.Size = new Size(122, 15);
            labelHourlyCharges.TabIndex = 43;
            labelHourlyCharges.Text = "Почасовая зарплата:";
            // 
            // textBoxHourlyCharges
            // 
            textBoxHourlyCharges.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHourlyCharges.Location = new Point(292, 525);
            textBoxHourlyCharges.Margin = new Padding(4, 3, 4, 3);
            textBoxHourlyCharges.Name = "textBoxHourlyCharges";
            textBoxHourlyCharges.Size = new Size(455, 33);
            textBoxHourlyCharges.TabIndex = 31;
            // 
            // labelVacationPay
            // 
            labelVacationPay.AutoSize = true;
            labelVacationPay.BackColor = Color.Transparent;
            labelVacationPay.ForeColor = Color.Black;
            labelVacationPay.Location = new Point(210, 575);
            labelVacationPay.Margin = new Padding(4, 0, 4, 0);
            labelVacationPay.Name = "labelVacationPay";
            labelVacationPay.Size = new Size(71, 15);
            labelVacationPay.TabIndex = 44;
            labelVacationPay.Text = "Отпускные:";
            // 
            // textBoxVacationPay
            // 
            textBoxVacationPay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVacationPay.Location = new Point(292, 564);
            textBoxVacationPay.Margin = new Padding(4, 3, 4, 3);
            textBoxVacationPay.Name = "textBoxVacationPay";
            textBoxVacationPay.ReadOnly = true;
            textBoxVacationPay.Size = new Size(455, 33);
            textBoxVacationPay.TabIndex = 32;
            // 
            // labelSickPay
            // 
            labelSickPay.AutoSize = true;
            labelSickPay.BackColor = Color.Transparent;
            labelSickPay.ForeColor = Color.Black;
            labelSickPay.Location = new Point(206, 614);
            labelSickPay.Margin = new Padding(4, 0, 4, 0);
            labelSickPay.Name = "labelSickPay";
            labelSickPay.Size = new Size(80, 15);
            labelSickPay.TabIndex = 45;
            labelSickPay.Text = "Больничные:";
            // 
            // textBoxSickPay
            // 
            textBoxSickPay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSickPay.Location = new Point(292, 603);
            textBoxSickPay.Margin = new Padding(4, 3, 4, 3);
            textBoxSickPay.Name = "textBoxSickPay";
            textBoxSickPay.ReadOnly = true;
            textBoxSickPay.Size = new Size(455, 33);
            textBoxSickPay.TabIndex = 33;
            // 
            // labelPersonalIncomeTax
            // 
            labelPersonalIncomeTax.AutoSize = true;
            labelPersonalIncomeTax.BackColor = Color.Transparent;
            labelPersonalIncomeTax.ForeColor = Color.Black;
            labelPersonalIncomeTax.Location = new Point(237, 653);
            labelPersonalIncomeTax.Margin = new Padding(4, 0, 4, 0);
            labelPersonalIncomeTax.Name = "labelPersonalIncomeTax";
            labelPersonalIncomeTax.Size = new Size(44, 15);
            labelPersonalIncomeTax.TabIndex = 46;
            labelPersonalIncomeTax.Text = "НДФЛ:";
            // 
            // textBoxPersonalIncomeTax
            // 
            textBoxPersonalIncomeTax.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPersonalIncomeTax.Location = new Point(292, 642);
            textBoxPersonalIncomeTax.Margin = new Padding(4, 3, 4, 3);
            textBoxPersonalIncomeTax.Name = "textBoxPersonalIncomeTax";
            textBoxPersonalIncomeTax.Size = new Size(455, 33);
            textBoxPersonalIncomeTax.TabIndex = 34;
            // 
            // labelContributions
            // 
            labelContributions.AutoSize = true;
            labelContributions.BackColor = Color.Transparent;
            labelContributions.ForeColor = Color.Black;
            labelContributions.Location = new Point(233, 692);
            labelContributions.Margin = new Padding(4, 0, 4, 0);
            labelContributions.Name = "labelContributions";
            labelContributions.Size = new Size(48, 15);
            labelContributions.TabIndex = 47;
            labelContributions.Text = "Сборы:";
            // 
            // textBoxContributions
            // 
            textBoxContributions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxContributions.Location = new Point(292, 681);
            textBoxContributions.Margin = new Padding(4, 3, 4, 3);
            textBoxContributions.Name = "textBoxContributions";
            textBoxContributions.Size = new Size(455, 33);
            textBoxContributions.TabIndex = 35;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.Transparent;
            labelTotal.ForeColor = Color.Black;
            labelTotal.Location = new Point(238, 731);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(43, 15);
            labelTotal.TabIndex = 48;
            labelTotal.Text = "Итого:";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTotal.Location = new Point(292, 720);
            textBoxTotal.Margin = new Padding(4, 3, 4, 3);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(455, 33);
            textBoxTotal.TabIndex = 36;
            // 
            // AddFormSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelSalaryID);
            Controls.Add(textBoxSalaryID);
            Controls.Add(labelSalaryAccrualIDSalary);
            Controls.Add(textBoxSalaryAccrualIDSalary);
            Controls.Add(labelEmployeeIDSalary);
            Controls.Add(textBoxEmployeeIDSalary);
            Controls.Add(labelAllDays);
            Controls.Add(textBoxAllDays);
            Controls.Add(labelAllHours);
            Controls.Add(textBoxAllHours);
            Controls.Add(labelPieceworkCharges);
            Controls.Add(textBoxPieceworkCharges);
            Controls.Add(labelHourlyCharges);
            Controls.Add(textBoxHourlyCharges);
            Controls.Add(labelVacationPay);
            Controls.Add(textBoxVacationPay);
            Controls.Add(labelSickPay);
            Controls.Add(textBoxSickPay);
            Controls.Add(labelPersonalIncomeTax);
            Controls.Add(textBoxPersonalIncomeTax);
            Controls.Add(labelContributions);
            Controls.Add(textBoxContributions);
            Controls.Add(labelTotal);
            Controls.Add(textBoxTotal);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddFormSalary";
            Text = "Добавить начисление зарплаты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelSalaryID;
        private TextBox textBoxSalaryID;
        private Label labelSalaryAccrualIDSalary;
        private TextBox textBoxSalaryAccrualIDSalary;
        private Label labelEmployeeIDSalary;
        private TextBox textBoxEmployeeIDSalary;
        private Label labelAllDays;
        private TextBox textBoxAllDays;
        private Label labelAllHours;
        private TextBox textBoxAllHours;
        private Label labelPieceworkCharges;
        private TextBox textBoxPieceworkCharges;
        private Label labelHourlyCharges;
        private TextBox textBoxHourlyCharges;
        private Label labelVacationPay;
        private TextBox textBoxVacationPay;
        private Label labelSickPay;
        private TextBox textBoxSickPay;
        private Label labelPersonalIncomeTax;
        private TextBox textBoxPersonalIncomeTax;
        private Label labelContributions;
        private TextBox textBoxContributions;
        private Label labelTotal;
        private TextBox textBoxTotal;
    }
}