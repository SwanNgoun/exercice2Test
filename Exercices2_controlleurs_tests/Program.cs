var builder = WebApplication.CreateBuilder(args);
//Relier les views aux contr�leurs
builder.Services.AddControllersWithViews();
var app = builder.Build();

//configurer les routes : le format des url
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Welcome}/{action=WelcomeDefault}/{id?}" 
);

app.MapControllerRoute(
 name: "default",
 //la m�thode d'action et les param�tres
 pattern: "/{nom}/{prenom}",
 //dfaults: indiquer le contr�leur et la m�thode d'action par d�fault
 defaults: new { controller = "Welcome", action = "WelcomeName"}
);

app.Run();
