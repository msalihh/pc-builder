using System;
using System.Windows.Forms;

namespace newbuild
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var mongoService = new MongoDbService("mongodb://localhost:27017", "test");

                // Kullanıcı doğrulama
                var user = await mongoService.ValidateUserAsync(username, password);

                if (user == null)
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Giriş başarılı
                MessageBox.Show($"Hoş geldiniz, {username}!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // PCBuild formuna geçiş
                var pcbuildForm = new pcbuild(username);
                pcbuildForm.Show();
                this.Hide(); // Giriş ekranını gizle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // SignUpForm'a geçiş
            var signupForm = new SignUpForm();
            signupForm.ShowDialog(); // Yeni formu aç
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
