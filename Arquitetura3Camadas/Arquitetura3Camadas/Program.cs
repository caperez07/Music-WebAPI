using Models.Music;
using DAL.Config;
using Microsoft.EntityFrameworkCore;
using DAL.MusicRepository;
using BLL.MusicViewModelInterface;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ContextBase>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<MusicI<MusicViewModel>, MusicRep>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
