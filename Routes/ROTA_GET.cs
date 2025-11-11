using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_GET
{
    public static void MapGetRoutes(this WebApplication app)
    {
       app.MapGet("/Reservas",async (ReservasContext context)=>
       {
        var Reservas = await context.Reservas.ToListAsync()
        
        return Results.OK(Reservas);
       });
       app.MapGet("/Reservas/{id}",async(int id, ReservasContext context)=>
       {
        var Reservas = await context.Reservas.FindAsync(id);
        return Reservas is not null ? Results.Ok(Reservas) : ResultsNotFound();
       })
    }
}