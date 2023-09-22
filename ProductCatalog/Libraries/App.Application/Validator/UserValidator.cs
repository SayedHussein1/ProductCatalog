using App.Application.Interfaces;
using App.Application.Model;

using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Validator
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator(ILocaleStringResourceSevices localizationService)
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"));

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"));
          //  RuleFor(x => x.RoleName).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"));
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"))
                .EmailAddress().WithMessage(localizationService.GetResource("EmailFaild"));
            RuleFor(x => x.Password).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"))
                .MaximumLength(6).WithMessage(localizationService.GetResource("PasswordWorng"));
            RuleFor(x => x.ConfirmPassword).Equal(s => s.Password).WithMessage(localizationService.GetResource("ConfirmPasswordWorng"));
        }
    }
}
