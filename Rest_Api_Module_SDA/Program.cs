using DataLayer.DBContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.AddCors(options =>
{
    options.AddPolicy("EnableCORS", builder =>
    {
        builder.AllowAnyOrigin()
           .AllowAnyHeader()
           .AllowAnyMethod();
    });
});
builder.Services.AddEntityFrameworkSqlServer()
        .AddDbContext<LibrariaDBContext>(options =>
          options.UseSqlServer("Data Source=WINDOWS-4PGG12B;Initial Catalog=Libraria_REST_API_MODULE;Integrated Security=True"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("EnableCORS");
app.UseAuthorization();
app.MapControllers();

app.Run();
