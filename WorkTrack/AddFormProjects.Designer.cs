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
            label1 = new Label();
            textBoxProjectName = new TextBox();
            textBoxHourly = new TextBox();
            textBoxPieceWork = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(10, 189, 188);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(42, 227);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 46);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(332, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 46);
            label1.TabIndex = 5;
            label1.Text = "Проект";
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxProjectName.Location = new Point(42, 27);
            textBoxProjectName.Margin = new Padding(4, 3, 4, 3);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.PlaceholderText = "Название проекта";
            textBoxProjectName.Size = new Size(455, 33);
            textBoxProjectName.TabIndex = 0;
            // 
            // textBoxHourly
            // 
            textBoxHourly.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHourly.Location = new Point(42, 94);
            textBoxHourly.Margin = new Padding(4, 3, 4, 3);
            textBoxHourly.Name = "textBoxHourly";
            textBoxHourly.PlaceholderText = "Почасовая оплата";
            textBoxHourly.Size = new Size(455, 33);
            textBoxHourly.TabIndex = 1;
            // 
            // textBoxPieceWork
            // 
            textBoxPieceWork.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPieceWork.Location = new Point(42, 158);
            textBoxPieceWork.Margin = new Padding(4, 3, 4, 3);
            textBoxPieceWork.Name = "textBoxPieceWork";
            textBoxPieceWork.PlaceholderText = "Сдельная оплата";
            textBoxPieceWork.Size = new Size(455, 33);
            textBoxPieceWork.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 95, 106);
            panel1.Controls.Add(textBoxProjectName);
            panel1.Controls.Add(textBoxHourly);
            panel1.Controls.Add(textBoxPieceWork);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(123, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 297);
            panel1.TabIndex = 9;
            // 
            // AddFormProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 75, 86);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 455);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFormProjects";
            Text = "Добавить проект";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private TextBox textBoxProjectName;
        private TextBox textBoxHourly;
        private TextBox textBoxPieceWork;
        private Panel panel1;
    }
}