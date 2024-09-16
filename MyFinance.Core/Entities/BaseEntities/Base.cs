namespace MyFinance.Core.Domains.BaseEntities;

public class Base
{
    public Guid Id { get; protected set; } = Guid.Empty;
}
