using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() 
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.CategoryId).NotNull();
        }
    }
}
