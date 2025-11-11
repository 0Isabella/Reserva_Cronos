using Microsoft.EntityFrameworkCore;

namespace ApiLivros.Models
{
    public class ReservasContext : DbContext
    {
        public ReservasContext(DbContextOptions<ReservasContext> options) : base(options) { }

        public DbSet<Reserva> Reservas { get; set; }
    }
}
