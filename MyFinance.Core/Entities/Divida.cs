namespace MyFinance.Core.Domains;

public class Divida : Base
{
    public string Descricao { get; set; } = string.Empty;
    public DateTime Data { get; set; } = DateTime.MinValue;
    public DateTime DataValidade { get; set; } = DateTime.MinValue;
}
