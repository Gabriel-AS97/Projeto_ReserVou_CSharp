using Microsoft.EntityFrameworkCore;
using ReserVou.Repositorio;
using ReserVou.Servico;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EstabelecimentoDBContext>(options => options.UseInMemoryDatabase("EstabelecimentoDb"));
builder.Services.AddScoped<IEstabelecimentoRepositorio, EstabelecimentoRepositorio>();
builder.Services.AddScoped<IEstabelecimentoServico, EstabelecimentoServico>();

/*builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost4200",
     policy =>
     {
         policy.WithOrigins("http://localhost:4200")
     .AllowAnyHeader()
     .AllowAnyMethod();
     });
});*/

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

/*app.UseCors("AllowLocalhost4200");*/

app.MapControllers();

app.Run();
