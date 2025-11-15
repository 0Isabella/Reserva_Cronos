using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_GET
{
    public static void MapGetRoutes(this WebApplication app)
    {
        app.MapGet("/", () => "CRONOS(API) de Reservas em funcionamento!");

        app.MapGet("/reserva", () => Database.Reservas);

        app.MapGet("/reserva/{id}", (int id) =>
        {
            var reserva = Database.Reservas.FirstOrDefault(r => r.Id == id);
            return reserva != null ? Results.Ok(reserva) : Results.NotFound("Reserva não encontrada.");
        });
    }
}