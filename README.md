# ITRiskManager

ISO 27005 risk metodolojisine dayalı IT Risk ve Varlık Envanteri Yönetim Sistemi.

## Proje Hakkında

Bu uygulama, bilgi güvenliği kapsamında kurumsal IT varlıklarının envanterini tutmak ve bu varlıklara yönelik riskleri ISO 27005 metodolojisiyle değerlendirmek amacıyla geliştirilmiştir.

## Özellikler

- Bilgi varlığı ekleme ve listeleme (sunucu, veritabanı, uygulama vb.)
- Tehdit ve zafiyet seçimi
- Risk skoru hesaplama (Olasılık x Etki)
- Risk seviyesi belirleme (Kritik / Yüksek / Orta / Düşük)
- Excel formatında risk raporu oluşturma

## Kullanılan Teknolojiler

- C# / WinForms
- SQL Server (LocalDB)
- EPPlus (Excel export)
- ISO 27005 Risk Metodolojisi

## Kurulum

### 1. Repoyu İndir
```
git clone https://github.com/merc4nksu/ITRiskManager.git
```

### 2. Veritabanını Oluştur
- SQL Server Management Studio'yu aç
- `database.sql` dosyasını aç ve çalıştır
- Tablolar otomatik oluşacaktır

### 3. Bağlantıyı Güncelle
`Data/DatabaseHelper.cs` dosyasını aç:
```csharp
"Server=(localdb)\\MSSQLLocalDB;Database=YOUR_DB;Integrated Security=True;"
```
`YOUR_DB` kısmını kendi veritabanı adınla değiştir.

### 4. Projeyi Çalıştır
- `ITRiskManager.sln` dosyasına çift tıkla
- Visual Studio açılır
- F5 ile çalıştır

## İletişim

GitHub: [@merc4nksu](https://github.com/merc4nksu)
