var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
 name: "default",
 //la méthode d'action
 pattern: "/{action=Index}",
 //dfaults: indiquer le contrôleur et la méthode d'action par défault
 defaults: new { controller = "Home"}
);

app.Run();
