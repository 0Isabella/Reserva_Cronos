// Program.cs
using CronosReserva.Routes;
using CronosReserva.Models; // Importa o namespace para acessar Database e Reserva

var builder = WebApplication.CreateBuilder(args);

// Configura serializador JSON para suportar DateOnly
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.PropertyNameCaseInsensitive = true;
});

// Adiciona o serviço CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            // Permite requisições de qualquer origem (necessário para testes locais)
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Usa a política CORS definida
app.UseCors("AllowAll");

// Habilita serviço de arquivos estáticos
app.UseStaticFiles();

// 1. Inicializa os dados de exemplo do Database.cs
// Isso garante que Database.Reservas não esteja vazia ao iniciar.
Database.Dados();

// 2. Mapeia todas as rotas da sua aplicação (GET, POST, PUT, DELETE)
app.MapGetRoutes();
app.MapPostRoutes();
app.MapPutRoutes();
app.MapDeleteRoutes();

app.Run();