namespace MyFinance.Core.Domains;

public class Conta : Base
{
    public string Nome { get; private set; } = string.Empty;
    public string Cpf { get; private set; } = string.Empty;
    public string Tipo { get; private set; } = string.Empty;
    public string InstituicaoFinanceira { get; private set; } = string.Empty;
    public decimal Saldo { get; private set; } = decimal.Zero;
    public List<Transacao> Transacoes { get; set; } = new List<Transacao>();

    private Conta() { }

    public static class ContaFactory
    {
        public static Result<Conta> CriarConta(string nome, string cpf, string tipo, string instituicaoFinanceira, decimal saldoInicial)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return Result.Failure<Conta>("O nome da conta não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(cpf))
                return Result.Failure<Conta>("O cpf não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(tipo))
                return Result.Failure<Conta>("O tipo da conta não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(instituicaoFinanceira))
                return Result.Failure<Conta>("A instituição financeira não pode ser vazia.");

            if (saldoInicial < 0)
                return Result.Failure<Conta>("O saldo inicial não pode ser negativo.");

            var conta = new Conta
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Cpf = cpf,
                Tipo = tipo,
                InstituicaoFinanceira = instituicaoFinanceira,
                Saldo = saldoInicial
            };

            return Result.Success(conta);
        }

        public static Result AtualizarConta(Conta conta, string nome, string cpf, string tipo, string instituicaoFinanceira, decimal saldo)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return Result.Failure("O nome da conta não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(cpf))
                return Result.Failure<Conta>("O cpf não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(tipo))
                return Result.Failure("O tipo da conta não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(instituicaoFinanceira))
                return Result.Failure("A instituição financeira não pode ser vazia.");

            if (saldo < 0)
                return Result.Failure("O saldo não pode ser negativo.");

            conta.Nome = nome;
            conta.Tipo = tipo;
            conta.InstituicaoFinanceira = instituicaoFinanceira;
            conta.Saldo = saldo;

            return Result.Success();
        }
    }
}
