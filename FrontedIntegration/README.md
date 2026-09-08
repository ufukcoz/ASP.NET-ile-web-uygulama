# Frontend - Backend Entegrasyonu (Haberler API)

ASP.NET Core Web API ve Vanilla JS (Fetch API) kullanılarak geliştirilmiş temel haber listeleme ve ekleme uygulamasıdır.

## 🛠️ Teknolojiler
- **Backend:** C#, ASP.NET Core, Entity Framework Core
- **Frontend:** HTML, CSS, JavaScript 

## ⚙️ Kurulum ve Çalıştırma

1. Visual Studio üzerinden backend projesini ayağa kaldırın (Varsayılan: `https://localhost:7235`).
2. JS dosyanızdaki API adresinin (`NEWS_ENDPOINT`) backend portunuzla eşleştiğinden emin olun.
3. Tarayıcıda CORS veya Fetch hatası almamak için yeni sekmede API adresine (örn: `https://localhost:7235/api/NewsArticles`) gidip **SSL sertifikası uyarısını (localhost) geçerek onay verin**.
4. Frontend dosyalarınızı VS Code üzerinden **Live Server** ile (örn: `5500` portunda) çalıştırın.
