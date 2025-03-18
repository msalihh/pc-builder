using DevExpress.XtraEditors;
using Neo4j.Driver;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace newbuild
{
    public partial class PcBuild : DevExpress.XtraEditors.XtraForm
    {
        private readonly ComponentManager _componentManager;
        private readonly BasketManager _basketManager;
        private readonly MongoDbService _mongoDbService;
        private string? _selectedCpuSocket;
        private string? _selectedMotherboardRamType;
        private string? _selectedRamType;
        private string? _selectedGpuName;
        private string currentUser;

        public PcBuild(string username)
        {
            InitializeComponent();
            currentUser = username;

            var driver = GraphDatabase.Driver(
                "bolt://localhost:7687",
                AuthTokens.Basic("neo4j", "123456789")
            );

            _componentManager = new ComponentManager(driver);
            _basketManager = new BasketManager();
            _mongoDbService = new MongoDbService("mongodb://localhost:27017", "pcbuilder");
        }

        private async void PcBuild_Load(object sender, EventArgs e)
        {
            // GridView configuration
            foreach (var gridView in new[] { gridView2, gridView3, gridView4, gridView5, gridView7 })
            {
                gridView.OptionsView.ShowIndicator = true;
                gridView.IndicatorWidth = 40;
                gridView.CustomDrawRowIndicator += GridView_CustomDrawRowIndicator;
            }

            // Load all components initially
            await LoadAllComponents();
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = listBoxBasket.Items
                .OfType<string>()
                .Sum(item =>
                {
                    int priceStartIndex = item.LastIndexOf("$") + 1;
                    return decimal.TryParse(item.Substring(priceStartIndex), out decimal price) ? price : 0;
                });

            totalTextEdit.Text = $"${totalPrice:F2}";
        }

        private void GridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private async Task LoadAllComponents()
        {
            gridControl2.DataSource = await _componentManager.GetCpuDataAsync();
            gridControl3.DataSource = await _componentManager.GetAllMotherboardDataAsync();
            gridControl4.DataSource = await _componentManager.GetAllRamDataAsync();
            gridControl5.DataSource = await _componentManager.GetAllGpuDataAsync();
            gridControl7.DataSource = await _componentManager.GetAllSsdDataAsync();
            gridControl6.DataSource = await _componentManager.GetMonitorDataAsync();
        }

        // CPU selection and filtering motherboards
        private async void addBtnCpu_Click(object sender, EventArgs e)
        {
            var selectedRowHandle = gridView2.FocusedRowHandle;
            if (selectedRowHandle < 0)
            {
                MessageBox.Show("Bir işlemci seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cpuSocket = gridView2.GetRowCellValue(selectedRowHandle, "Socket")?.ToString();
            string cpuName = gridView2.GetRowCellValue(selectedRowHandle, "Name")?.ToString();
            string cpuPrice = gridView2.GetRowCellValue(selectedRowHandle, "Price")?.ToString();

            listBoxBasket.Items.Add($"CPU: {cpuName} - ${cpuPrice}");
            UpdateTotalPrice();

            await LoadMotherboardData(cpuSocket);
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
        }

        private async Task LoadMotherboardData(string cpuSocket)
        {
            var motherboardData = await _componentManager.FilterMotherboardsByCpuAsync(cpuSocket);

            if (!motherboardData.Any())
            {
                MessageBox.Show("Uygun bir anakart bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gridControl3.DataSource = motherboardData;
        }

        // Motherboard selection and filtering RAM
        private async void AddMotherBoard_Click(object sender, EventArgs e)
        {
            var selectedRowHandle = gridView3.FocusedRowHandle;
            if (selectedRowHandle < 0)
            {
                MessageBox.Show("Bir anakart seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string motherboardName = gridView3.GetRowCellValue(selectedRowHandle, "Name")?.ToString();
            string motherboardRamType = gridView3.GetRowCellValue(selectedRowHandle, "RamType")?.ToString();
            string motherboardPrice = gridView3.GetRowCellValue(selectedRowHandle, "Price")?.ToString();

            listBoxBasket.Items.Add($"Motherboard: {motherboardName} - ${motherboardPrice}");
            UpdateTotalPrice();

            string cpuSocket = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Socket")?.ToString();
            await FilterRamData(cpuSocket, motherboardRamType);
            xtraTabControl1.SelectedTabPage = xtraTabPage3;
        }

        private async Task FilterRamData(string cpuSocket, string motherboardRamType)
        {
            var ramData = await _componentManager.FilterRamsByCpuAndMotherboardAsync(cpuSocket, motherboardRamType);

            if (!ramData.Any())
            {
                MessageBox.Show("Uygun bir RAM bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gridControl4.DataSource = ramData;
        }

        private async void addButtonRam_Click_1(object sender, EventArgs e)
        {
            var selectedRowHandle = gridView4.FocusedRowHandle;
            if (selectedRowHandle < 0)
            {
                MessageBox.Show("Bir RAM seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ramName = gridView4.GetRowCellValue(selectedRowHandle, "Name")?.ToString();
            string ramPrice = gridView4.GetRowCellValue(selectedRowHandle, "Price")?.ToString();

            listBoxBasket.Items.Add($"RAM: {ramName} - ${ramPrice}");
            UpdateTotalPrice();

            string cpuSocket = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Socket")?.ToString();
            string motherboardRamType = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "RamType")?.ToString();
            await LoadGpuData(cpuSocket, motherboardRamType, motherboardRamType);
            xtraTabControl1.SelectedTabPage = xtraTabPage4;
        }

        private async Task LoadGpuData(string cpuSocket, string motherboardRamType, string ramType)
        {
            var gpuData = await _componentManager.FilterGpusByCpuMotherboardAndRamAsync(cpuSocket, motherboardRamType, ramType);

            if (!gpuData.Any())
            {
                MessageBox.Show("Uygun bir GPU bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gridControl5.DataSource = gpuData;
        }

        private async void addButtonGpu_Click(object sender, EventArgs e)
        {
            var selectedRowHandle = gridView5.FocusedRowHandle;
            if (selectedRowHandle < 0)
            {
                MessageBox.Show("Bir GPU seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gpuName = gridView5.GetRowCellValue(selectedRowHandle, "Name")?.ToString();
            string gpuPrice = gridView5.GetRowCellValue(selectedRowHandle, "Price")?.ToString();

            listBoxBasket.Items.Add($"GPU: {gpuName} - ${gpuPrice}");
            UpdateTotalPrice();

            string cpuSocket = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Socket")?.ToString();
            string motherboardRamType = gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "RamType")?.ToString();
            await FilterSsdData(cpuSocket, motherboardRamType, motherboardRamType, gpuName);
            xtraTabControl1.SelectedTabPage = xtraTabPage5;
        }

        private async Task FilterSsdData(string cpuSocket, string motherboardRamType, string ramType, string gpuName)
        {
            var ssdData = await _componentManager.FilterSsdsByAllComponentsAsync(cpuSocket, motherboardRamType, ramType);

            if (!ssdData.Any())
            {
                MessageBox.Show("Uygun bir SSD bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            gridControl7.DataSource = ssdData;
        }

        private void addButtonSsd_Click(object sender, EventArgs e)
        {
            var selectedRowHandle = gridView7.FocusedRowHandle;
            if (selectedRowHandle < 0)
            {
                MessageBox.Show("Bir SSD seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ssdName = gridView7.GetRowCellValue(selectedRowHandle, "Name")?.ToString();
            string ssdPrice = gridView7.GetRowCellValue(selectedRowHandle, "Price")?.ToString();

            listBoxBasket.Items.Add($"SSD: {ssdName} - ${ssdPrice}");
            UpdateTotalPrice();
            xtraTabControl1.SelectedTabPage = xtraTabPage6;
        }

        private void MonitorAddButton_ButtonClick(object sender, EventArgs e)
        {
            // Sepette zaten monitör olup olmadığını kontrol et
            if (listBoxBasket.Items.OfType<string>().Any(item => item.StartsWith("Monitor:")))
            {
                MessageBox.Show("Sepete sadece bir monitör ekleyebilirsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRowHandle = gridView6.FocusedRowHandle; // Monitörlerin bulunduğu GridView
            if (selectedRowHandle < 0)
            {
                MessageBox.Show("Bir monitör seçmediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen monitör bilgilerini al
            string monitorName = gridView6.GetRowCellValue(selectedRowHandle, "Name")?.ToString();
            string monitorPrice = gridView6.GetRowCellValue(selectedRowHandle, "Price")?.ToString();

            // Sepete ekle
            listBoxBasket.Items.Add($"Monitor: {monitorName} - ${monitorPrice}");

            // Toplam fiyatı güncelle
            UpdateTotalPrice();
            MessageBox.Show("Tüm bileşenler başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void basketClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Sepeti temizle
                _basketManager.ClearBasket();
                listBoxBasket.Items.Clear();

                // GridView seçimlerini temizle
                gridView2.ClearSelection();
                gridView3.ClearSelection();
                gridView4.ClearSelection();
                gridView5.ClearSelection();
                gridView7.ClearSelection();

                // Tüm filtreleri sıfırla (Opsiyonel, filtreyi bir yerde saklıyorsanız oradan temizleyin)
                gridView2.ActiveFilter.Clear();
                gridView3.ActiveFilter.Clear();
                gridView4.ActiveFilter.Clear();
                gridView5.ActiveFilter.Clear();
                gridView7.ActiveFilter.Clear();

                // Tüm bileşenleri yeniden yükle
                await LoadAllComponents();

                // İlk sekmeyi seç
                xtraTabControl1.SelectedTabPage = xtraTabPage1;

                // İşlem başarıyla tamamlandı
                MessageBox.Show("Sepet temizlendi ve tüm parçalar yeniden yüklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void SaveSystemToMongoDb(string currentUser)
        {
            try
            {
                // Sepetteki tüm parçaları al
                var selectedComponents = listBoxBasket.Items.OfType<string>().ToList();

                if (selectedComponents.Count == 0)
                {
                    MessageBox.Show("Sepet boş, lütfen bir sistem seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kullanıcıya özel sistem oluştur
                var system = new SavedSystem
                {
                    UserName = currentUser, // Giriş yapan kullanıcının adı
                    SavedAt = DateTime.Now, // Sistem kaydedildiği tarih
                    Components = selectedComponents // Sepetteki bileşenler
                };

                // MongoDB'ye kaydet
                await _mongoDbService.SaveSystemAsync(system);

                MessageBox.Show("Sistem başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveSystemToMongoDb(currentUser);
        }
        private void loadSaveButton_Click(object sender, EventArgs e)
        {
            // LoadSystemsForm formunu aç
            var loadForm = new LoadSystemsForm(currentUser); // Kullanıcı adıyla formu başlat
            loadForm.ShowDialog(); // Formu modal olarak aç
        }

    }
}
