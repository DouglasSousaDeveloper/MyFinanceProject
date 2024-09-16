namespace MyFinance.Core.Domains;

public class User : Base
{
    public string Nome { get; set; } = string.Empty;
    public Conta Conta { get; set; } = new Conta();
}
