namespace MyFinance.Core.Entities;

public class MetaFinanceira : Base
{
    public string Descricao { get; private set; } = string.Empty;
    public decimal Valor { get; private set; } = decimal.Zero;
    public decimal ValorProgresso { get; private set; } = decimal.Zero;
    public DateTime DataDefinicao { get; set; } = DateTime.MinValue;
    public DateTime DataLimite { get; set; } = DateTime.MinValue;
    public List<Transacao> Transacoes { get; set; } = new List<Transacao>();

    private MetaFinanceira() { }

    public static class MetaFinanceiraFactory
    {
        public static Result<MetaFinanceira> CriarMetaFinanceira(string descricao, decimal valor, decimal valorProgresso, DateTime dataDefinicao, DateTime dataLimite)
        {
            // Validação de dados
            if (string.IsNullOrWhiteSpace(descricao))
                return Result.Failure<MetaFinanceira>("A descrição da meta financeira não pode ser vazia.");

            if (valor <= 0)
                return Result.Failure<MetaFinanceira>("O valor da meta financeira deve ser maior que zero.");

            if (valorProgresso < 0)
                return Result.Failure<MetaFinanceira>("O valor de progresso não pode ser negativo.");

            if (dataDefinicao == DateTime.MinValue)
                return Result.Failure<MetaFinanceira>("A data de definição não pode ser a data mínima.");

            if (dataLimite == DateTime.MinValue)
                return Result.Failure<MetaFinanceira>("A data limite não pode ser a data mínima.");

            if (dataLimite < dataDefinicao)
                return Result.Failure<MetaFinanceira>("A data limite não pode ser anterior à data de definição.");

            var metaFinanceira = new MetaFinanceira
            {
                Id = Guid.NewGuid(),
                Descricao = descricao,
                Valor = valor,
                ValorProgresso = valorProgresso,
                DataDefinicao = dataDefinicao,
                DataLimite = dataLimite
            };

            return Result.Success(metaFinanceira);
        }
    }
}
