using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_DELETE
{
    public static void MapDeleteRoutes(this WebApplication app)
    {
        List<Reserva> reservas = new List<Reserva>();

        app.MapDelete("/reservas/{id}", (int id) =>
        {
            var refItem = reservas.FirstOrDefault(r => r.Id == id);
            if (refItem is null)
                return Results.NotFound("Reserva não encontrada.");

            reservas.Remove(refItem);
            return Results.NoContent();
        });
    }
}