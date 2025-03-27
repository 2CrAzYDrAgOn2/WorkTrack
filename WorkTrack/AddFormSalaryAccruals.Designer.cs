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
            labelMonthID = new Label();
            comboBoxMonthID = new ComboBox();
            textBoxProjectIDSalaryAccruals = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(302, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 46);
            label1.TabIndex = 5;
            label1.Text = "Зарплата";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
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
            // labelMonthID
            // 
            labelMonthID.AutoSize = true;
            labelMonthID.BackColor = Color.Transparent;
            labelMonthID.Font = new Font("Segoe UI", 15F);
            labelMonthID.ForeColor = Color.Black;
            labelMonthID.Location = new Point(232, 65);
            labelMonthID.Margin = new Padding(4, 0, 4, 0);
            labelMonthID.Name = "labelMonthID";
            labelMonthID.Size = new Size(75, 28);
            labelMonthID.TabIndex = 7;
            labelMonthID.Text = "Месяц:";
            // 
            // comboBoxMonthID
            // 
            comboBoxMonthID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonthID.Font = new Font("Segoe UI", 14.25F);
            comboBoxMonthID.FormattingEnabled = true;
            comboBoxMonthID.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            comboBoxMonthID.Location = new Point(45, 96);
            comboBoxMonthID.Name = "comboBoxMonthID";
            comboBoxMonthID.Size = new Size(455, 33);
            comboBoxMonthID.TabIndex = 1;
            // 
            // textBoxProjectIDSalaryAccruals
            // 
            textBoxProjectIDSalaryAccruals.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxProjectIDSalaryAccruals.Location = new Point(45, 161);
            textBoxProjectIDSalaryAccruals.Margin = new Padding(4, 3, 4, 3);
            textBoxProjectIDSalaryAccruals.Name = "textBoxProjectIDSalaryAccruals";
            textBoxProjectIDSalaryAccruals.PlaceholderText = "Проект";
            textBoxProjectIDSalaryAccruals.Size = new Size(455, 33);
            textBoxProjectIDSalaryAccruals.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(textBoxYear);
            panel1.Controls.Add(textBoxProjectIDSalaryAccruals);
            panel1.Controls.Add(labelMonthID);
            panel1.Controls.Add(comboBoxMonthID);
            panel1.Location = new Point(123, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 291);
            panel1.TabIndex = 8;
            // 
            // AddFormSalaryAccruals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private Label labelMonthID;
        private ComboBox comboBoxMonthID;
        private TextBox textBoxProjectIDSalaryAccruals;
        private Panel panel1;
    }
}