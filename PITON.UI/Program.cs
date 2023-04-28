using System;
using Microsoft.EntityFrameworkCore;
using PITON.Business.Abstract;
using PITON.Business.Concrete;
using PITON.DataAccess;
using PITON.DataAccess.Abstract;
using PITON.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IETransactionDal, EfETransactionDal>();
builder.Services.AddScoped<IETransactionService, ETransactionManager>();
builder.Services.AddDbContext<Context>();


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

