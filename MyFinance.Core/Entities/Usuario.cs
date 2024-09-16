namespace MyFinance.Core.Domains;

public class Usuario : Base
{
    public string NomeCompleto { get; private set; } = string.Empty;
    public int Idade { get; private set; }
    public Conta Conta { get; set; }

    private Usuario(){}

    public static class UserFactory
    {
        public static Result<Usuario> CriarUser(string nomeCompleto, int idade, Conta conta)
        {
            if (string.IsNullOrWhiteSpace(nomeCompleto))
                return Result.Failure<Usuario>("O nome completo não pode ser vazio.");

            if (idade < 0)
                return Result.Failure<Usuario>("A idade não pode ser negativa.");

            if (conta is null)
                return Result.Failure<Usuario>("A conta associada deve ser válida.");

            var user = new Usuario
            {
                Id = Guid.NewGuid(),
                NomeCompleto = nomeCompleto,
                Idade = idade,
                Conta = conta
            };

            return Result.Success(user);
        }
    }
}
