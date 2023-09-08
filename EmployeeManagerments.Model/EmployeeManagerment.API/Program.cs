using EmployeeManagerment.API.Catalog.Deparment;
using EmployeeManagerment.API.Catalog.Employee;
using EmployeeManagerment.API.DBContext;
using EmployeeManagerment.API.Fluent_Validation;
using EmployeeManagerment.API.Request;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<EmployeeManagermentDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDB"));
});

builder.Services.AddScoped<IEmployeeRepository, EmployeeRespository>();
builder.Services.AddScoped<IDeparmentRespository, DeparmentRespository>();
builder.Services.AddScoped<IValidator<EmployeeRequest>, CreateNewEmployeeValidator>();
//câu quan trọng
builder.Services.AddControllers().AddFluentValidation();
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
