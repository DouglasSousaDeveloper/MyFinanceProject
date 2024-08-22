using MyFinance.Core.Domains.BaseDomain;

namespace MyFinance.Core.Domains;

public class SubCategoriaTransacao : Base
{
    public string nome { get; private set; } = string.Empty;
}
