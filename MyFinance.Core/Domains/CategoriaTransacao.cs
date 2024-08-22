using MyFinance.Core.Domains.BaseDomain;

namespace MyFinance.Core.Domains;

public class CategoriaTransacao : Base
{
    public string nome { get; private set; } = string.Empty;
    public SubCategoriaTransacao SubCategoria { get; set; } = new SubCategoriaTransacao();
}
