using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Singleton-Scoped-Transient -> Lifetime
// Singleton => uretilen bagimlilik uygulama acik oldugu surece tek bir kere newlenir
// Her enjeksiyonda o instance kullanilir.

// scoped => (api istegi) istek basina 1 instance olusturur.
// trasient => her adimda (her talepte) yeni bir instance
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductRepository, EfProductRepository>();
builder.Services.AddDbContext<BaseDbContext>();

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
