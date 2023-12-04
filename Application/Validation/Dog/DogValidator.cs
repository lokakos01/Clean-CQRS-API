using Application.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.Dog
{
    public class DogValidator : AbstractValidator<DogDto>
    {
        public DogValidator()
        {
            RuleFor(dog => dog.Name)
            .NotEmpty().WithMessage("Dog name can nor be empty brate")
            .NotNull().WithMessage("Dog name can not be null broski");
        }
    }
}
