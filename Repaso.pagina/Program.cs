//1A)using to work with Entity Framework 
using Microsoft.EntityFrameworkCore;//para hacer las conecciones de tipo sql server
using Repaso.pagina.Pagina.Data;//importar el namespace del dbcontext

var builder = WebApplication.CreateBuilder(args);

//2A)Coneccition with sql server express
const string ConnectionName = "DefaultConnection";
var conecctionString=builder.Configuration.GetConnectionString(ConnectionName) ?? throw new InvalidOperationException($"Connection string '{ConnectionName}' not found.");

//3B)add DBContext to services
builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(conecctionString));


// Add services to the container.


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
