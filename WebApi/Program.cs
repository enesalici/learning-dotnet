using Business.Abstracts;
using Business.Concrates;
using Core.crossCuttingConcerns.Exceptions;
using DataAccess.Abstracts;
using DataAccess.Concrates.EntityFramework;
using DataAccess.Concretes.EntityFramework;
using Core.crossCuttingConcerns.Exceptions.Extensions;
using System.Reflection;
using Business;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//extensions metod katmanlar kendi bağımlıklarını enjekte ediyor
builder.Services.AddBusinessServices();
builder.Services.AddDataAccessServices();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//extensions metod kullanarak projeyi tek satırda dahil ettik
//app.ConfigureExceptionMiddlewareExtensions();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
