var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{Id?}");
app.MapControllerRoute(name: "Person", pattern: "{controller=Home}/{action=Person}/{Id?}");
app.MapControllerRoute(name: "Array", pattern: "{controller=Home}/{action=Array}/{Id?}");
app.MapControllerRoute(name: "ArrayPersons", pattern: "{controller=Home}/{action=ArrayPersons}/{Id?}");
app.MapControllerRoute(name: "Dictionary", pattern: "{controller=Home}/{action=Dictionary}/{Id?}");

app.Run();
