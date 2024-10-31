namespace MyFinance.Core.Entities;

public class Conta : Base
{
    public string Nome { get; private set; } = string.Empty;
    public string Cpf { get; private set; } = string.Empty;
    public string Tipo { get; private set; } = string.Empty;
    public string InstituicaoFinanceira { get; private set; } = string.Empty;
    public decimal Saldo { get; private set; } = decimal.Zero;
    public List<Transacao> Transacoes { get; set; } = new List<Transacao>();

    public Conta() { }

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

        public static Result<Guid> ExcluirConta(string id, string nome, string cpf, string tipo, string instituicaoFinanceira, decimal saldo)
        {
            if (string.IsNullOrWhiteSpace(id))
                return Result.Failure<Guid>("O ID não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(cpf))
                return Result.Failure<Guid>("O cpf não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(tipo))
                return Result.Failure<Guid>("O tipo da conta não pode ser vazio.");

            if (string.IsNullOrWhiteSpace(instituicaoFinanceira))
                return Result.Failure<Guid>("A instituição financeira não pode ser vazia.");

            if (saldo != 0)
                return Result.Failure<Guid>("O saldo tem que ser negativo.");

            Conta conta = new Conta();
            conta.Nome = nome;
            conta.Tipo = tipo;
            conta.InstituicaoFinanceira = instituicaoFinanceira;
            conta.Saldo = saldo;

            return Result.Success(conta.Id);
        }
    }
}
