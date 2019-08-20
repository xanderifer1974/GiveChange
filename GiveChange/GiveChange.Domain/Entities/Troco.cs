namespace GiveChange.Domain.Entities
{
    public class Troco: Entidade
    {
        public int Id { get; private set; }
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public double ValorPago { get; set; }
        public double ValorTroco { get; set; }
        public int Nota100 { get; set; }
        public int Nota50 { get; set; }
        public int Nota20 { get; set; }
        public int Nota10 { get; set; }
        public int Moeda050 { get; set; }
        public int Moeda010 { get; set; }
        public int Moeda005 { get; set; }
        public int Moeda001 { get; set; }   

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
