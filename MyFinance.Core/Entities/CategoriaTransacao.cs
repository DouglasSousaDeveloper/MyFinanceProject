namespace MyFinance.Core.Domains;

public class CategoriaTransacao : Base
{
    public string Nome { get; private set; } = string.Empty;
    public ICollection<SubCategoriaTransacao> SubCategoria { get; set; } = new Collection<SubCategoriaTransacao>();

    public static class CategoriaTransacaoFactory
    {
        public static Result<CategoriaTransacao> CriarCategoria(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return Result.Failure<CategoriaTransacao>("O nome da categoria não pode ser vazio.");

            var categoria = new CategoriaTransacao
            {
                Id = Guid.NewGuid(),
                Nome = nome
            };

            return Result.Success(categoria);
        }
    }
}