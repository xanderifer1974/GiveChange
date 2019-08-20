namespace GiveChange.Domain.Entities
{
    public class Troco: Entidade
    {
        public int Id { get; private set; }
        public string NomeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorTroco { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(NomeProduto))
            {
                AdicionarCritica("Crítica - Nome do Produto deve estar preenchido.");
            }
            if (PrecoProduto <= 0)
            {
                AdicionarCritica("Crítica - Preço do Produto deve ser maior que 0.");
            }

            if (ValorPago <=  0)
            {
                AdicionarCritica("Crítica - Valor pago deve ser maior que 0.");
            }

            if (ValorPago <= 0)
            {
                AdicionarCritica("Crítica - Valor pago deve ser maior que 0.");
            }

            if (ValorPago < PrecoProduto)
            {
                AdicionarCritica("Crítica - Valor pago não pode ser menor que preço do produto.");
            }
        }
    }
}
