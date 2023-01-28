
using Supermarket.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using supermarket.API.Domain.Repositories;
using supermarket.API.Domain.Services;
using supermarket.API.Persistence.Repositories;
using supermarket.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    // Install-Package Microsoft.EntityFrameworkCore.InMemory
    options.UseInMemoryDatabase("supermarket-api-in-memory")
    /*
    // Install-Package Microsoft.EntityFrameworkCore.SqlServer
    //var connectionString = builder.Configuration.GetConnectionString("DefaultConenciton");
    //options.UseSqlServer(connectionString)
    */
);
/*
// bind our service and repository to the respective classes.
// these classes internally have to use the database context class.
// It makes sense to specify the same scope in this case.
*/
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<AppDbContext>())
{
    context?.Database.EnsureCreated();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// app.UseStaticFiles();
app.UseRouting();
// app.UseAuthorization();
//app.MapControllers();
app.Run();

/*
// Transient (New Instance Every Time)
// - it is assumed that dependencies marked transient will not manage their own state.
// - lightweight, and have a limited number of dependencies.
// Scoped (Once Per Application Request)
// - The dependency instance is created at the beginning of the request,
//   injected into all dependencies that need it during the request,
//   and disposed of by the container at the end of the request.
// Singleton (One Instance, Almost Forever)
// - A singleton is a dependency that is created once by the container on application startup
//   and then injected into every dependent class that needs an instance of it.
//   That instance will exist until the application is shut down or restarted
*/