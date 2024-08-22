using MyFinance.Core.Domains.BaseDomain;

namespace MyFinance.Core.Domains;

public class MetaFinanceira : Base
{
    public string descricao { get; private set; } = string.Empty;
    public decimal valor { get; private set; } = decimal.Zero;
    public decimal valorProgresso { get; private set; } = decimal.Zero;
    public DateTime dataDefinicao { get; set; } = DateTime.MinValue;
    public DateTime dataLimite { get; set; } = DateTime.MinValue;
    public List<Transacao> transacoes { get; set; } = new List<Transacao>();
}
