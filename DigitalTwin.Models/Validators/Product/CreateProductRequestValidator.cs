using DigitalTwin.Models.MediatRPipeline;
using DigitalTwin.Models.Requests.Product;
using FluentValidation;

namespace DigitalTwin.Models.Validators.Product;

public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductRequestValidator()
    {
        RuleFor(_ => _.Name)
            .Must(value => !string.IsNullOrEmpty(value))
            .WithMessage("Product's name is not null");
    }
}