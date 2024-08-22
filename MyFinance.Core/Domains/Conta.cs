using MyFinance.Core.Domains.BaseDomain;
using MyFinance.Core.Enums;
using System.Globalization;

namespace MyFinance.Core.Domains;

public class Conta : Base
{
    public string Nome { get; private set; } = string.Empty;
    public string Tipo { get; private set; } = string.Empty;
    public string InstituicaoFinanceira { get; private set; } = string.Empty;
    public decimal Saldo { get; private set; } = decimal.Zero;
    public List<Transacao> Transacoes { get; set; } = new List<Transacao>();
}
