using System.Threading.Tasks;
using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_PUT
{
    public static async Task MapPutRoutes(this WebApplication app)
    {
        app.MapPut("/reservas/{id}", (int id, Reserva input, ReservaContext context)) =>
        {
            var reserva = await context.Reservas.FindAsync(id);
            if (reserva is null)
                return Results.NotFound("Reserva não encontrada.");

            reserva.Id = input.Id;
            reserva.DataInicio = input.DataInicio;
            reserva.DataFim = input.DataFim;
            reserva.Tamanho = input.Tamanho;
            reserva.NomeLocal = input.NomeLocal;
            reserva.Valor = input.Valor;
            reserva.Descricao = input.Descricao;

            await context.SaveChangeAsync();

            return Results.Ok(reserva);
        }
    }
}