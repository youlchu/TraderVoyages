using Microsoft.EntityFrameworkCore;
using TraderVoyages.Application.Interfaces;
using TraderVoyages.Application.Services;
using TraderVoyages.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Swagger ve diğer API araçlarını ekleyin
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AddControllers çağrısını ekleyin
builder.Services.AddControllers();

// Oyun servislerini ve DbContext'i ekleyin.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Uygulama servislerini ekleyin
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<IMountTypeService, MountTypeService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IGoodService, GoodService>();


var app = builder.Build();

// Geliştirme ortamında ise Swagger UI kullanımını etkinleştir
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTPS yönlendirmesini ve Controller'ları kullan
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
