using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_POST
{
    public static void MapPostRoutes(this WebApplication app)
    {
        List<Reserva> reservas = new List<Reserva>();

        app.MapPost("/api/reservas", (Reserva nova) =>
        {
            nova.Id = reservas.Count + 1;
            reservas.Add(nova);
            return Results.Created($"/api/reservas/{nova.Id}", nova);
        });
    }
}