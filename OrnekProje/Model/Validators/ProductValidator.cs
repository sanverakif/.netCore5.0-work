using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Model.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("boş olamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("doğru email giriniz");

            RuleFor(x => x.ProductName).NotNull().WithMessage("ürünü boş geçme");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("100 karakterden fazla girme");
        }
    }
}
