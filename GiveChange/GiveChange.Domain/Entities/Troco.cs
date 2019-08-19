namespace GiveChange.Domain.Entities
{
    public class Troco
    {
        public int Id { get; private set; }
        public string NomeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorTroco { get; set; }

    }
}
