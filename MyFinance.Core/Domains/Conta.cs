using MyFinance.Core.Domains.BaseDomain;
using System.Globalization;

namespace MyFinance.Core.Domains;

public class Conta : Base
{
    public string nome { get; private set; } = string.Empty;
    public string tipo { get; private set; } = string.Empty;
    public string instituicaoFinanceira { get; private set; } = string.Empty;
    public decimal saldo { get; private set; } = decimal.Zero;
    public List<Transacao> transacoes { get; set; } = new List<Transacao>();

    public string historicoTransacoes { get; set; } //TODO: implementar a parte   

    public string BuscarSaldo()
    {
        var cultura = new CultureInfo("pt-BR");

        return saldo.ToString("C", cultura);
    }
}
