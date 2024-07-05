using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PhoneBook.Application.Interfaces;
using PhoneBook.Application.Services;
using PhoneBook.Domain.Interfaces;
using PhoneBook.Domain.Mappings;
using PhoneBook.InfraData;
using PhoneBook.InfraData.Context;
using PhoneBook.InfraData.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("PhoneBookConnection")));

builder.Services.AddScoped<IPhoneBookService, PhoneBookService>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IPhonesRepository, PhonesRepository>();
builder.Services.AddScoped<IEntityToDTOMapper, EntityToDTOMapper>();


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
