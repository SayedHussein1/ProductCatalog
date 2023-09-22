using App.Application.Interfaces;
using App.Application.Model;

using FluentValidation;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Validator
{
    public class ProductsValidator : AbstractValidator<ProductsModel>
    {
        public ProductsValidator(ILocaleStringResourceSevices localizationService)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"));
            RuleFor(x => x.ShortDescription).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"));
            RuleFor(x => x.FullDescription).NotEmpty().WithMessage(localizationService.GetResource("FieldRequired"));
            RuleFor(x => x.ImageId).InclusiveBetween(1, int.MaxValue).WithMessage(localizationService.GetResource("FieldRequired"));
            RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage(localizationService.GetResource("FieldRequired"));
        }
    }
}
