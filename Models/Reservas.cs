namespace CronosReferencia.Models
{

    public class Reserva
        {
            public int Id { get; set; }
            public string DataInicio { get; set; }
            public string DataFim { get; set; } 
            public float Tamanho { get; set; }
            public string NomeLocal { get; set; }
            public float Valor{ get; set; } 
            public string Descricao { get; set; }
        }
}