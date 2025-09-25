using BlazorShop.Api.Data;
using BlazorShop.Api.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Sql Connection
builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repository
builder.Services.AddScoped<IProduct,ProdutoRepository>();

// AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());    

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
