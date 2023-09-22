using App.Application.Interfaces;
using App.Application.Model;

using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Validator
{
    public class CategoryValidator : AbstractValidator<CategoryModel>
    {
        public CategoryValidator(ILocaleStringResourceSevices localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"));
        }
    }
}
