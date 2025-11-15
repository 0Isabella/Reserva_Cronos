using CronosReserva.Models;
using CronosReserva.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Database.Dados();

app.MapGetRoutes();
app.MapDeleteRoutes();
app.MapPostRoutes();
app.MapPutRoutes();
app.Run();
