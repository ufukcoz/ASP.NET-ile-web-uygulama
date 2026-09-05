# News Web API

Bu proje, ASP.NET Core kullanılarak geliştirilmiş bir Haber (News) yönetim API'sidir. Projede **Repository Design Pattern** ve **Entity Framework Core (Code-First)** yaklaşımı kullanılarak katmanlı ve sürdürülebilir bir mimari hedeflenmiştir.

## 📂 Proje Yapısı ve Mimarisi

Proje içerisindeki klasör yapısı ve görevleri şu şekildedir:

* **`/Controllers`**: API uç noktalarının (endpoints) bulunduğu katmandır (`NewsArticlesController.cs`).
* **`/Models`**: Veritabanı tablolarına karşılık gelen varlık sınıflarını (entity) içerir (`NewsArticle.cs`).
* **`/Repositories`**: Veri erişim katmanıdır. Repository Pattern kullanılarak soyutlama yapılmıştır (`INewsRepository.cs`, `NewsRepository.cs`).
  * **`/Config`**: Entity Framework Core için model yapılandırmalarını (Fluent API) barındırır (`NewsArticleConfiguration.cs`).
  * **`NewDbContext.cs`**: Veritabanı bağlantı ve context sınıfıdır.
* **`/Migrations`**: Veritabanı şema değişikliklerinin (Code-First) tutulduğu kısımdır (`StartPoint` migration'ı içerir).

## 🚀 Teknolojiler

* .NET 10 (ASP.NET Core Web API)
* Entity Framework Core 10
* Repository Design Pattern

## 🛠️ Kurulum ve Çalıştırma

Projenin yerel bilgisayarınızda çalışması için aşağıdaki adımları izleyebilirsiniz:

1. Depoyu bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/ufukcoz/ASP.NET-ile-web-uygulama.git](https://github.com/ufukcoz/ASP.NET-ile-web-uygulama.git)
