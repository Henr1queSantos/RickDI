using RickDI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Transient: BusinessLogicService is stateless and lightweight
builder.Services.AddTransient<IOperationTransient, Operation>();

// Scoped: DbContext should be new for each request
builder.Services.AddScoped<IOperationScoped, Operation>();

// Singleton: LoggerService should be shared across the application
builder.Services.AddSingleton<IOperationSingleton, Operation>();

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
