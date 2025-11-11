using System.Threading.Tasks;
using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_POST
{
    public static void MapPostRoutes(this WebApplication app)
    {
        app.MapPost("/reservas", async Reserva reserva, ReservaContext context) =>

        context.Reservas.Add(reserva);

        await context.SaveChangeAsync();

        return Results.Created($"/reservas/{reserva.Id}", reserva);
    }
}