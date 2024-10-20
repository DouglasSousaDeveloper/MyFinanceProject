using Microsoft.EntityFrameworkCore;

namespace MyFinance.Application.Context;

public class MyFinanceContext : DbContext
{
    public MyFinanceContext(DbContextOptions<MyFinanceContext> options) : base(options)
    {
    }

    public DbSet<CategoriaTransacao> CategoryTransaction { get; set; }
    public DbSet<Conta> Account { get; set; }
    public DbSet<Divida> Debt { get; set; }
    public DbSet<MetaFinanceira> FinancialGoal { get; set; }
    public DbSet<SubCategoriaTransacao> SubCategoryTransaction { get; set; }
    public DbSet<Transacao> Transaction { get; set; }
    public DbSet<Usuario> User { get; set; }
}
