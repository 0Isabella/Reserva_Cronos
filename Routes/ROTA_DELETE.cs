using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_DELETE
{
    public static void MapDeleteRoutes(this WebApplication app)
    {
        app.MapDelete("/reservas/{id}", async (int id, ReservasContext context) =>
        {
            var reserva = await context.Reservas.FindAsync{id};
            var reserva = reservas.FirstOrDefault(r => r.Id == id);
            if (reserva is null)
                return Results.NotFound("Reserva não encontrada.");

            context.Reservas.Remove(reserva);

            await context.SaveChangeAsync();
            
            return Results.Ok();
        });
    }
}