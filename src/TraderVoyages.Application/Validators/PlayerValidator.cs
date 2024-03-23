// src/TraderVoyages.Application/Validators/PlayerValidator.cs
using FluentValidation;
using TraderVoyages.Application.DTOs;

namespace TraderVoyages.Application.Validators
{
    public class PlayerValidator : AbstractValidator<PlayerDTO>
    {
        public PlayerValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name is required.");
        }
    }
}
