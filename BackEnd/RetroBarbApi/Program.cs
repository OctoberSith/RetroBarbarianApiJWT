using Microsoft.EntityFrameworkCore;
using RetroDL;
using RetroModels;

var builder = WebApplication.CreateBuilder(args);

// ******Add services to the container.*****************************************************************************************************

// Added Cache for Demo purposes, not implemented
builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add DbContext Conect String Configuration through Options
builder.Services.AddDbContext<RetroStoreDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Ref2DB")));

//Repo Scoped Depenencies
builder.Services.AddScoped<IRepository<Customers>,DbContextCustomersRepo>();
builder.Services.AddScoped<IRepository<Inventory>,DbContextInventoryRepo>();
builder.Services.AddScoped<IRepository<CartItems>,DbContextCartItemsRepo>();
builder.Services.AddScoped<IRepository<Orders>,DbContextOrdersRepo>();
builder.Services.AddScoped<IRepository<Products>,DbContextProductsRepo>();
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
