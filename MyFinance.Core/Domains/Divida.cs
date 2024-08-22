using MyFinance.Core.Domains.BaseDomain;

namespace MyFinance.Core.Domains;

public class Divida : Base
{
    public string descricao { get; set; } = string.Empty;
    public DateTime data { get; set; } = DateTime.MinValue;
    public DateTime dataValidade { get; set; } = DateTime.MinValue;
}
