var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
app.MapControllerRoute("file", "{controller=Home}/{action=GetFile}/{Id?}");
app.MapControllerRoute("bytes", "{controller=Home}/{action=GetBytes}/{Id?}");
app.MapControllerRoute("stream", "{controller=Home}/{action=GetStream}/{Id?}");

app.Run();
