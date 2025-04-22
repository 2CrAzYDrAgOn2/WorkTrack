namespace WorkTrack
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelRegister = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonEnter = new Button();
            labelAuth = new Label();
            buttonShow = new Button();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.BackColor = Color.Transparent;
            labelRegister.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelRegister.ForeColor = Color.White;
            labelRegister.Location = new Point(169, 25);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(317, 62);
            labelRegister.TabIndex = 6;
            labelRegister.Text = "Авторизация";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(56, 56, 56);
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            textBoxLogin.Location = new Point(85, 111);
            textBoxLogin.MaxLength = 50;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(483, 54);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(56, 56, 56);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            textBoxPassword.Location = new Point(85, 180);
            textBoxPassword.MaxLength = 50;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(483, 54);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(10, 189, 188);
            buttonEnter.FlatAppearance.BorderSize = 0;
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEnter.ForeColor = Color.White;
            buttonEnter.Location = new Point(459, 16);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(170, 65);
            buttonEnter.TabIndex = 2;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += ButtonEnter_Click;
            // 
            // labelAuth
            // 
            labelAuth.AutoSize = true;
            labelAuth.BackColor = Color.Transparent;
            labelAuth.Font = new Font("Segoe UI", 30F, FontStyle.Underline);
            labelAuth.ForeColor = Color.FromArgb(10, 189, 188);
            labelAuth.Location = new Point(205, 412);
            labelAuth.Name = "labelAuth";
            labelAuth.Size = new Size(249, 54);
            labelAuth.TabIndex = 3;
            labelAuth.Text = "Регистрация";
            labelAuth.Click += LabelAuth_Click;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = Color.Transparent;
            buttonShow.BackgroundImage = (Image)resources.GetObject("buttonShow.BackgroundImage");
            buttonShow.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShow.FlatAppearance.BorderSize = 0;
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Location = new Point(574, 180);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(55, 54);
            buttonShow.TabIndex = 5;
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += ButtonShow_Click;
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
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBoxLogin);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(labelAuth);
            panel2.Controls.Add(buttonShow);
            panel2.Controls.Add(labelRegister);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(70, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 504);
            panel2.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 76, 78);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 559);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelRegister;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonEnter;
        private Label labelAuth;
        private Button buttonShow;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel panel2;
    }
}
