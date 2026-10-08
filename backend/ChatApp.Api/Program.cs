using Microsoft.EntityFrameworkCore;
using ChatApp.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine(
    builder.Configuration.GetConnectionString("DefaultConnection")
);

builder.Services.AddDbContext<ChatAppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();