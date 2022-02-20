using System.Reflection;
using AssignmentManagement.Business.Abstract;
using AssignmentManagement.Business.Concrete;
using AssignmentManagement.Business.Mapping;
using AssignmentManagement.Core.DataAccess;
using AssignmentManagement.Core.DataAccess.EntityFramework;
using AssignmentManagement.Core.DataAccess.UnitOfWorks;
using AssignmentManagement.DataAccess.Concrete.EntityFramework.Context;
using AssignmentManagement.DataAccess.Concrete.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepositoryBase<>),typeof(EfGenericRepositoryBase<>));
builder.Services.AddScoped(typeof(IService<,>), typeof(ServiceManager<,>));

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseAuthorization();

app.MapControllers();

app.Run();
