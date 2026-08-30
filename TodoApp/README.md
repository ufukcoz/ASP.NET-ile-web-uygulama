# TodoApp

ASP.NET Core Razor Pages mimarisi kullanılarak geliştirilmiş, temel görev yönetim işlemlerini barındıran yapılacaklar listesi (to-do) uygulamasıdır. Proje, veritabanı kurulumu gerektirmeden doğrudan çalışabilmesi için In-Memory Repository deseni kullanılarak yapılandırılmıştır.

## Temel Özellikler
* **CRUD Operasyonları:** Yeni görev oluşturma, listeleme ve gereksiz görevleri silme.
* **Öncelik Belirleme:** Görevlere özel öncelik seviyeleri (Düşük, Orta, Yüksek) atama.
* **Durum ve Tarih Takibi:** Bitiş tarihi (Due Date) belirleme ve tamamlanan görevleri işaretleme.
* **Bağımlılık Enjeksiyonu (DI):** `ITodoStore` arayüzü üzerinden In-Memory servisi entegrasyonu.
* **Arayüz:** Bootstrap kullanılarak tasarlanmış esnek (responsive) formlar ve düzenli liste yapıları.

## Kullanılan Teknolojiler
* C# & .NET Core
* ASP.NET Core Razor Pages
* LINQ (Veri manipülasyonu ve filtreleme için)
* HTML, CSS, Bootstrap

## Veri Modeli (Todo)
Uygulama içerisindeki her bir kayıt aşağıdaki özellikleri barındırır:
* **Id:** Benzersiz Kimlik
* **Title:** Görev Başlığı
* **Description:** Görev Açıklaması detayları
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
