using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RazorPage.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;




var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IDbConnection>(sp => new SqlConnection("Server=np:\\\\.\\pipe\\LOCALDB#22EC0A90\\tsql\\query; Database =ProductDB;Trusted_Connection=True;TrustServerCertificate=True"));
builder.Services.AddScoped<ProductContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
