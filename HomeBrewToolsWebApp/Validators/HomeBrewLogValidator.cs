using FluentValidation;
using HomeBrewToolsWebApp.Models;
using System.Text.RegularExpressions;

namespace HomeBrewToolsWebApp.Validators
{
    public class HomeBrewLogValidator : AbstractValidator<HomeBrewLog>
    {
        public HomeBrewLogValidator()
        {
            // Validation rule for only alpha characters and spaces using a regular experession.
            // No numbers or special characters
            RuleFor(h => h.Type).Matches("^[A-Za-z ]+$")
                                .WithMessage("No numbers or special characters");

            // Validation rule to ensure field is not empty
            RuleFor(h => h.StartDate).NotEmpty()
                                     .WithMessage("Can not be empty");

            // Validation rule to ensure field is not empty and that number matches 1.111 decimal format
            // using a regular expression
            RuleFor(h => h.StartingGravity).NotEmpty()
                                           .Must(decimalValue => Regex.IsMatch(decimalValue.ToString(), @"^\d\.?\d{3}$"))
                                           .WithMessage("The decimal should have the format 1.111");



        }
        
    }
}
