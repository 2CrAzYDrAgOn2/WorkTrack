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
            labelSalaryAccrualIDSalary = new Label();
            textBoxSalaryAccrualIDSalary = new TextBox();
            labelEmployeeIDSalary = new Label();
            textBoxEmployeeIDSalary = new TextBox();
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
            labelTitle.TabIndex = 12;
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
            label1.TabIndex = 13;
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
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
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
            labelSalaryAccrualIDSalary.TabIndex = 14;
            labelSalaryAccrualIDSalary.Text = "Номер зарплаты:";
            // 
            // textBoxSalaryAccrualIDSalary
            // 
            textBoxSalaryAccrualIDSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSalaryAccrualIDSalary.Location = new Point(292, 331);
            textBoxSalaryAccrualIDSalary.Margin = new Padding(4, 3, 4, 3);
            textBoxSalaryAccrualIDSalary.Name = "textBoxSalaryAccrualIDSalary";
            textBoxSalaryAccrualIDSalary.Size = new Size(455, 33);
            textBoxSalaryAccrualIDSalary.TabIndex = 0;
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
            labelEmployeeIDSalary.TabIndex = 15;
            labelEmployeeIDSalary.Text = "Номер сотрудника:";
            // 
            // textBoxEmployeeIDSalary
            // 
            textBoxEmployeeIDSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDSalary.Location = new Point(292, 369);
            textBoxEmployeeIDSalary.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDSalary.Name = "textBoxEmployeeIDSalary";
            textBoxEmployeeIDSalary.Size = new Size(455, 33);
            textBoxEmployeeIDSalary.TabIndex = 1;
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
            Controls.Add(labelSalaryAccrualIDSalary);
            Controls.Add(textBoxSalaryAccrualIDSalary);
            Controls.Add(labelEmployeeIDSalary);
            Controls.Add(textBoxEmployeeIDSalary);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormSalary";
            Text = "Добавить начисление зарплаты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelSalaryAccrualIDSalary;
        private TextBox textBoxSalaryAccrualIDSalary;
        private Label labelEmployeeIDSalary;
        private TextBox textBoxEmployeeIDSalary;
    }
}