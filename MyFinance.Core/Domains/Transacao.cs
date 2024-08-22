using MyFinance.Core.Domains.BaseDomain;

namespace MyFinance.Core.Domains;

public class Transacao : Base
{
    public string descricao { get; set; } = string.Empty;
    public DateTime data { get; private set; } = DateTime.MinValue;
    public string tipo { get; private set; } = string.Empty;
    public decimal valor { get; private set; } = decimal.Zero;
    public string formaPagamento { get; set; } = string.Empty;
    public Conta conta { get; set; } = new Conta();
    public CategoriaTransacao categoria { get; set; } = new CategoriaTransacao();
}
