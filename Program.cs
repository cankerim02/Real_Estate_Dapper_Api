using Real_Estate_Dapper_Api.Models.DapperContext;
using Real_Estate_Dapper_Api.Models.Repositories.CategoryRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//�lgili Registiration ger�ekle�tirdik.
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
