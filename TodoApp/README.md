# TodoApp

ASP.NET Core Razor Pages mimarisi kullanılarak geliştirilmiş, temel görev yönetim işlemlerini barındıran bir yapılacaklar listesi (to-do) uygulamasıdır. Proje, Dependency Injection (DI) altyapısı sayesinde **In-Memory Repository** ve **Entity Framework Core (SQL Server)** arasında duruma göre dinamik veritabanı seçimi yapabilecek esnek bir mimariyle yapılandırılmıştır.

## Temel Özellikler
* **Dinamik Veri Yönetimi:** `ITodoStore` arayüzü üzerinden In-Memory veya EF Core (SQL Server) servisleri arasında kolayca geçiş yapabilme entegrasyonu.
* **CRUD Operasyonları:** Yeni görev oluşturma, mevcut görevleri listeleme ve gereksizleri silme.
* **Öncelik Belirleme:** Görevlere özel öncelik seviyeleri (Düşük, Orta, Yüksek) atama.
* **Durum ve Tarih Takibi:** Bitiş tarihi (Due Date) belirleme ve tamamlanan görevleri işaretleme.
* **Esnek Arayüz:** Bootstrap kullanılarak tasarlanmış, her cihaza uyumlu (responsive) formlar ve düzenli liste yapıları.

## Kullanılan Teknolojiler
* C# & .NET Core
* ASP.NET Core Razor Pages
* Entity Framework Core & SQL Server
* LINQ (Veri manipülasyonu ve filtreleme için)
* HTML, CSS, Bootstrap

## Veri Modeli (Todo)
* **Id:** Benzersiz Kimlik
* **Title:** Görev Başlığı
* **Description:** Görev detayları ve açıklaması
* **Priority:** Görev Önceliği
* **DueDate:** Hedeflenen Bitiş Tarihi
* **IsDone:** Tamamlanma Durumu (Evet/Hayır)

## Yerel Kurulum (Local Setup)

Projeyi bilgisayarınızda derleyip çalıştırmak için terminal üzerinden şu komutları sırasıyla uygulayabilirsiniz:

```bash
# Repoyu bilgisayarınıza klonlayın
git clone [https://github.com/ufukcoz/ASP.NET-ile-web-uygulama.git](https://github.com/ufukcoz/ASP.NET-ile-web-uygulama.git)

# Projenin bulunduğu klasöre girin
cd ASP.NET-ile-web-uygulama/TodoApp

# Projeyi derleyip çalıştırın
dotnet run