using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace newbuild
{
    public partial class SignUpForm : DevExpress.XtraEditors.XtraForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private async void signupButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim(); // Kullanıcı adı
            string password = passwordTextBox.Text.Trim(); // Şifre

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var mongoService = new MongoDbService("mongodb://localhost:27017", "test");

                // Kullanıcı adı kontrolü
                var existingUser = await mongoService.IsUsernameTakenAsync(username);
                if (existingUser)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Yeni kullanıcı kaydetme
                var newUser = new User
                {
                    Username = username,
                    Password = password
                };
                await mongoService.RegisterUserAsync(newUser);

                MessageBox.Show("Kayıt başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıt ekranını kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
