var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
app.MapControllerRoute("default", "{controller=Home}/{action=Auth}/{Id?}");
app.MapControllerRoute("default", "{controller=Home}/{action=NotFound}/{Id?}");

app.Run();
