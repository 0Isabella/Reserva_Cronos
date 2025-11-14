using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_PUT
{
    public static void MapPutRoutes(this WebApplication app)
    {
        List<Reserva> reservas = new List<Reserva>();

        app.MapPut("/api/reservas/{id}", (int id, Reserva atualizada) =>
        {
            var refItem = reservas.FirstOrDefault(r => r.Id == id);
            if (refItem is null)
                return Results.NotFound("Reserva não encontrada.");

            refItem.Id = atualizada.Id;
            refItem.Nome = atualizada.Nome;
            refItem.Telefone = atualizada.Telefone;
            refItem.DataInicio = atualizada.DataInicio;
            refItem.DataFim = atualizada.DataFim;
            refItem.Tamanho = atualizada.Tamanho;
            refItem.NomeLocal = atualizada.NomeLocal;
            refItem.Valor = atualizada.Valor;
            refItem.Descricao = atualizada.Descricao;

            return Results.Ok(refItem);
        });
    }
}