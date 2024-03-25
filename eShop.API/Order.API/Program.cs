using Microsoft.EntityFrameworkCore;
using Order.Infrustructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddDbContext<eShopDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("eShopDbConnection"));
});

// builder.Services.AddDbContext<eShopDbContext>(option =>
// {
//     option.UseSqlServer(Environment.GetEnvironmentVariable("eShopDb"));
// });



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