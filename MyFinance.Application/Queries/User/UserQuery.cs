﻿using CSharpFunctionalExtensions;
using MediatR;
using MyFinance.Application.ViewModels.User;

namespace MyFinance.Application.Queries.User;

public class UserQuery : IRequest<Result<UserVm>>
{
}