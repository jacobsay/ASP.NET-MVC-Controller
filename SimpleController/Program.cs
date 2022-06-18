var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}");

app.MapControllerRoute(
    name: "info",
    pattern: "{controller=Home}/{action=Info}/{Id?}");

app.Run();
