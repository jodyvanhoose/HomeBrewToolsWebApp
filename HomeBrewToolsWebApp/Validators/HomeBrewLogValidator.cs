using FluentValidation;
using HomeBrewToolsWebApp.Models;
using System.Text.RegularExpressions;

namespace HomeBrewToolsWebApp.Validators
{
    public class HomeBrewLogValidator : AbstractValidator<HomeBrewLog>
    {
        public HomeBrewLogValidator()
        {
            RuleFor(h => h.Type).Matches("^[A-Za-z ]+$")
                                .WithMessage("No numbers or special characters");

            RuleFor(h => h.StartDate).NotEmpty()
                                     .WithMessage("Cannont be empty");

            RuleFor(h => h.StartingGravity).NotEmpty()
                                           .Must(decimalValue => Regex.IsMatch(decimalValue.ToString(), @"^\d\.?\d{3}$"))
                                           .WithMessage("The decimal should have the format 1.111");
        }
    }
}
