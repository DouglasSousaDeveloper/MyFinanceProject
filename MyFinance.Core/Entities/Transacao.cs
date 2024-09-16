namespace MyFinance.Core.Domains;

public class Transacao : Base
{
    public string Descricao { get; set; } = string.Empty;
    public DateTime Data { get; private set; } = DateTime.MinValue;
    public string Tipo { get; private set; } = string.Empty;
    public decimal Valor { get; private set; } = decimal.Zero;
    public string FormaPagamento { get; set; } = string.Empty;

    public Guid ContaId { get; set; } = Guid.Empty;
    public Conta Conta { get; set; }

    public Guid CategoriaId { get; set; } = Guid.Empty;
    public CategoriaTransacao Categoria { get; set; }

    private Transacao() { }

    public static class TransacaoFactory
    {
        public static Result<Transacao> CriarTransacao(string descricao, DateTime data, string tipo, decimal valor, string formaPagamento, Guid contaId, Guid categoriaId)
        {
            // Validação de dados
            if (string.IsNullOrWhiteSpace(descricao))
                return Result.Failure<Transacao>("A descrição da transação não pode ser vazia.");

            if (data == DateTime.MinValue)
                return Result.Failure<Transacao>("A data da transação não pode ser a data mínima.");

            if (string.IsNullOrWhiteSpace(tipo))
                return Result.Failure<Transacao>("O tipo da transação não pode ser vazio.");

            if (valor <= 0)
                return Result.Failure<Transacao>("O valor da transação deve ser maior que zero.");

            if (contaId == Guid.Empty)
                return Result.Failure<Transacao>("A conta associada deve ser válida.");

            if (categoriaId == Guid.Empty)
                return Result.Failure<Transacao>("A categoria associada deve ser válida.");

            var transacao = new Transacao
            {
                Id = Guid.NewGuid(),
                Descricao = descricao,
                Data = data,
                Tipo = tipo,
                Valor = valor,
                FormaPagamento = formaPagamento,
                ContaId = contaId,
                CategoriaId = categoriaId
            };

            return Result.Success(transacao);
        }
    }
}
