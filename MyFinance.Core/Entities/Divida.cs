namespace MyFinance.Core.Domains;

public class Divida : Base
{
    public string Descricao { get; set; } = string.Empty;
    public DateTime Data { get; set; } = DateTime.MinValue;
    public DateTime DataValidade { get; set; } = DateTime.MinValue;

    private Divida() { }

    public static class DividaFactory
    {
        public static Result<Divida> CriarDivida(string descricao, DateTime data, DateTime dataValidade)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                return Result.Failure<Divida>("A descrição da dívida não pode ser vazia.");

            if (data == DateTime.MinValue)
                return Result.Failure<Divida>("A data da dívida não pode ser a data mínima.");

            if (dataValidade == DateTime.MinValue)
                return Result.Failure<Divida>("A data de validade da dívida não pode ser a data mínima.");

            if (dataValidade < data)
                return Result.Failure<Divida>("A data de validade não pode ser anterior à data da dívida.");

            var divida = new Divida
            {
                Id = Guid.NewGuid(),
                Descricao = descricao,
                Data = data,
                DataValidade = dataValidade
            };

            return Result.Success(divida);
        }
    }
}
