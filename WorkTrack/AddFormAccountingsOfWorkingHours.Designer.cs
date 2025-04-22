namespace WorkTrack
{
    partial class AddFormAccountingsOfWorkingHours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormAccountingsOfWorkingHours));
            label1 = new Label();
            buttonSave = new Button();
            comboBoxTypeOfRemunerationID = new ComboBox();
            textBoxHoursOfWork = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            comboBoxProjectIDAccountingsOfWorkingHours = new ComboBox();
            label2 = new Label();
            comboBoxEmployeeIDAccountingsOfWorkingHours = new ComboBox();
            labelTypeOfRenumerationID = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(278, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 46);
            label1.TabIndex = 6;
            label1.Text = "Учет времени";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(10, 189, 188);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(38, 283);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 46);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // comboBoxTypeOfRemunerationID
            // 
            comboBoxTypeOfRemunerationID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeOfRemunerationID.Font = new Font("Segoe UI", 14.25F);
            comboBoxTypeOfRemunerationID.FormattingEnabled = true;
            comboBoxTypeOfRemunerationID.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            comboBoxTypeOfRemunerationID.Location = new Point(38, 165);
            comboBoxTypeOfRemunerationID.Name = "comboBoxTypeOfRemunerationID";
            comboBoxTypeOfRemunerationID.Size = new Size(455, 33);
            comboBoxTypeOfRemunerationID.TabIndex = 2;
            // 
            // textBoxHoursOfWork
            // 
            textBoxHoursOfWork.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHoursOfWork.Location = new Point(38, 225);
            textBoxHoursOfWork.Margin = new Padding(4, 3, 4, 3);
            textBoxHoursOfWork.Name = "textBoxHoursOfWork";
            textBoxHoursOfWork.PlaceholderText = "Количество";
            textBoxHoursOfWork.Size = new Size(455, 33);
            textBoxHoursOfWork.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 95, 106);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxProjectIDAccountingsOfWorkingHours);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxEmployeeIDAccountingsOfWorkingHours);
            panel1.Controls.Add(labelTypeOfRenumerationID);
            panel1.Controls.Add(comboBoxTypeOfRemunerationID);
            panel1.Controls.Add(textBoxHoursOfWork);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(125, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 344);
            panel1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(226, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 12;
            label3.Text = "Проект:";
            // 
            // comboBoxProjectIDAccountingsOfWorkingHours
            // 
            comboBoxProjectIDAccountingsOfWorkingHours.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProjectIDAccountingsOfWorkingHours.Font = new Font("Segoe UI", 14.25F);
            comboBoxProjectIDAccountingsOfWorkingHours.FormattingEnabled = true;
            comboBoxProjectIDAccountingsOfWorkingHours.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            comboBoxProjectIDAccountingsOfWorkingHours.Location = new Point(38, 98);
            comboBoxProjectIDAccountingsOfWorkingHours.Name = "comboBoxProjectIDAccountingsOfWorkingHours";
            comboBoxProjectIDAccountingsOfWorkingHours.Size = new Size(455, 33);
            comboBoxProjectIDAccountingsOfWorkingHours.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(183, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 10;
            label2.Text = "ФИО сотрудника:";
            // 
            // comboBoxEmployeeIDAccountingsOfWorkingHours
            // 
            comboBoxEmployeeIDAccountingsOfWorkingHours.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployeeIDAccountingsOfWorkingHours.Font = new Font("Segoe UI", 14.25F);
            comboBoxEmployeeIDAccountingsOfWorkingHours.FormattingEnabled = true;
            comboBoxEmployeeIDAccountingsOfWorkingHours.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            comboBoxEmployeeIDAccountingsOfWorkingHours.Location = new Point(38, 31);
            comboBoxEmployeeIDAccountingsOfWorkingHours.Name = "comboBoxEmployeeIDAccountingsOfWorkingHours";
            comboBoxEmployeeIDAccountingsOfWorkingHours.Size = new Size(455, 33);
            comboBoxEmployeeIDAccountingsOfWorkingHours.TabIndex = 0;
            // 
            // labelTypeOfRenumerationID
            // 
            labelTypeOfRenumerationID.AutoSize = true;
            labelTypeOfRenumerationID.BackColor = Color.Transparent;
            labelTypeOfRenumerationID.Font = new Font("Segoe UI", 15F);
            labelTypeOfRenumerationID.ForeColor = Color.White;
            labelTypeOfRenumerationID.Location = new Point(204, 134);
            labelTypeOfRenumerationID.Margin = new Padding(4, 0, 4, 0);
            labelTypeOfRenumerationID.Name = "labelTypeOfRenumerationID";
            labelTypeOfRenumerationID.Size = new Size(123, 28);
            labelTypeOfRenumerationID.TabIndex = 8;
            labelTypeOfRenumerationID.Text = "Тип работы:";
            // 
            // AddFormAccountingsOfWorkingHours
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
            Name = "AddFormAccountingsOfWorkingHours";
            Text = "Добавить учет времени";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonSave;
        private ComboBox comboBoxTypeOfRemunerationID;
        private TextBox textBoxHoursOfWork;
        private Panel panel1;
        private Label labelTypeOfRenumerationID;
        private Label label3;
        private ComboBox comboBoxProjectIDAccountingsOfWorkingHours;
        private Label label2;
        private ComboBox comboBoxEmployeeIDAccountingsOfWorkingHours;
    }
}