using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_POST
{
    public static void MapPostRoutes(this WebApplication app)
    {
        app.MapPost("/reservas", (Reserva nova) =>
        {
            nova.Id = Database.Reservas.Count + 1;
            Database.Reservas.Add(nova);
            return Results.Created($"/api/reservas/{nova.Id}", nova);
        });
    }
}