using ContactApp.Repositories;
using ContactApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Veritabanı ve Repository Tanımları
builder.Services.AddDbContext<ContactDbContext>(options =>
{
    var connStr = builder.Configuration.GetConnectionString("DefaultConnection")
        ?? "Data Source=App_Data/contacts.db";
    options.UseSqlite(connStr);
});

builder.Services.AddScoped<IContactRepository, EfContactRepository>();

// 1. ADIM: Port Ayarı
// Eğer API aynı projede çalışıyorsa port 7219'dur. Ayrı bir API projesi çalıştırıyorsanız onun portunu yazın (örn: 7208).
var apiBaseUrl = builder.Configuration["ApiBaseUrl"] ?? "https://localhost:7235/";

// 2. ADIM: HttpClient Tanımı (Geliştirme ortamındaki SSL sertifika hatalarını yok sayar)
builder.Services.AddHttpClient<INewsService, NewsService>(client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
}).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
{
    // Yerel geliştirme (localhost) sertifika uyarılarını bypass eder
    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();

// API Controller'larının rota haritasını ekler (Eğer API bu projedeyse şarttır)
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Veritabanı Migration ve Seed işlemleri
using (var scope = app.Services.CreateScope())
{
    var dataDir = Path.Combine(app.Environment.ContentRootPath, "App_Data");
    Directory.CreateDirectory(dataDir);

    var db = scope.ServiceProvider.GetRequiredService<ContactDbContext>();
    db.Database.Migrate();
    DbSeeder.Seed(db);
}

app.Run();