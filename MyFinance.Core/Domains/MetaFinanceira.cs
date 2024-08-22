using MyFinance.Core.Domains.BaseDomain;

namespace MyFinance.Core.Domains;

public class MetaFinanceira : Base
{
    public string Descricao { get; private set; } = string.Empty;
    public decimal Valor { get; private set; } = decimal.Zero;
    public decimal ValorProgresso { get; private set; } = decimal.Zero;
    public DateTime DataDefinicao { get; set; } = DateTime.MinValue;
    public DateTime DataLimite { get; set; } = DateTime.MinValue;
    public List<Transacao> Transacoes { get; set; } = new List<Transacao>();
}
