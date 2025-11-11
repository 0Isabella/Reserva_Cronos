using Microsoft.EntityFrameworkCore;

namespace CronosReserva.Models
{
    public class ReservasContext : DbContext
    {
        public ReservasContext(DbContextOptions<ReservasContext> options) : base(options) { }

        public DbSet<Reserva> Reservas { get; set; }
    }
}
