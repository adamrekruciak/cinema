using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using ProjektBlazor.API.Data;
using ProjektBlazor.API.Repozytoria;
using ProjektBlazor.API.Repozytoria.Kontrakty;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<KinoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KinoConnection"))
    );

builder.Services.AddScoped<IRepozytoriumMiejsca, MiejscaRepozytorium>();
builder.Services.AddScoped<IFilmsRepository, FilmsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
            policy.WithOrigins("https://localhost:7021", "https://localhost:7021")
            .AllowAnyMethod()
            .WithHeaders(HeaderNames.ContentType)
            );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
