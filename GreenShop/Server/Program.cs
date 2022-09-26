global using GreenShop.Shared;
global using Microsoft.EntityFrameworkCore;
global using GreenShop.Server.Data;
global using GreenShop.Server.Services.ProductService;
global using GreenShop.Server.Services.CategoryService;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    // This is how we make our SQL DB Connection - Using our appsettings.json connection string
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Adding API Explorer and SwaggerUI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adding our Product Services Interface and Implementations (Interface along with class)
// We can rename ProductService here in order to test with a different class 
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();


var app = builder.Build();

// Adding Swagger UI to this build
app.UseSwaggerUI();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
// Adding SwaggerUI
app.UseSwagger();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

