# Muhasebe Otomasyon Sistemi (WinForms + Web API)

Bu proje, Entity Framework Core destekli bir **Web API** ile iletişim kuran bir **Windows Forms (WinForms)** masaüstü uygulamasıdır. Uygulama, ürün yönetimi, fatura işlemleri ve fatura detayları gibi temel muhasebe fonksiyonlarını gerçekleştirmek üzere geliştirilmiştir.

## 🔧 Teknolojiler

- ✅ **.NET 8 Web API**
- ✅ **Entity Framework Core**
- ✅ **Katmanlı Mimari (Layered Architecture)**
- ✅ **RestSharp** ile API entegrasyonu (WinForms tarafında)
- ✅ **WinForms (UI Katmanı)**
- ✅ **SQL Server** (EF Core ile Code First Migration)
- ✅ **JSON formatında veri alışverişi**

---

## 📁 Proje Yapısı

### 📦 `Muhasebe.API`
Web API projesidir. Aşağıdaki katmanlardan oluşur:

#### `Entities/`
Entity sınıflarını içerir:
- `Product.cs`
- `Fatura.cs`
- `FaturaDetay.cs`

#### `Data/`
EF Core `DbContext` sınıfı ve Migrations burada yer alır:
- `MuhasebeDbContext.cs`

#### `Controllers/`
- `ProductController.cs`
- `FaturaController.cs`
- `FaturaDetayController.cs`

---

### 📦 `Muhasebe.UI`
WinForms tabanlı istemci uygulamadır. REST API'ye HTTP istekleri atmak için **RestSharp** kütüphanesi kullanılmıştır.

#### `Forms/`
Kullanıcıya sunulan formlar:
- `FrmUrunler`
- `FrmFaturalar`
- `FrmFaturaDetay`

#### `Models/`
API'den gelen/verilen veri modelleri (DTO/ViewModel):
- `Product`
- `FaturaViewModel`
- `FaturaDetayViewModel`

---

## 🧩 Katmanlar Arası İletişim

```
Muhasebe.UI (WinForms)
     |
     |--- RestSharp üzerinden HTTP istekleri
     ↓
Muhasebe.API (Web API)
     ↓
EF Core + SQL Server (Veri Tabanı)
```

---

## 🛠️ Kurulum ve Çalıştırma

### 1. Web API Projesi:

```bash
cd Muhasebe.API
dotnet ef database update
dotnet run
```

- Port örneği: `https://localhost:7282`
- Swagger ile test edilebilir: `https://localhost:7282/swagger`

### 2. WinForms Uygulaması:

```bash
cd Muhasebe.UI
dotnet build
dotnet run
```

> 📌 **Dikkat**: WinForms uygulaması, `https://localhost:7282/` adresindeki API’ye bağlanır. Eğer API farklı bir portta çalışıyorsa, `RestClient` URL’lerini güncellemeyi unutmayın.

---

## 💡 Özellikler

- [x] Ürün Ekle / Listele / Güncelle / Sil
- [x] Fatura Oluştur / Listele
- [x] Fatura Detaylarını Ekleme
- [x] Tutar Otomatik Hesaplama (Miktar × Birim Fiyat)
- [x] API'den veri çekme ve güncelleme işlemleri
- [x] Hata kontrolü ve kullanıcı geri bildirimleri

---

## 🚀 Geliştirme Aşamaları

- [x] EF Core ile DB ve tablolar oluşturuldu.
- [x] CRUD controller'lar yazıldı.
- [x] UI'da RestSharp ile HTTP bağlantılar kuruldu.
- [x] Listeleme ve veri girişi formları tamamlandı.
- [x] Validasyonlar ve mesaj kutuları eklendi.

---

## 🤝 Katkıda Bulun

Bu proje bireysel bir öğrenme ve uygulama projesidir. Kod yapısı üzerinden fikir yürütmek ve benzer mimariler kurmak isteyen herkes özgürce kullanabilir.

---

## 🧠 Notlar

- `.DataSource`, `DisplayMember`, `ValueMember` gibi kontroller **Binding** açısından önemlidir.
- `async/await` pattern'i sayesinde API çağrıları kullanıcı arayüzünü kilitlemez.
- `FaturaDetay` ekleme ekranında `Tutar` alanı hesaplanan bir property'dir (`readonly`).

---

## 🧾 Lisans

Bu proje bireysel çalışma olarak MIT lisansı ile paylaşılmıştır. Dilediğiniz gibi kullanabilirsiniz.
