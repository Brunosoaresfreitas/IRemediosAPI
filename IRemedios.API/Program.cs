using IRemedios.Core.IRepositories;
using IRemedios.Infrastructure.Context;
using IRemedios.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("IRemediosCS");
builder.Services.AddDbContext<IRemediosDbContext>(o => o.UseSqlServer(connectionString, b => b.MigrationsAssembly("IRemedios.API")));

builder.Services.AddScoped<IMedicineRepository, MedicineRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
