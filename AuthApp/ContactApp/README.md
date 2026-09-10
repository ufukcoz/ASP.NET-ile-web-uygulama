# ContactApp - ASP.NET Core MVC Authentication & Contact Management

Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş; kullanıcı kimlik doğrulama (Authentication), yetkilendirme (Authorization) ve kapsamlı iletişim/rehber yönetimi özelliklerini içeren bir web uygulamasıdır.

## 🚀 Özellikler

* **Kullanıcı İşlemleri:** Güvenli kayıt olma (Register), giriş yapma (Login) ve çıkış yapma (Logout) mekanizmaları (`ASP.NET Core Identity`).
* **Veritabanı Yönetimi:** Entity Framework Core ve Code-First yaklaşımı ile otomatik migration ve veri tabanı yönetimi.
* **Rol ve Yetkilendirme:** Kullanıcı rolleri ve güvenli sayfa yönlendirmeleri.
* **Veritabanı Tohumlama (DbSeeder):** Uygulama ilk ayağa kalktığında otomatik olarak gerekli başlangıç verilerinin ve rollerin eklenmesi.
* **Modern Arayüz:** Bootstrap destekli modern, duyarlı (responsive) ve kullanıcı dostu form tasarımları.

## 🛠️ Kullanılan Teknolojiler

* **Framework:** .NET Core (ASP.NET Core MVC)
* **Kütüphane/ORM:** Entity Framework Core
* **Kimlik Doğrulama:** ASP.NET Core Identity
* **Veritabanı:** MySQL / PostgreSQL
* **Önyüz (Frontend):** HTML5, CSS3, Bootstrap

## 📂 Proje Mimarisi

```text
ContactApp/
│
├── Controllers/         # MVC Controller sınıfları (Account, Home, vb.)
├── Models/              # Veritabanı modelleri ve ViewModel sınıfları
├── Data/                # DbContext ve Veritabanı Seed sınıfları
├── Views/               # Razor görünüm dosyaları (.cshtml)
├── Program.cs           # Servis yapılandırmaları ve uygulama pipeline ayarları
└── appsettings.json     # Veritabanı ve uygulama ayarları

⚙️ Kurulum ve Çalıştırma
Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

Repoyu Klonlayın:

Bash
git clone [https://github.com/ufukcoz/ASP.NET-ile-web-uygulama.git](https://github.com/ufukcoz/ASP.NET-ile-web-uygulama.git)
Proje Klasörüne Gidin:

Bash
cd ASP.NET-ile-web-uygulama/AuthApp/ContactApp
Veritabanı Bağlantısını Ayarlayın:
appsettings.json dosyasını açarak kendi yerel veritabanı bağlantı cümlenizi (ConnectionStrings) güncelleyin.

Migration ve Güncellemeleri Uygulayın:
Terminal üzerinden veritabanını oluşturmak için şu komutu çalıştırın:

Bash
dotnet ef database update
Projeyi Çalıştırın:

Bash
dotnet run
