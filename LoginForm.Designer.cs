namespace newbuild
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            signupButton = new DevExpress.XtraEditors.SimpleButton();
            loginButton = new DevExpress.XtraEditors.SimpleButton();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            ExitButton = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // signupButton
            // 
            signupButton.Appearance.BackColor = Color.DodgerBlue;
            signupButton.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            signupButton.Appearance.Options.UseBackColor = true;
            signupButton.Appearance.Options.UseFont = true;
            signupButton.AppearanceHovered.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            signupButton.AppearanceHovered.Options.UseFont = true;
            signupButton.Location = new Point(338, 243);
            signupButton.Margin = new Padding(4, 3, 4, 3);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(100, 30);
            signupButton.TabIndex = 17;
            signupButton.Text = "Sign Up";
            signupButton.Click += signupButton_Click;
            // 
            // loginButton
            // 
            loginButton.Appearance.BackColor = Color.DodgerBlue;
            loginButton.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            loginButton.Appearance.Options.UseBackColor = true;
            loginButton.Appearance.Options.UseFont = true;
            loginButton.AppearanceHovered.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            loginButton.AppearanceHovered.Options.UseFont = true;
            loginButton.Location = new Point(465, 243);
            loginButton.Margin = new Padding(4, 3, 4, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 30);
            loginButton.TabIndex = 16;
            loginButton.Text = "Login";
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passwordLabel.Location = new Point(217, 168);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 17);
            passwordLabel.TabIndex = 15;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            usernameLabel.Location = new Point(217, 98);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(73, 17);
            usernameLabel.TabIndex = 14;
            usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(301, 164);
            passwordTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(268, 23);
            passwordTextBox.TabIndex = 13;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(301, 93);
            usernameTextBox.Margin = new Padding(4, 3, 4, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(268, 23);
            usernameTextBox.TabIndex = 12;
            // 
            // ExitButton
            // 
            ExitButton.Appearance.BackColor = Color.Crimson;
            ExitButton.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ExitButton.Appearance.Options.UseBackColor = true;
            ExitButton.Appearance.Options.UseFont = true;
            ExitButton.AppearanceHovered.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ExitButton.AppearanceHovered.Options.UseFont = true;
            ExitButton.Location = new Point(205, 243);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 30);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "Exit";
            ExitButton.Click += ExitButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 361);
            Controls.Add(ExitButton);
            Controls.Add(signupButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton signupButton;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private DevExpress.XtraEditors.SimpleButton ExitButton;
    }
}