namespace MyFinance.Core.Domains;

public class SubCategoriaTransacao : Base
{
    public string Nome { get; private set; } = string.Empty;
    public Guid CategoriaTransacaoId { get; set; } = Guid.Empty;
    public CategoriaTransacao Categoria { get; set; } = new CategoriaTransacao();
}
