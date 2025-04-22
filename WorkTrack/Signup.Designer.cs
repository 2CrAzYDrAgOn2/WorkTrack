namespace WorkTrack
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            buttonEnter = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            buttonShow = new Button();
            panel2 = new Panel();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(10, 189, 188);
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(459, 16);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(170, 65);
            buttonEnter.TabIndex = 2;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += ButtonEnter_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(56, 56, 56);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            textBoxPassword.Location = new Point(91, 180);
            textBoxPassword.MaxLength = 50;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(483, 54);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(56, 56, 56);
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            textBoxLogin.Location = new Point(91, 111);
            textBoxLogin.MaxLength = 50;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(483, 54);
            textBoxLogin.TabIndex = 0;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = Color.Transparent;
            buttonShow.BackgroundImage = Properties.Resources.ShowPassword1;
            buttonShow.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Location = new Point(580, 180);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(55, 54);
            buttonShow.TabIndex = 4;
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += ButtonShow_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 76, 78);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxLogin);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(buttonShow);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(70, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 504);
            panel2.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(87, 87, 87);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(87, 87, 87);
            button2.Location = new Point(30, 180);
            button2.Name = "button2";
            button2.Size = new Size(55, 54);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(183, 24);
            label1.Name = "label1";
            label1.Size = new Size(300, 62);
            label1.TabIndex = 6;
            label1.Text = "Регистрация";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(88, 88, 88);
            panel1.Controls.Add(buttonEnter);
            panel1.Location = new Point(0, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 100);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(87, 87, 87);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(87, 87, 87);
            button1.Location = new Point(30, 111);
            button1.Name = "button1";
            button1.Size = new Size(55, 54);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 559);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Signup";
            Text = "Signup";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEnter;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Button buttonShow;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel1;
    }
}