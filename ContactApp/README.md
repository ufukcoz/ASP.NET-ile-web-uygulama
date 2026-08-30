# ContactApp

ASP.NET Core MVC mimarisi kullanılarak geliştirilmiş, temel CRUD (Oluşturma, Okuma, Güncelleme, Silme) işlemlerini barındıran kişi yönetimi (rehber) uygulamasıdır. Proje, veritabanı kurulumu gerektirmeden doğrudan çalışabilmesi için `In-Memory Repository` deseni kullanılarak yapılandırılmıştır.

**Temel Özellikler**
* **CRUD Operasyonları:** Yeni kayıt ekleme, listeleme, detay görüntüleme, güncelleme ve silme.
* **Arama ve Filtreleme:** İsim ve soyisime göre anlık arama (Search) işlevi.
* **Validasyon Mekanizması:** Eksik veya hatalı veri girişini engelleyen Client-Side (jQuery) ve Server-Side doğrulama kontrolleri.
* **Bağımlılık Enjeksiyonu (DI):** `IContactRepository` arayüzü üzerinden In-Memory servisi entegrasyonu.
* **Arayüz:** Bootstrap kullanılarak tasarlanmış esnek (responsive) formlar ve veri tabloları.

**Kullanılan Teknolojiler**
* C# & .NET Core
* ASP.NET Core MVC
* LINQ (Veri manipülasyonu ve sıralama için)
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
Projeyi bilgisayarınızda derleyip çalıştırmak için terminal üzerinden şu komutları sırasıyla uygulayabilirsiniz:

```bash
# Repoyu bilgisayarınıza klonlayın
git clone [https://github.com/ufukcoz/ContactApp.git](https://github.com/ufukcoz/ContactApp.git)

# Proje ana dizinine girin
cd ContactApp

# Projeyi derleyip çalıştırın
dotnet run
