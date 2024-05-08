using Pronia1.DataAccesLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Pronia1Context>();
var app = builder.Build();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute("default", "{controller=home}/{action=index}");

app.Run();
