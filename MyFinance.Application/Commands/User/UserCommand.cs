using CSharpFunctionalExtensions;
using MediatR;
using MyFinance.Application.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace MyFinance.Application.Commands.User;

public class UserCommand : IRequest<Result<UserVm>>
{
    #region Validate
    [Required(ErrorMessage = "O Nome é obrigatório.")]
    #endregion
    public string name { get; set; }

    #region Validate
    [Required(ErrorMessage = "A Idade é obrigatório.")]
    #endregion
    public int idade { get; set; }

    #region Validate
    [Required(ErrorMessage = "O CEP é obrigatório.")]
    [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP deve ter exatamente 8 dígitos.")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve conter apenas números.")]
    #endregion
    public string cep { get; set; }
}
