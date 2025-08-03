using Microsoft.EntityFrameworkCore;
using Muhasebe.DataAccess;
using Muhasebe.Core;
using Muhasebe.Business;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MuhasebeContext>(options =>
    options.UseSqlServer(connectionString));

// Repository'leri ekle
builder.Services.AddScoped<MusteriRepository>();
builder.Services.AddScoped<UrunRepository>();
builder.Services.AddScoped<FaturaRepository>();
builder.Services.AddScoped<FaturaDetayRepository>();
builder.Services.AddScoped<StokHareketRepository>();

// Service'leri ekle
builder.Services.AddScoped<MusteriService>();
builder.Services.AddScoped<UrunService>();
builder.Services.AddScoped<FaturaService>();
builder.Services.AddScoped<FaturaDetayService>();
builder.Services.AddScoped<StokHareketService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin => true).AllowCredentials());

app.MapControllers();

app.Run();

