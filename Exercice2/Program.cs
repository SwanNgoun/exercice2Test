var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
 name: "default",
 //la m�thode d'action
 pattern: "/{action=Index}",
 //dfaults: indiquer le contr�leur et la m�thode d'action par d�fault
 defaults: new { controller = "Home"}
);

app.Run();
