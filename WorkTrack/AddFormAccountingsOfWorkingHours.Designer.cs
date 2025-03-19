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
            labelTitle = new Label();
            label1 = new Label();
            buttonSave = new Button();
            labelEmployeeIDAccountingsOfWorkingHours = new Label();
            textBoxEmployeeIDAccountingsOfWorkingHours = new TextBox();
            labelProjectIDAccountingsOfWorkingHours = new Label();
            textBoxProjectIDAccountingsOfWorkingHours = new TextBox();
            labelTypeOfRemunerationID = new Label();
            comboBoxTypeOfRemunerationID = new ComboBox();
            labelHoursOfWork = new Label();
            textBoxHoursOfWork = new TextBox();
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
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Создание записи:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(242, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 6;
            label1.Text = "Учет времени";
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
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelEmployeeIDAccountingsOfWorkingHours
            // 
            labelEmployeeIDAccountingsOfWorkingHours.AutoSize = true;
            labelEmployeeIDAccountingsOfWorkingHours.BackColor = Color.Transparent;
            labelEmployeeIDAccountingsOfWorkingHours.ForeColor = Color.Black;
            labelEmployeeIDAccountingsOfWorkingHours.Location = new Point(170, 503);
            labelEmployeeIDAccountingsOfWorkingHours.Margin = new Padding(4, 0, 4, 0);
            labelEmployeeIDAccountingsOfWorkingHours.Name = "labelEmployeeIDAccountingsOfWorkingHours";
            labelEmployeeIDAccountingsOfWorkingHours.Size = new Size(114, 15);
            labelEmployeeIDAccountingsOfWorkingHours.TabIndex = 7;
            labelEmployeeIDAccountingsOfWorkingHours.Text = "Номер сотрудника:";
            // 
            // textBoxEmployeeIDAccountingsOfWorkingHours
            // 
            textBoxEmployeeIDAccountingsOfWorkingHours.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEmployeeIDAccountingsOfWorkingHours.Location = new Point(290, 492);
            textBoxEmployeeIDAccountingsOfWorkingHours.Margin = new Padding(4, 3, 4, 3);
            textBoxEmployeeIDAccountingsOfWorkingHours.Name = "textBoxEmployeeIDAccountingsOfWorkingHours";
            textBoxEmployeeIDAccountingsOfWorkingHours.Size = new Size(455, 33);
            textBoxEmployeeIDAccountingsOfWorkingHours.TabIndex = 0;
            // 
            // labelProjectIDAccountingsOfWorkingHours
            // 
            labelProjectIDAccountingsOfWorkingHours.AutoSize = true;
            labelProjectIDAccountingsOfWorkingHours.BackColor = Color.Transparent;
            labelProjectIDAccountingsOfWorkingHours.ForeColor = Color.Black;
            labelProjectIDAccountingsOfWorkingHours.Location = new Point(229, 548);
            labelProjectIDAccountingsOfWorkingHours.Margin = new Padding(4, 0, 4, 0);
            labelProjectIDAccountingsOfWorkingHours.Name = "labelProjectIDAccountingsOfWorkingHours";
            labelProjectIDAccountingsOfWorkingHours.Size = new Size(50, 15);
            labelProjectIDAccountingsOfWorkingHours.TabIndex = 8;
            labelProjectIDAccountingsOfWorkingHours.Text = "Проект:";
            // 
            // textBoxProjectIDAccountingsOfWorkingHours
            // 
            textBoxProjectIDAccountingsOfWorkingHours.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxProjectIDAccountingsOfWorkingHours.Location = new Point(290, 537);
            textBoxProjectIDAccountingsOfWorkingHours.Margin = new Padding(4, 3, 4, 3);
            textBoxProjectIDAccountingsOfWorkingHours.Name = "textBoxProjectIDAccountingsOfWorkingHours";
            textBoxProjectIDAccountingsOfWorkingHours.Size = new Size(455, 33);
            textBoxProjectIDAccountingsOfWorkingHours.TabIndex = 1;
            // 
            // labelTypeOfRemunerationID
            // 
            labelTypeOfRemunerationID.AutoSize = true;
            labelTypeOfRemunerationID.BackColor = Color.Transparent;
            labelTypeOfRemunerationID.ForeColor = Color.Black;
            labelTypeOfRemunerationID.Location = new Point(205, 593);
            labelTypeOfRemunerationID.Margin = new Padding(4, 0, 4, 0);
            labelTypeOfRemunerationID.Name = "labelTypeOfRemunerationID";
            labelTypeOfRemunerationID.Size = new Size(74, 15);
            labelTypeOfRemunerationID.TabIndex = 9;
            labelTypeOfRemunerationID.Text = "Тип работы:";
            // 
            // comboBoxTypeOfRemunerationID
            // 
            comboBoxTypeOfRemunerationID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeOfRemunerationID.Font = new Font("Segoe UI", 14.25F);
            comboBoxTypeOfRemunerationID.FormattingEnabled = true;
            comboBoxTypeOfRemunerationID.Items.AddRange(new object[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            comboBoxTypeOfRemunerationID.Location = new Point(291, 582);
            comboBoxTypeOfRemunerationID.Name = "comboBoxTypeOfRemunerationID";
            comboBoxTypeOfRemunerationID.Size = new Size(455, 33);
            comboBoxTypeOfRemunerationID.TabIndex = 2;
            // 
            // labelHoursOfWork
            // 
            labelHoursOfWork.AutoSize = true;
            labelHoursOfWork.BackColor = Color.Transparent;
            labelHoursOfWork.ForeColor = Color.Black;
            labelHoursOfWork.Location = new Point(204, 638);
            labelHoursOfWork.Margin = new Padding(4, 0, 4, 0);
            labelHoursOfWork.Name = "labelHoursOfWork";
            labelHoursOfWork.Size = new Size(75, 15);
            labelHoursOfWork.TabIndex = 10;
            labelHoursOfWork.Text = "Количество:";
            // 
            // textBoxHoursOfWork
            // 
            textBoxHoursOfWork.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHoursOfWork.Location = new Point(290, 627);
            textBoxHoursOfWork.Margin = new Padding(4, 3, 4, 3);
            textBoxHoursOfWork.Name = "textBoxHoursOfWork";
            textBoxHoursOfWork.Size = new Size(455, 33);
            textBoxHoursOfWork.TabIndex = 3;
            // 
            // AddFormAccountingsOfWorkingHours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelEmployeeIDAccountingsOfWorkingHours);
            Controls.Add(textBoxEmployeeIDAccountingsOfWorkingHours);
            Controls.Add(labelProjectIDAccountingsOfWorkingHours);
            Controls.Add(textBoxProjectIDAccountingsOfWorkingHours);
            Controls.Add(labelTypeOfRemunerationID);
            Controls.Add(comboBoxTypeOfRemunerationID);
            Controls.Add(labelHoursOfWork);
            Controls.Add(textBoxHoursOfWork);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormAccountingsOfWorkingHours";
            Text = "Добавить учет времени";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Button buttonSave;
        private Label labelEmployeeIDAccountingsOfWorkingHours;
        private TextBox textBoxEmployeeIDAccountingsOfWorkingHours;
        private Label labelProjectIDAccountingsOfWorkingHours;
        private TextBox textBoxProjectIDAccountingsOfWorkingHours;
        private Label labelTypeOfRemunerationID;
        private ComboBox comboBoxTypeOfRemunerationID;
        private Label labelHoursOfWork;
        private TextBox textBoxHoursOfWork;
    }
}