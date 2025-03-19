namespace WorkTrack
{
    partial class AddFormProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormProjects));
            buttonSave = new Button();
            labelTitle = new Label();
            label1 = new Label();
            labelProjectName = new Label();
            textBoxProjectName = new TextBox();
            labelHourly = new Label();
            textBoxHourly = new TextBox();
            labePieceWork = new Label();
            textBoxPieceWork = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Transparent;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.WhiteSmoke;
            buttonSave.Location = new Point(330, 763);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(236, 65);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(243, 10);
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
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(244, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 5;
            label1.Text = "Проект";
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.BackColor = Color.Transparent;
            labelProjectName.ForeColor = Color.Black;
            labelProjectName.Location = new Point(172, 504);
            labelProjectName.Margin = new Padding(4, 0, 4, 0);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(109, 15);
            labelProjectName.TabIndex = 6;
            labelProjectName.Text = "Название проекта:";
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxProjectName.Location = new Point(292, 493);
            textBoxProjectName.Margin = new Padding(4, 3, 4, 3);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.Size = new Size(455, 33);
            textBoxProjectName.TabIndex = 0;
            // 
            // labelHourly
            // 
            labelHourly.AutoSize = true;
            labelHourly.BackColor = Color.Transparent;
            labelHourly.ForeColor = Color.Black;
            labelHourly.Location = new Point(175, 549);
            labelHourly.Margin = new Padding(4, 0, 4, 0);
            labelHourly.Name = "labelHourly";
            labelHourly.Size = new Size(111, 15);
            labelHourly.TabIndex = 7;
            labelHourly.Text = "Почасовая оплата:";
            // 
            // textBoxHourly
            // 
            textBoxHourly.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHourly.Location = new Point(292, 538);
            textBoxHourly.Margin = new Padding(4, 3, 4, 3);
            textBoxHourly.Name = "textBoxHourly";
            textBoxHourly.Size = new Size(455, 33);
            textBoxHourly.TabIndex = 1;
            // 
            // labePieceWork
            // 
            labePieceWork.AutoSize = true;
            labePieceWork.BackColor = Color.Transparent;
            labePieceWork.ForeColor = Color.Black;
            labePieceWork.Location = new Point(183, 594);
            labePieceWork.Margin = new Padding(4, 0, 4, 0);
            labePieceWork.Name = "labePieceWork";
            labePieceWork.Size = new Size(103, 15);
            labePieceWork.TabIndex = 8;
            labePieceWork.Text = "Сдельная оплата:";
            // 
            // textBoxPieceWork
            // 
            textBoxPieceWork.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPieceWork.Location = new Point(292, 583);
            textBoxPieceWork.Margin = new Padding(4, 3, 4, 3);
            textBoxPieceWork.Name = "textBoxPieceWork";
            textBoxPieceWork.Size = new Size(455, 33);
            textBoxPieceWork.TabIndex = 2;
            // 
            // AddFormProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 841);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(labelProjectName);
            Controls.Add(textBoxProjectName);
            Controls.Add(labelHourly);
            Controls.Add(textBoxHourly);
            Controls.Add(labePieceWork);
            Controls.Add(textBoxPieceWork);
            Controls.Add(buttonSave);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormProjects";
            Text = "Добавить проект";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private Label labelProjectName;
        private TextBox textBoxProjectName;
        private Label labelHourly;
        private TextBox textBoxHourly;
        private Label labePieceWork;
        private TextBox textBoxPieceWork;
    }
}