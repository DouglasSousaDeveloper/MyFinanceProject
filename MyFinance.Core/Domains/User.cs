using MyFinance.Core.Domains.BaseDomain;

namespace MyFinance.Core.Domains;

public class User : Base
{
    public string nome { get; set; } = string.Empty;
    public Conta conta { get; set; } = new Conta();
}
