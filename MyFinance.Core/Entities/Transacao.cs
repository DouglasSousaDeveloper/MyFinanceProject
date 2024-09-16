namespace MyFinance.Core.Domains;

public class Transacao : Base
{
    public string Descricao { get; set; } = string.Empty;
    public DateTime Data { get; private set; } = DateTime.MinValue;
    public string Tipo { get; private set; } = string.Empty;
    public decimal Valor { get; private set; } = decimal.Zero;
    public string FormaPagamento { get; set; } = string.Empty;

    public Guid ContaId { get; set; } = Guid.Empty;
    public Conta Conta { get; set; } = new Conta();

    public Guid CategoriaId { get; set; } = Guid.Empty;
    public CategoriaTransacao Categoria { get; set; } = new CategoriaTransacao();
}
