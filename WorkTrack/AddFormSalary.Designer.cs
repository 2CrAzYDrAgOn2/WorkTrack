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
            label1 = new Label();
            buttonSave = new Button();
            textBoxSalaryAccrualIDSalary = new TextBox();
            textBoxEmployeeIDSalary = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(209, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 46);
            label1.TabIndex = 13;
            label1.Text = "Начисление зарплаты";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(10, 189, 188);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(44, 153);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 46);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textBoxSalaryAccrualIDSalary
            // 
            textBoxSalaryAccrualIDSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSalaryAccrualIDSalary.Location = new Point(44, 26);
            textBoxSalaryAccrualIDSalary.Margin = new Padding(4, 3, 4, 3);
            textBoxSalaryAccrualIDSalary.Name = "textBoxSalaryAccrualIDSalary";
            textBoxSalaryAccrualIDSalary.PlaceholderText = "Номер зарплаты";
            textBoxSalaryAccrualIDSalary.Size = new Size(455, 33);
            textBoxSalaryAccrualIDSalary.TabIndex = 0;
            // 
            // textBoxEmployeeIDSalary
            // 
            textBoxEmployeeIDSalary.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDSalary.Location = new Point(44, 86);
            textBoxEmployeeIDSalary.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDSalary.Name = "textBoxEmployeeIDSalary";
            textBoxEmployeeIDSalary.PlaceholderText = "Номер сотрудника";
            textBoxEmployeeIDSalary.Size = new Size(455, 33);
            textBoxEmployeeIDSalary.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 95, 106);
            panel1.Controls.Add(textBoxSalaryAccrualIDSalary);
            panel1.Controls.Add(textBoxEmployeeIDSalary);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(123, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 217);
            panel1.TabIndex = 14;
            // 
            // AddFormSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 75, 86);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 385);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormSalary";
            Text = "Добавить начисление зарплаты";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonSave;
        private TextBox textBoxSalaryAccrualIDSalary;
        private TextBox textBoxEmployeeIDSalary;
        private Panel panel1;
    }
}