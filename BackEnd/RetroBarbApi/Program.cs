global using Serilog;
global using RetroBarbApi.Services.UserService;
using Microsoft.EntityFrameworkCore;
using RetroDL;
using RetroBL;
using RetroModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);


Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/logs.txt")
    .CreateLogger();
Log.Information("Api is now running.");


// Added Cache for Demo purposes, not implemented
builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// Will need to enter bearer + generated token to enter the API methods from the Swagger OpenAPI
builder.Services.AddScoped<IUserService, UserService>();
//HttpContextAccessor
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen(options =>{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme 
    {
        Description = "Standard Authorization Header Using the Bearer Scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>{
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
            .GetBytes(builder.Configuration.GetSection("Appsettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

//Add DbContext Conect String Configuration through Options
builder.Services.AddDbContext<RetroStoreDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Ref2DB")));

//BL Scoped Dependencies
builder.Services.AddScoped<IRetroBL<Customers>, CustomersBL>();
builder.Services.AddScoped<IRetroBL<CartItems>, CartItemsBL>();
builder.Services.AddScoped<IRetroBL<Stores>, StoresBL>();
builder.Services.AddScoped<IRetroBL<Products>, ProductsBL>();
builder.Services.AddScoped<IRetroBL<Orders>, OrdersBL>();
builder.Services.AddScoped<IRetroBL<Inventory>, InventoryBL>();

//Repo Scoped Dependencies
builder.Services.AddScoped<IRepository<Customers>,DbContextCustomersRepo>();
builder.Services.AddScoped<IRepository<Inventory>,DbContextInventoryRepo>();
builder.Services.AddScoped<IRepository<CartItems>,DbContextCartItemsRepo>();
builder.Services.AddScoped<IRepository<Orders>,DbContextOrdersRepo>();
builder.Services.AddScoped<IRepository<Products>,DbContextProductsRepo>();
builder.Services.AddScoped<IRepository<Stores>,DbContextStoresRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Must be above Authorization
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

Log.Information("Api program is exited.");