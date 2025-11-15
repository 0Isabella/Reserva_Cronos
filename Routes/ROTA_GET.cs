using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_GET
{
    public static void MapGetRoutes(this WebApplication app)
    {
        app.MapGet("/", () => "CRONOS(API) de Reservas em funcionamento!");

        
        app.MapGet("/reservas", () => Database.Reservas);

        
        app.MapGet("/reservas/{id}", (int id) =>
        {
            try
            {
                var reserva = Database.Reservas.FirstOrDefault(r => r.Id == id);
                return reserva != null ? Results.Ok(reserva) : Results.NotFound($"Reserva com ID {id} não encontrada.");
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Erro ao buscar reserva: {ex.Message}");
            }
        });
    }
}