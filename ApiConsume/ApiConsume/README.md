# ApiConsume - ASP.NET Core API Tüketimi Projesi

Bu proje, bağımsız bir Web API servisinin (Provider) bir ASP.NET Core MVC uygulaması (Client) tarafından nasıl tüketildiğini (API Consumption) göstermek amacıyla geliştirilmiştir. 

**Mimari Yapı**
Proje aynı çözüm (Solution) altında iki temel bileşenden oluşmaktadır:
* **News (Web API):** Arka planda çalışan, Entity Framework Core ile veritabanı işlemlerini yöneten ve haber verilerini JSON formatında dışa sunan RESTful servis.
* **ContactApp (MVC/UI):** Kullanıcı arayüzünü barındıran ve `HttpClient` kullanarak News API'nin sunduğu uç noktalara (endpoints) istek atıp verileri listeleyen istemci uygulaması.

**Kullanılan Teknolojiler**
* C# & ASP.NET Core (MVC & Web API)
* Entity Framework Core
* `HttpClient` & JSON Deserialization
* Bootstrap (Arayüz tasarımı)

**Projeyi Çalıştırma Adımları**

Projenin sorunsuz çalışabilmesi için API ve MVC projelerinin **aynı anda** ayağa kalkması gerekmektedir:

1. Projeyi klonlayın ve Visual Studio'da `ApiConsume.sln` dosyasını açın.
2. Çözüm Gezgini'nde (Solution Explorer) en üstteki Çözüm ismine sağ tıklayıp **Özellikler (Properties)** sekmesine girin.
3. Soldaki menüden **Başlangıç Projesi (Startup Project)** seçeneğine tıklayın.
4. **Birden çok başlangıç projesi (Multiple startup projects)** ayarını seçin.
5. Listeden hem `ContactApp` hem de `News` projelerinin yanındaki eylemi **Başlat (Start)** olarak değiştirip **Uygula** deyin.
6. Projeyi çalıştırın. `News` servisi arka planda ayağa kalkacak ve `ContactApp` içerisindeki Haberler sayfası, API'den çektiği verileri ekrana yansıtacaktır.

**Not:** Port çakışması veya bağlantı hatası yaşamamak için `ContactApp` altındaki `appsettings.json` ve `appsettings.Development.json` dosyalarında yer alan `ApiBaseUrl` değerinin, `News` projesinin çalıştığı port adresiyle birebir aynı olduğundan emin olun.
