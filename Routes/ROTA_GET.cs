using CronosReserva.Models;

namespace CronosReserva.Routes;

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
            new Reserva { Id = 31, DataInicio = "2026-01-10", DataFim = "2026-01-11", Tamanho = 250.0f, NomeLocal = "Espaço Aurora II", Valor = 3400.00f, Descricao = "Ambiente moderno com decoração elegante e iluminação personalizada" },
            new Reserva { Id = 32, DataInicio = "2026-01-18", DataFim = "2026-01-19", Tamanho = 200.0f, NomeLocal = "Salão Bela Arte", Valor = 2800.00f, Descricao = "Espaço climatizado ideal para pequenas recepções" },
            new Reserva { Id = 33, DataInicio = "2026-01-28", DataFim = "2026-01-29", Tamanho = 280.0f, NomeLocal = "Espaço Monte Carlo", Valor = 4100.00f, Descricao = "Ambiente sofisticado com estrutura de som e iluminação" },
            new Reserva { Id = 34, DataInicio = "2026-02-05", DataFim = "2026-02-06", Tamanho = 300.0f, NomeLocal = "Salão Royal Garden", Valor = 4400.00f, Descricao = "Área ajardinada com gazebo e fonte decorativa" },
            new Reserva { Id = 35, DataInicio = "2026-02-12", DataFim = "2026-02-13", Tamanho = 230.0f, NomeLocal = "Espaço Village", Valor = 3100.00f, Descricao = "Espaço moderno com estacionamento amplo" },
            new Reserva { Id = 36, DataInicio = "2026-02-25", DataFim = "2026-02-26", Tamanho = 260.0f, NomeLocal = "Salão Premier II", Valor = 3600.00f, Descricao = "Salão climatizado com estrutura completa para eventos" },
            new Reserva { Id = 37, DataInicio = "2026-03-05", DataFim = "2026-03-06", Tamanho = 240.0f, NomeLocal = "Espaço Vivace", Valor = 3200.00f, Descricao = "Ambiente moderno com área externa para coquetéis" },
            new Reserva { Id = 38, DataInicio = "2026-03-12", DataFim = "2026-03-13", Tamanho = 280.0f, NomeLocal = "Salão Riviera II", Valor = 3900.00f, Descricao = "Espaço elegante com palco e iluminação de destaque" },
            new Reserva { Id = 39, DataInicio = "2026-03-22", DataFim = "2026-03-23", Tamanho = 220.0f, NomeLocal = "Espaço Allegra", Valor = 3000.00f, Descricao = "Ambiente acolhedor ideal para aniversários e formaturas" },
            new Reserva { Id = 40, DataInicio = "2026-04-02", DataFim = "2026-04-03", Tamanho = 300.0f, NomeLocal = "Salão Ouro Branco II", Valor = 4500.00f, Descricao = "Salão nobre com vista panorâmica e climatização total" },
            new Reserva { Id = 41, DataInicio = "2026-04-10", DataFim = "2026-04-11", Tamanho = 270.0f, NomeLocal = "Espaço Bella Luna", Valor = 3400.00f, Descricao = "Decoração moderna e iluminação LED personalizada" },
            new Reserva { Id = 42, DataInicio = "2026-04-18", DataFim = "2026-04-19", Tamanho = 190.0f, NomeLocal = "Salão Monte Verde", Valor = 2800.00f, Descricao = "Ambiente rústico com acabamento em madeira" },
            new Reserva { Id = 43, DataInicio = "2026-05-03", DataFim = "2026-05-04", Tamanho = 250.0f, NomeLocal = "Espaço Harmonia III", Valor = 3200.00f, Descricao = "Ambiente climatizado e ideal para eventos corporativos" },
            new Reserva { Id = 44, DataInicio = "2026-05-10", DataFim = "2026-05-11", Tamanho = 210.0f, NomeLocal = "Salão Versatille II", Valor = 3100.00f, Descricao = "Salão modular com divisórias móveis e iluminação controlada" },
            new Reserva { Id = 45, DataInicio = "2026-05-18", DataFim = "2026-05-19", Tamanho = 300.0f, NomeLocal = "Espaço Jardim Real", Valor = 4200.00f, Descricao = "Espaço externo com jardim e pergolado para cerimônias" },
            new Reserva { Id = 46, DataInicio = "2026-05-25", DataFim = "2026-05-26", Tamanho = 280.0f, NomeLocal = "Salão Crystal II", Valor = 4000.00f, Descricao = "Ambiente sofisticado com palco e área VIP" },
            new Reserva { Id = 47, DataInicio = "2026-06-01", DataFim = "2026-06-02", Tamanho = 260.0f, NomeLocal = "Espaço Premier III", Valor = 3700.00f, Descricao = "Salão com estrutura moderna e climatização total" },
            new Reserva { Id = 48, DataInicio = "2026-06-08", DataFim = "2026-06-09", Tamanho = 220.0f, NomeLocal = "Salão Bella Vista", Valor = 3050.00f, Descricao = "Ambiente com vista panorâmica e decoração elegante" },
            new Reserva { Id = 49, DataInicio = "2026-06-15", DataFim = "2026-06-16", Tamanho = 300.0f, NomeLocal = "Espaço Garden Palace", Valor = 4400.00f, Descricao = "Espaço ao ar livre com jardim e salão coberto" },
            new Reserva { Id = 50, DataInicio = "2026-06-25", DataFim = "2026-06-26", Tamanho = 200.0f, NomeLocal = "Salão Crystal Garden", Valor = 2900.00f, Descricao = "Espaço integrado com área verde e iluminação natural" },
            new Reserva { Id = 51, DataInicio = "2026-07-02", DataFim = "2026-07-03", Tamanho = 270.0f, NomeLocal = "Espaço Celebration II", Valor = 3500.00f, Descricao = "Ambiente moderno com pista de dança e iluminação LED" },
            new Reserva { Id = 52, DataInicio = "2026-07-09", DataFim = "2026-07-10", Tamanho = 230.0f, NomeLocal = "Salão Harmonia IV", Valor = 3200.00f, Descricao = "Espaço climatizado ideal para casamentos e formaturas" },
            new Reserva { Id = 53, DataInicio = "2026-07-15", DataFim = "2026-07-16", Tamanho = 250.0f, NomeLocal = "Espaço Real II", Valor = 3400.00f, Descricao = "Ambiente sofisticado com palco e cozinha equipada" },
            new Reserva { Id = 54, DataInicio = "2026-07-23", DataFim = "2026-07-24", Tamanho = 190.0f, NomeLocal = "Salão Bela Festa II", Valor = 2700.00f, Descricao = "Espaço aconchegante e climatizado para festas pequenas" },
            new Reserva { Id = 55, DataInicio = "2026-08-01", DataFim = "2026-08-02", Tamanho = 280.0f, NomeLocal = "Espaço Platinum II", Valor = 4100.00f, Descricao = "Ambiente moderno com palco e área VIP" },
            new Reserva { Id = 56, DataInicio = "2026-08-08", DataFim = "2026-08-09", Tamanho = 220.0f, NomeLocal = "Salão Diamante II", Valor = 3300.00f, Descricao = "Espaço elegante e climatizado com estacionamento" },
            new Reserva { Id = 57, DataInicio = "2026-08-15", DataFim = "2026-08-16", Tamanho = 300.0f, NomeLocal = "Espaço Golden II", Valor = 4500.00f, Descricao = "Salão luxuoso com iluminação cenográfica" },
            new Reserva { Id = 58, DataInicio = "2026-08-22", DataFim = "2026-08-23", Tamanho = 240.0f, NomeLocal = "Salão Allegro II", Valor = 3100.00f, Descricao = "Ambiente moderno com decoração contemporânea" },
            new Reserva { Id = 59, DataInicio = "2026-08-30", DataFim = "2026-08-31", Tamanho = 270.0f, NomeLocal = "Espaço Roma II", Valor = 3600.00f, Descricao = "Decoração clássica e ambiente climatizado" },
            new Reserva { Id = 60, DataInicio = "2026-09-06", DataFim = "2026-09-07", Tamanho = 290.0f, NomeLocal = "Salão Elite II", Valor = 4300.00f, Descricao = "Espaço premium com estrutura completa" },
            new Reserva { Id = 61, DataInicio = "2026-09-14", DataFim = "2026-09-15", Tamanho = 210.0f, NomeLocal = "Espaço Bela Vista II", Valor = 3000.00f, Descricao = "Ambiente com vista panorâmica e área verde" },
            new Reserva { Id = 62, DataInicio = "2026-09-22", DataFim = "2026-09-23", Tamanho = 260.0f, NomeLocal = "Salão Villa Real II", Valor = 3500.00f, Descricao = "Ambiente rústico e climatizado para eventos" },
            new Reserva { Id = 63, DataInicio = "2026-09-30", DataFim = "2026-10-01", Tamanho = 300.0f, NomeLocal = "Espaço Mirante II", Valor = 4400.00f, Descricao = "Vista panorâmica e estacionamento privativo" },
            new Reserva { Id = 64, DataInicio = "2026-10-07", DataFim = "2026-10-08", Tamanho = 250.0f, NomeLocal = "Salão Diamantina II", Valor = 3300.00f, Descricao = "Espaço elegante e climatizado" },
            new Reserva { Id = 65, DataInicio = "2026-10-15", DataFim = "2026-10-16", Tamanho = 270.0f, NomeLocal = "Espaço Golden Hall", Valor = 4000.00f, Descricao = "Ambiente moderno com palco e iluminação profissional" },
            new Reserva { Id = 66, DataInicio = "2026-10-22", DataFim = "2026-10-23", Tamanho = 230.0f, NomeLocal = "Salão Crystal Palace", Valor = 3200.00f, Descricao = "Espaço sofisticado com jardim externo" },
            new Reserva { Id = 67, DataInicio = "2026-10-29", DataFim = "2026-10-30", Tamanho = 280.0f, NomeLocal = "Espaço Bella Arte II", Valor = 3700.00f, Descricao = "Ambiente elegante com decoração temática" },
            new Reserva { Id = 68, DataInicio = "2026-11-05", DataFim = "2026-11-06", Tamanho = 240.0f, NomeLocal = "Salão Imperial III", Valor = 3500.00f, Descricao = "Ambiente nobre e climatizado" },
            new Reserva { Id = 69, DataInicio = "2026-11-12", DataFim = "2026-11-13", Tamanho = 300.0f, NomeLocal = "Espaço Premier IV", Valor = 4400.00f, Descricao = "Espaço completo com iluminação e som integrados" },
            new Reserva { Id = 70, DataInicio = "2026-11-20", DataFim = "2026-11-21", Tamanho = 220.0f, NomeLocal = "Salão Harmonia V", Valor = 3100.00f, Descricao = "Ambiente acolhedor e climatizado" },
            new Reserva { Id = 71, DataInicio = "2026-11-28", DataFim = "2026-11-29", Tamanho = 260.0f, NomeLocal = "Espaço Bella Luna II", Valor = 3400.00f, Descricao = "Ambiente moderno e sofisticado" },
            new Reserva { Id = 72, DataInicio = "2026-12-05", DataFim = "2026-12-06", Tamanho = 270.0f, NomeLocal = "Salão Garden Hall II", Valor = 3900.00f, Descricao = "Espaço ao ar livre com cobertura retrátil" },
            new Reserva { Id = 73, DataInicio = "2026-12-12", DataFim = "2026-12-13", Tamanho = 300.0f, NomeLocal = "Espaço Viva Eventos II", Valor = 4200.00f, Descricao = "Salão versátil com pista de dança" },
            new Reserva { Id = 74, DataInicio = "2026-12-20", DataFim = "2026-12-21", Tamanho = 190.0f, NomeLocal = "Salão Estilo & Festa II", Valor = 2800.00f, Descricao = "Ambiente moderno e climatizado" },
            new Reserva { Id = 75, DataInicio = "2027-01-08", DataFim = "2027-01-09", Tamanho = 300.0f, NomeLocal = "Espaço Harmonia VI", Valor = 4500.00f, Descricao = "Salão amplo e luxuoso" },
            new Reserva { Id = 76, DataInicio = "2027-01-15", DataFim = "2027-01-16", Tamanho = 220.0f, NomeLocal = "Salão Riviera III", Valor = 3200.00f, Descricao = "Ambiente clean e sofisticado" },
            new Reserva { Id = 77, DataInicio = "2027-01-22", DataFim = "2027-01-23", Tamanho = 280.0f, NomeLocal = "Espaço Diamante III", Valor = 4000.00f, Descricao = "Ambiente climatizado com iluminação profissional" },
            new Reserva { Id = 78, DataInicio = "2027-01-29", DataFim = "2027-01-30", Tamanho = 250.0f, NomeLocal = "Salão Bella Vista III", Valor = 3300.00f, Descricao = "Espaço elegante com vista panorâmica" },
            new Reserva { Id = 79, DataInicio = "2027-02-05", DataFim = "2027-02-06", Tamanho = 290.0f, NomeLocal = "Espaço Golden III", Valor = 4300.00f, Descricao = "Salão de alto padrão com palco e camarim" },
            new Reserva { Id = 80, DataInicio = "2027-02-12", DataFim = "2027-02-13", Tamanho = 230.0f, NomeLocal = "Salão Crystal III", Valor = 3100.00f, Descricao = "Ambiente moderno e climatizado" },
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