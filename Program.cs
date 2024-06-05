using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PruebaDesempeño.Data;
using PruebaDesempeño.Services.Pets;
using PruebaDesempeño.Services.Owners;
using PruebaDesempeño.Services.Vets;
using PruebaDesempeño.Services.Quotes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContex> (options =>
options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnetion"),
Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddControllers();

//scoped

builder.Services.AddScoped<IOwnersRepository,OwnerRepository>();
builder.Services.AddScoped<IVetsRepository, VetsRepository>();
builder.Services.AddScoped<IPetsRepository,PetsRepository>();
builder.Services.AddScoped<IQuotesRepository, QuotesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

