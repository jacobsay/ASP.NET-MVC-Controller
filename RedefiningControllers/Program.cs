var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");

app.Run();
