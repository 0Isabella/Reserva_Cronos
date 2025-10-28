using CronosReferencia.Models;

namespace CronosReferencias.Routes;

public static class ROTA_GET
{
    public static void MapGetRoutes(this WebApplication app)
    {
        List<Reserva> reservas = new List<Reserva>
       {
            new Reserva { Id = 1, DataInicio = "2025-01-10", DataFim = "2025-01-11", Tamanho = 250.0f, NomeLocal = "Salão Ouro Branco", Valor = 3200.00f, Descricao = "Salão amplo com capacidade para 200 pessoas e climatização completa" },
            new Reserva { Id = 2, DataInicio = "2025-01-15", DataFim = "2025-01-16", Tamanho = 180.0f, NomeLocal = "Espaço Bella Festa", Valor = 2700.50f, Descricao = "Ambiente moderno com iluminação de LED e pista de dança" },
            new Reserva { Id = 3, DataInicio = "2025-02-02", DataFim = "2025-02-03", Tamanho = 300.0f, NomeLocal = "Salão Imperial", Valor = 4200.75f,  Descricao = "Espaço elegante com palco e cozinha industrial" },
            new Reserva { Id = 4, DataInicio = "2025-02-10", DataFim = "2025-02-11", Tamanho = 220.0f, NomeLocal = "Salão Jardim Encantado", Valor = 2950.20f,  Descricao = "Área arborizada com jardim e pergolado para cerimônias" },
            new Reserva { Id = 5, DataInicio = "2025-03-05", DataFim = "2025-03-06", Tamanho = 260.0f, NomeLocal = "Espaço Premier", Valor = 3500.00f,  Descricao = "Ambiente sofisticado com estrutura para eventos corporativos" },
            new Reserva { Id = 6, DataInicio = "2025-03-20", DataFim = "2025-03-21", Tamanho = 280.0f, NomeLocal = "Salão Diamante", Valor = 4100.00f,  Descricao = "Salão com palco, camarim e iluminação profissional" },
            new Reserva { Id = 7, DataInicio = "2025-04-12", DataFim = "2025-04-13", Tamanho = 190.0f, NomeLocal = "Espaço Viva Eventos", Valor = 2600.00f,  Descricao = "Salão versátil para festas de médio porte" },
            new Reserva { Id = 8, DataInicio = "2025-04-25", DataFim = "2025-04-26", Tamanho = 310.0f, NomeLocal = "Salão Harmonia", Valor = 4400.00f,  Descricao = "Espaço climatizado com estacionamento e área gourmet" },
            new Reserva { Id = 9, DataInicio = "2025-05-09", DataFim = "2025-05-10", Tamanho = 230.0f, NomeLocal = "Espaço Estilo & Festa", Valor = 3100.00f,  Descricao = "Ambiente moderno e totalmente adaptável" },
            new Reserva { Id = 10, DataInicio = "2025-05-20", DataFim = "2025-05-21", Tamanho = 200.0f, NomeLocal = "Salão Crystal", Valor = 2850.00f,  Descricao = "Salão com estrutura de som e iluminação integrada" },
            new Reserva { Id = 11, DataInicio = "2025-06-02", DataFim = "2025-06-03", Tamanho = 270.0f, NomeLocal = "Espaço Real", Valor = 3900.00f,  Descricao = "Ambiente climatizado com palco e cozinha equipada" },
            new Reserva { Id = 12, DataInicio = "2025-06-15", DataFim = "2025-06-16", Tamanho = 250.0f, NomeLocal = "Salão do Lago", Valor = 3300.00f,  Descricao = "Vista para o lago e espaço externo para cerimônias" },
            new Reserva { Id = 13, DataInicio = "2025-07-01", DataFim = "2025-07-02", Tamanho = 240.0f, NomeLocal = "Espaço Aurora", Valor = 3200.00f,  Descricao = "Decoração moderna com painéis de LED" },
            new Reserva { Id = 14, DataInicio = "2025-07-10", DataFim = "2025-07-11", Tamanho = 300.0f, NomeLocal = "Salão Elite", Valor = 4500.00f,  Descricao = "Espaço premium com climatização e estrutura completa" },
            new Reserva { Id = 15, DataInicio = "2025-07-22", DataFim = "2025-07-23", Tamanho = 260.0f, NomeLocal = "Espaço Bela Vista", Valor = 3400.00f,  Descricao = "Vista panorâmica e área verde ao redor" },
            new Reserva { Id = 16, DataInicio = "2025-08-03", DataFim = "2025-08-04", Tamanho = 280.0f, NomeLocal = "Salão Garden Hall", Valor = 3700.00f,  Descricao = "Área para eventos ao ar livre com cobertura retrátil" },
            new Reserva { Id = 17, DataInicio = "2025-08-12", DataFim = "2025-08-13", Tamanho = 230.0f, NomeLocal = "Espaço Celebration", Valor = 3100.00f,  Descricao = "Ambiente moderno e climatizado com decoração neutra" },
            new Reserva { Id = 18, DataInicio = "2025-08-28", DataFim = "2025-08-29", Tamanho = 190.0f, NomeLocal = "Salão Villa Real", Valor = 2800.00f, Descricao = "Espaço rústico com acabamento em madeira" },
            new Reserva { Id = 19, DataInicio = "2025-09-07", DataFim = "2025-09-08", Tamanho = 300.0f, NomeLocal = "Espaço Golden", Valor = 4200.00f,  Descricao = "Salão luxuoso com palco, pista e iluminação cenográfica" },
            new Reserva { Id = 20, DataInicio = "2025-09-15", DataFim = "2025-09-16", Tamanho = 210.0f, NomeLocal = "Salão Riviera", Valor = 2950.00f,  Descricao = "Ambiente clean e climatizado com estrutura moderna" },
            new Reserva { Id = 21, DataInicio = "2025-09-25", DataFim = "2025-09-26", Tamanho = 220.0f, NomeLocal = "Espaço Diamantina", Valor = 3050.00f,  Descricao = "Espaço aconchegante ideal para eventos familiares" },
            new Reserva { Id = 22, DataInicio = "2025-10-01", DataFim = "2025-10-02", Tamanho = 280.0f, NomeLocal = "Salão Mirante", Valor = 4100.00f,  Descricao = "Vista panorâmica da cidade e estacionamento privativo" },
            new Reserva { Id = 23, DataInicio = "2025-10-08", DataFim = "2025-10-09", Tamanho = 200.0f, NomeLocal = "Espaço Platinum", Valor = 3100.00f,  Descricao = "Ambiente moderno com estrutura para casamentos" },
            new Reserva { Id = 24, DataInicio = "2025-10-15", DataFim = "2025-10-16", Tamanho = 250.0f, NomeLocal = "Salão Roma", Valor = 3500.00f, Descricao = "Decoração clássica e iluminação quente" },
            new Reserva { Id = 25, DataInicio = "2025-10-22", DataFim = "2025-10-23", Tamanho = 260.0f, NomeLocal = "Espaço Magnólia", Valor = 3600.00f, Descricao = "Salão com área verde e estacionamento amplo" },
            new Reserva { Id = 26, DataInicio = "2025-10-29", DataFim = "2025-10-30", Tamanho = 230.0f, NomeLocal = "Salão Harmonia II", Valor = 3200.00f,  Descricao = "Ambiente climatizado com isolamento acústico" },
            new Reserva { Id = 27, DataInicio = "2025-11-05", DataFim = "2025-11-06", Tamanho = 290.0f, NomeLocal = "Espaço Grand Palace", Valor = 4300.00f,  Descricao = "Salão luxuoso com palco e área VIP" },
            new Reserva { Id = 28, DataInicio = "2025-11-15", DataFim = "2025-11-16", Tamanho = 210.0f, NomeLocal = "Salão Versatille", Valor = 3000.00f, Descricao = "Espaço modular adaptável para qualquer tipo de evento" },
            new Reserva { Id = 29, DataInicio = "2025-11-25", DataFim = "2025-11-26", Tamanho = 240.0f, NomeLocal = "Espaço Allegro", Valor = 3100.00f, Descricao = "Ambiente acolhedor e moderno com som ambiente" },
            new Reserva { Id = 30, DataInicio = "2025-12-05", DataFim = "2025-12-06", Tamanho = 300.0f, NomeLocal = "Salão Imperial II", Valor = 4500.00f, Descricao = "Espaço nobre com palco, jardim e estrutura completa" },
};


        app.MapGet("/", () => "CRONOS(API) de Reservas em funcionamento!");

        app.MapGet("/api/reserva", () => reservas);

        app.MapGet("/api/reserva/{id}", (int id) =>
        {
            var reserva = reservas.FirstOrDefault(r => r.Id == id);
            return reserva != null ? Results.Ok(reserva) : Results.NotFound("Reserva não encontrada.");
        });
    }
}