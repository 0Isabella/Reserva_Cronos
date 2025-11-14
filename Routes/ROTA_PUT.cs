using CronosReserva.Models;

namespace CronosReserva.Routes;

public static class ROTA_PUT
{
    public static void MapPutRoutes(this WebApplication app)
    {
        app.MapPut("/reservas/{id}", (int id, Reserva atualizada) =>
        {
            var refItem = Database.Reservas.FirstOrDefault(r => r.Id == id);
            if (refItem is null)
                return Results.NotFound("Reserva não encontrada.");

            refItem.Id = atualizada.Id;
            refItem.Nome = atualizada.Nome;
            refItem.Telefone = atualizada.Telefone;
            refItem.DataInicio = atualizada.DataInicio;
            refItem.DiasAlugados = atualizada.DiasAlugados;
            refItem.Tamanho = atualizada.Tamanho;
            refItem.NomeLocal = atualizada.NomeLocal;
            refItem.ValorTotal = atualizada.ValorTotal;
            refItem.Descricao = atualizada.Descricao;

            return Results.Ok(refItem);
        });
    }
}