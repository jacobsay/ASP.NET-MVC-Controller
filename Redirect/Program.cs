var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
app.MapControllerRoute("About", "{controller=Home}/{action=About}/{Id?}");
app.MapControllerRoute("Info", "{controller=Home}/{action=Info}/{Id?}");

app.MapControllerRoute("Redirect", "{controller=Redirect}/{action=Redirect}/{Id?}");
app.MapControllerRoute("RedirectPer", "{controller=Redirect}/{action=RedirectPer}/{Id?}");
app.MapControllerRoute("RedirectToAct", "{controller=Redirect}/{action=RedirectToAct}/{Id?}");
app.MapControllerRoute("RedirectToRoute", "{controller=Redirect}/{action=RedirectToRoute}/{Id?}");

app.Run();
