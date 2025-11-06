using EmployeeAdminPortal.CQRS.Infrastructure;
using EmployeeAdmnPortal.Data;
//using EmployeeAdmnPortal.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

//  Swagger/OpenAPI proper configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Employee Admin Portal API", 
        Version = "v1",
        Description = "Simple API using CQRS + MediatR + AutoMapper"
    });
});

//  Database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));


// for repo pattern
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

//  MediatR
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

//  AutoMapper
//builder.Services.AddAutoMapper(typeof(MappingProfile)); // use your MappingProfile class

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        //  Proper endpoint mapping
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee Admin Portal API v1");
        //c.RoutePrefix = string.Empty; // optional: opens swagger at root URL
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
