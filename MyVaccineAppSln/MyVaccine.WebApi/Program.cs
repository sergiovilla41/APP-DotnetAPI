using Microsoft.EntityFrameworkCore;
using MyVaccine.WebApi.Configurations;
using MyVaccine.WebApi.Literals;
using MyVaccine.WebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.SetDatabaseConfiguration();
builder.Services.AddDbContext<MyVaccineDbContext>(options =>
    options.UseSqlServer(Environment.GetEnvironmentVariable(MyVaccineLiterals.Connection)));

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
