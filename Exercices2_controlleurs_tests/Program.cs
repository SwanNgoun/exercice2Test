var builder = WebApplication.CreateBuilder(args);
//Relier les views aux contrôleurs
builder.Services.AddControllersWithViews();
var app = builder.Build();

//configurer les routes : le format des url
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Welcome}/{action=WelcomeDefault}/{id?}" 
);

app.MapControllerRoute(
 name: "default",
 //la méthode d'action et les paramètres
 pattern: "/{nom}/{prenom}",
 //dfaults: indiquer le contrôleur et la méthode d'action par défault
 defaults: new { controller = "Welcome", action = "WelcomeName"}
);

app.Run();
