using BusinessLogic.Services;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IEmployeeDao>(_ => new EmployeeDao(connectionString));
builder.Services.AddScoped<IManagerDao>(_ => new ManagerDao(connectionString));
builder.Services.AddScoped<IProjectDao>(_ => new ProjectDao(connectionString));
builder.Services.AddScoped<ITaskItemDao>(_ => new TaskItemDao(connectionString));
builder.Services.AddScoped<IService, Service>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
