namespace newbuild
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            ExitButton = new DevExpress.XtraEditors.SimpleButton();
            signupButton = new DevExpress.XtraEditors.SimpleButton();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Appearance.BackColor = Color.Crimson;
            ExitButton.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ExitButton.Appearance.Options.UseBackColor = true;
            ExitButton.Appearance.Options.UseFont = true;
            ExitButton.AppearanceHovered.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ExitButton.AppearanceHovered.Options.UseFont = true;
            ExitButton.Location = new Point(253, 204);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 30);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "Exit";
            ExitButton.Click += ExitButton_Click;
            // 
            // signupButton
            // 
            signupButton.Appearance.BackColor = Color.DodgerBlue;
            signupButton.Appearance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            signupButton.Appearance.Options.UseBackColor = true;
            signupButton.Appearance.Options.UseFont = true;
            signupButton.AppearanceHovered.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            signupButton.AppearanceHovered.Options.UseFont = true;
            signupButton.Location = new Point(394, 204);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(100, 30);
            signupButton.TabIndex = 10;
            signupButton.Text = "Sign Up";
            signupButton.Click += signupButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            passwordLabel.Location = new Point(181, 139);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 17);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            usernameLabel.Location = new Point(181, 78);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(73, 17);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(253, 135);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(230, 21);
            passwordTextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(253, 74);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(230, 21);
            usernameTextBox.TabIndex = 6;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 368);
            Controls.Add(ExitButton);
            Controls.Add(signupButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            IconOptions.Icon = (Icon)resources.GetObject("SignUpForm.IconOptions.Icon");
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ExitButton;
        private DevExpress.XtraEditors.SimpleButton signupButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
    }
}