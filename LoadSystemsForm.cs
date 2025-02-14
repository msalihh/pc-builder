using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace newbuild
{
    public partial class LoadSystemsForm : Form
    {
        private string currentUser;

        public LoadSystemsForm(string username)
        {
            InitializeComponent();
            currentUser = username; // Giriş yapan kullanıcı adı
        }

        private async void LoadSavedSystems()
        {
            try
            {
                var mongoService = new MongoDbService("mongodb://localhost:27017", "test");

                // Kullanıcının kaydettiği sistemleri al
                var savedSystems = await mongoService.GetSavedSystemsAsync(currentUser);

                if (!savedSystems.Any())
                {
                    MessageBox.Show("Bu kullanıcı için kaydedilmiş sistem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Verileri GridControl için dönüştür
                var systemsToDisplay = savedSystems.Select(system =>
                {
                    // Components alanından her bileşeni çıkar
                    var cpu = system.Components.FirstOrDefault(c => c.StartsWith("CPU: "))?.Replace("CPU: ", "");
                    var motherboard = system.Components.FirstOrDefault(c => c.StartsWith("Motherboard: "))?.Replace("Motherboard: ", "");
                    var memory = system.Components.FirstOrDefault(c => c.StartsWith("RAM: "))?.Replace("RAM: ", "");
                    var gpu = system.Components.FirstOrDefault(c => c.StartsWith("GPU: "))?.Replace("GPU: ", "");
                    var ssd = system.Components.FirstOrDefault(c => c.StartsWith("SSD: "))?.Replace("SSD: ", "");
                    var monitor = system.Components.FirstOrDefault(c => c.StartsWith("Monitor: "))?.Replace("Monitor: ", "");
                   
                    // GridControl'e uygun format
                    return new
                    {
                        Cpu = cpu,
                        MotherBoard = motherboard,
                        Memory = memory,
                        Gpu = gpu,
                        Ssd = ssd,
                        Monitor = monitor,
                        DateTime = system.SavedAt.ToString("g"), // Tarihi güzel bir formatta göster
                        Price = CalculateTotalPrice(system.Components) // Toplam fiyatı hesapla
                    };
                }).ToList();

                // Verileri GridControl'e bağla
                gridControl2.DataSource = systemsToDisplay;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private decimal CalculateTotalPrice(List<string> components)
        {
            decimal totalPrice = 0;

            foreach (var component in components)
            {
                // Her bileşen fiyatı, bileşen adının sonunda olduğu varsayılır
                var priceStartIndex = component.LastIndexOf('$') + 1;
                if (priceStartIndex > 0 && decimal.TryParse(component.Substring(priceStartIndex).Replace(",", "."), out var price))
                {
                    totalPrice += price;
                }
            }

            return totalPrice;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // Sistemleri yükle
            LoadSavedSystems();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapat
        }

        private void gridControl2_Load(object sender, EventArgs e)
        {
            LoadSavedSystems();
        }
    }
}
