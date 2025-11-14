namespace CronosReserva.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string Nome {get; set; }        
        public string Telefone {get; set;}
        public DateOnly DataInicio { get; set; }
        public int DiasAlugados { get; set; }
        public Tamanho Tamanho { get; set; }
        public string NomeLocal { get; set; }
        public float ValorTotal { get; set; }
        public string Descricao { get; set; }
    }

    public enum Tamanho
    {
        Pequeno,
        Medio,
        Grande
    }
}