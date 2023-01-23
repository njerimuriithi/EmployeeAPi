using EmployeeAPi.Data;
using EmployeeAPi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Register the Dependancy
builder.Services.AddScoped<IEmployeeRepo , SqlEmployeeData>();
//EmployeesAPIDb name of database
builder.Services.AddDbContextPool<EmployeeDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
//builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseInMemoryDatabase("EmployeesAPIDb"));

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
