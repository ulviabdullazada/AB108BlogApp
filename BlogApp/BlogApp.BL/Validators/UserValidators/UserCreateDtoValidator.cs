﻿using BlogApp.BL.DTOs.UserDtos;
using BlogApp.Core.Repositories;
using FluentValidation;
using FluentValidation.Validators;

namespace BlogApp.BL.Validators.UserValidators;
public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
{
    readonly IUserRepository _repo;
    public UserCreateDtoValidator(IUserRepository repo)
    {

        _repo = repo;
        RuleFor(x => x.Email)
            .NotEmpty()
            .NotNull()
            .EmailAddress();
        RuleFor(x => x.Username)
            .NotNull()
            .NotEmpty()
            .Must(x =>_repo.GetByUserNameAsync(x).Result == null)
                .WithMessage("Username exist");
    }
}
