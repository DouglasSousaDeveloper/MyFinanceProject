namespace MyFinance.Core.Domains;

public class SubCategoriaTransacao : Base
{
    public string Nome { get; private set; } = string.Empty;
    public Guid CategoriaTransacaoId { get; set; } = Guid.Empty;
    public CategoriaTransacao Categoria { get; set; }

    private SubCategoriaTransacao() { }

    public static class SubCategoriaTransacaoFactory
    {
        public static Result<SubCategoriaTransacao> CriarSubCategoria(string nome, Guid categoriaTransacaoId)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return Result.Failure<SubCategoriaTransacao>("O nome da subcategoria não pode ser vazio.");

            if (categoriaTransacaoId == Guid.Empty)
                return Result.Failure<SubCategoriaTransacao>("A categoria de transação deve ser válida.");

            var subCategoria = new SubCategoriaTransacao
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                CategoriaTransacaoId = categoriaTransacaoId
            };

            return Result.Success(subCategoria);
        }
    }
}
