namespace WorkTrack
{
    partial class AddFormSalaryAccruals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormSalaryAccruals));
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelYear = new Label();
            textBoxYear = new TextBox();
            labelMonthID = new Label();
            comboBoxMonthID = new ComboBox();
            labelProjectIDSalaryAccruals = new Label();
            textBoxProjectIDSalaryAccruals = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(241, 9);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(175, 25);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(242, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 5;
            label1.Text = "Зарплата";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(328, 762);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = Color.Transparent;
            labelYear.ForeColor = Color.Black;
            labelYear.Location = new Point(250, 503);
            labelYear.Margin = new Padding(4, 0, 4, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(29, 15);
            labelYear.TabIndex = 6;
            labelYear.Text = "Год:";
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxYear.Location = new Point(290, 492);
            textBoxYear.Margin = new Padding(4, 3, 4, 3);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(455, 33);
            textBoxYear.TabIndex = 0;
            // 
            // labelMonthID
            // 
            labelMonthID.AutoSize = true;
            labelMonthID.BackColor = Color.Transparent;
            labelMonthID.ForeColor = Color.Black;
            labelMonthID.Location = new Point(233, 548);
            labelMonthID.Margin = new Padding(4, 0, 4, 0);
            labelMonthID.Name = "labelMonthID";
            labelMonthID.Size = new Size(46, 15);
            labelMonthID.TabIndex = 7;
            labelMonthID.Text = "Месяц:";
            // 
            // comboBoxMonthID
            // 
            comboBoxMonthID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonthID.Font = new Font("Segoe UI", 14.25F);
            comboBoxMonthID.FormattingEnabled = true;
            comboBoxMonthID.Location = new Point(290, 537);
            comboBoxMonthID.Name = "comboBoxMonthID";
            comboBoxMonthID.Size = new Size(455, 33);
            comboBoxMonthID.TabIndex = 1;
            // 
            // labelProjectIDSalaryAccruals
            // 
            labelProjectIDSalaryAccruals.AutoSize = true;
            labelProjectIDSalaryAccruals.BackColor = Color.Transparent;
            labelProjectIDSalaryAccruals.ForeColor = Color.Black;
            labelProjectIDSalaryAccruals.Location = new Point(229, 593);
            labelProjectIDSalaryAccruals.Margin = new Padding(4, 0, 4, 0);
            labelProjectIDSalaryAccruals.Name = "labelProjectIDSalaryAccruals";
            labelProjectIDSalaryAccruals.Size = new Size(50, 15);
            labelProjectIDSalaryAccruals.TabIndex = 8;
            labelProjectIDSalaryAccruals.Text = "Проект:";
            // 
            // textBoxProjectIDSalaryAccruals
            // 
            textBoxProjectIDSalaryAccruals.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxProjectIDSalaryAccruals.Location = new Point(290, 582);
            textBoxProjectIDSalaryAccruals.Margin = new Padding(4, 3, 4, 3);
            textBoxProjectIDSalaryAccruals.Name = "textBoxProjectIDSalaryAccruals";
            textBoxProjectIDSalaryAccruals.ReadOnly = true;
            textBoxProjectIDSalaryAccruals.Size = new Size(455, 33);
            textBoxProjectIDSalaryAccruals.TabIndex = 2;
            // 
            // AddFormSalaryAccruals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelYear);
            Controls.Add(textBoxYear);
            Controls.Add(labelMonthID);
            Controls.Add(comboBoxMonthID);
            Controls.Add(labelProjectIDSalaryAccruals);
            Controls.Add(textBoxProjectIDSalaryAccruals);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormSalaryAccruals";
            Text = "Добавить зарплату";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelYear;
        private TextBox textBoxYear;
        private Label labelMonthID;
        private ComboBox comboBoxMonthID;
        private Label labelProjectIDSalaryAccruals;
        private TextBox textBoxProjectIDSalaryAccruals;
    }
}