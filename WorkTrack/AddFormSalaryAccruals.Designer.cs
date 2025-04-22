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
            label1 = new Label();
            buttonSave = new Button();
            textBoxYear = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            comboBoxProjectIDSalaryAccruals = new ComboBox();
            label4 = new Label();
            comboBoxMonthID = new ComboBox();
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
            label1.Size = new Size(171, 46);
            label1.TabIndex = 5;
            label1.Text = "Зарплата";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(10, 189, 188);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(45, 225);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 46);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxYear.Location = new Point(45, 24);
            textBoxYear.Margin = new Padding(4, 3, 4, 3);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.PlaceholderText = "Год";
            textBoxYear.Size = new Size(455, 33);
            textBoxYear.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 95, 106);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxProjectIDSalaryAccruals);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxMonthID);
            panel1.Controls.Add(textBoxYear);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(123, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 291);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(232, 129);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 19;
            label3.Text = "Проект:";
            // 
            // comboBoxProjectIDSalaryAccruals
            // 
            comboBoxProjectIDSalaryAccruals.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProjectIDSalaryAccruals.Font = new Font("Segoe UI", 14.25F);
            comboBoxProjectIDSalaryAccruals.FormattingEnabled = true;
            comboBoxProjectIDSalaryAccruals.Location = new Point(45, 160);
            comboBoxProjectIDSalaryAccruals.Name = "comboBoxProjectIDSalaryAccruals";
            comboBoxProjectIDSalaryAccruals.Size = new Size(455, 33);
            comboBoxProjectIDSalaryAccruals.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(232, 62);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 17;
            label4.Text = "Месяц:";
            // 
            // comboBoxMonthID
            // 
            comboBoxMonthID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonthID.Font = new Font("Segoe UI", 14.25F);
            comboBoxMonthID.FormattingEnabled = true;
            comboBoxMonthID.Location = new Point(45, 93);
            comboBoxMonthID.Name = "comboBoxMonthID";
            comboBoxMonthID.Size = new Size(455, 33);
            comboBoxMonthID.TabIndex = 1;
            // 
            // AddFormSalaryAccruals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 75, 86);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 455);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormSalaryAccruals";
            Text = "Добавить зарплату";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonSave;
        private TextBox textBoxYear;
        private Panel panel1;
        private Label label3;
        private ComboBox comboBoxProjectIDSalaryAccruals;
        private Label label4;
        private ComboBox comboBoxMonthID;
    }
}