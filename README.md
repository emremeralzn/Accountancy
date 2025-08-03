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



# Accounting Automation System (WinForms + Web API)

This project is a **Windows Forms (WinForms)** desktop application communicating with a **Web API** powered by Entity Framework Core. It performs basic accounting operations like product management, invoice processing, and invoice detail management.

## 🔧 Technologies

- ✅ **.NET 8 Web API**
- ✅ **Entity Framework Core**
- ✅ **Layered Architecture**
- ✅ **RestSharp** for API integration (on WinForms side)
- ✅ **WinForms (UI Layer)**
- ✅ **SQL Server** (EF Core with Code First Migration)
- ✅ **Data exchange in JSON format**

---

## 📁 Project Structure

### 📦 `Muhasebe.API`
This is the Web API project consisting of the following layers:

#### `Entities/`
Contains the entity classes:
- `Product.cs`
- `Fatura.cs`
- `FaturaDetay.cs`

#### `Data/`
Contains the EF Core `DbContext` and Migrations:
- `MuhasebeDbContext.cs`

#### `Controllers/`
- `ProductController.cs`
- `FaturaController.cs`
- `FaturaDetayController.cs`

---

### 📦 `Muhasebe.UI`
This is the WinForms-based client application. It uses **RestSharp** to send HTTP requests to the REST API.

#### `Forms/`
Forms displayed to the user:
- `FrmUrunler`
- `FrmFaturalar`
- `FrmFaturaDetay`

#### `Models/`
DTO/ViewModels used for API data exchange:
- `Product`
- `FaturaViewModel`
- `FaturaDetayViewModel`

---

## 🧩 Layer Communication Diagram

```
Muhasebe.UI (WinForms)
     |
     |--- HTTP requests via RestSharp
     ↓
Muhasebe.API (Web API)
     ↓
EF Core + SQL Server (Database)
```

---

## 🛠️ Setup & Run

### 1. Run Web API:

```bash
cd Muhasebe.API
dotnet ef database update
dotnet run
```

- Example port: `https://localhost:7282`
- Can be tested using Swagger: `https://localhost:7282/swagger`

### 2. Run WinForms Application:

```bash
cd Muhasebe.UI
dotnet build
dotnet run
```

> 📌 **Note**: The WinForms app connects to `https://localhost:7282/` by default. If your API runs on a different port, make sure to update the `RestClient` URLs accordingly.

---

## 💡 Features

- [x] Add / List / Update / Delete Products
- [x] Create / List Invoices
- [x] Add Invoice Details
- [x] Automatic Total Calculation (Quantity × Unit Price)
- [x] Fetch and update data via API
- [x] Error handling and user notifications

---

## 🚀 Development Steps

- [x] DB and tables created using EF Core.
- [x] CRUD controllers implemented.
- [x] HTTP communication set up with RestSharp.
- [x] List and data entry forms created.
- [x] Validations and message boxes added.

---

## 🤝 Contribution

This is a personal learning and demo project. Feel free to explore the code structure and use it to build similar layered architectures in your own projects.

---

## 🧠 Notes

- Controls like `.DataSource`, `DisplayMember`, and `ValueMember` are important for binding.
- `async/await` ensures non-blocking API calls for a smoother UI experience.
- In the Invoice Detail form, the `Total` field is a calculated, read-only property.

---

## 🧾 License

This is a personal project shared under the MIT License. You are free to use and modify it.

