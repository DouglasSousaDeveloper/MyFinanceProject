using MyFinance.Core.Domains.BaseDomain;
using System.Collections.ObjectModel;

namespace MyFinance.Core.Domains;

public class CategoriaTransacao : Base
{
    public string Nome { get; private set; } = string.Empty;
    public ICollection<SubCategoriaTransacao> SubCategoria { get; set; } = new Collection<SubCategoriaTransacao>();
}