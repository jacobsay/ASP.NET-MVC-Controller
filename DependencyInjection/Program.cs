using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddTransient<ITimeService, TimeService>();
var app = builder.Build();

app.MapControllerRoute("index", "{controller=Home}/{action=Index}/{Id?}");
app.MapControllerRoute("func", "{controller=Home}/{action=FuncArg}/{Id?}");
app.MapControllerRoute("request", "{controller=Home}/{action=Request}/{Id?}");

app.Run();
