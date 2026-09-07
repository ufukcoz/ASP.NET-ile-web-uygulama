# ContactApp

ASP.NET Core MVC mimarisi kullanılarak geliştirilmiş, Entity Framework Core ve SQLite veritabanı altyapısıyla çalışan kişi yönetimi (rehber) uygulamasıdır.

**Temel Özellikler**
* **CRUD Operasyonları:** Yeni kayıt ekleme, listeleme, detay görüntüleme, güncelleme ve silme.
* **Arama ve Filtreleme:** İsim ve soyisime göre anlık arama (Search) işlevi.
* **Kalıcı Veri Saklama:** Entity Framework Core Code-First yaklaşımı ile SQLite veritabanı entegrasyonu.
* **Otomatik Veritabanı Kurulumu:** Uygulama ilk çalıştığında Migration'ları otomatik uygular ve test verilerini (Seed Data) yükler.
* **Arayüz:** Bootstrap kullanılarak tasarlanmış esnek (responsive) formlar ve veri tabloları.

**Kullanılan Teknolojiler**
* C# & .NET Core (ASP.NET Core MVC)
* Entity Framework Core & SQLite
* LINQ (Veri manipülasyonu için)
* HTML, CSS, Bootstrap

**Veri Modeli (Contact)**
Uygulama içerisindeki her bir kayıt aşağıdaki özellikleri barındırır:
* `Id`: Benzersiz Kimlik
* `FirstName`: Ad
* `LastName`: Soyad
* `Email`: E-posta Adresi
* `Phone`: Telefon Numarası
* `Company`: Çalıştığı Şirket
* `Title`: Unvan/Pozisyon
* `Notes`: Kişiye Özel Notlar

**Yerel Kurulum (Local Setup)**
Projeyi bilgisayarınızda çalıştırdığınızda `App_Data` klasörü ve `contacts.db` dosyası otomatik olarak oluşturulacaktır:

```bash
# Proje ana dizinine girin
cd ContactApp

# Projeyi derleyip çalıştırın
dotnet run



