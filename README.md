# PC Builder Uygulaması

Bu uygulama, kullanıcıların uyumlu bilgisayar parçalarını seçerek kişiselleştirilmiş bir bilgisayar sistemi oluşturmasına olanak sağlar. Neo4j graf veritabanı kullanılarak parçalar arasındaki uyumluluk ilişkileri yönetilir.

## Özellikler

- **Akıllı Parça Seçimi**: Neo4j graf veritabanı kullanılarak parçalar arasındaki uyumluluk otomatik olarak kontrol edilir
- **Bileşen Filtreleme**: Seçilen parçalara göre uyumlu diğer parçalar otomatik filtrelenir
- **Parça Kategorileri**:
  - CPU (İşlemci)
  - Anakart
  - RAM
  - GPU (Ekran Kartı)
  - SSD
  - Monitör

## Teknolojiler

- **.NET 8.0**
- **DevExpress**: Kullanıcı arayüzü bileşenleri için
- **Neo4j**: Parça uyumluluk ilişkilerinin yönetimi için
- **MongoDB**: Kullanıcı ve sistem konfigürasyonlarının saklanması için

## Kurulum

1. Neo4j veritabanını kurun ve çalıştırın
2. MongoDB'yi kurun ve çalıştırın
3. Projeyi klonlayın
4. Gerekli NuGet paketlerini yükleyin:
   ```bash
   dotnet restore
   ```
5. Veritabanı bağlantı ayarlarını yapılandırın
6. Uygulamayı başlatın

## Veritabanı Yapılandırması

### Neo4j Bağlantısı
```csharp
bolt://localhost:7687
Kullanıcı adı: neo4j
```

### MongoDB Bağlantısı
```csharp
mongodb://localhost:27017
Veritabanı: pcbuilder
```

## Kullanım

1. Uygulamayı başlatın
2. İşlemci (CPU) seçimiyle başlayın
3. Seçilen işlemciye uyumlu anakartlar otomatik olarak filtrelenir
4. Anakart seçiminden sonra uyumlu RAM'ler listelenir
5. Bu şekilde tüm parçaları uyumluluğa göre seçebilirsiniz
6. Seçilen parçalar sepete eklenir
7. Sistem konfigürasyonunu kaydedebilir veya daha sonra yükleyebilirsiniz

## Katkıda Bulunma

1. Bu depoyu fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/yeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/yeniOzellik`)
5. Pull Request oluşturun

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.
