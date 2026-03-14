using NimbleProsWebinar_Demo.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace NimbleProsWebinar_Demo.Web.Endpoints.ContributorEndpoints;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class CreateContributorValidator : Validator<CreateContributorRequest>
{
  public CreateContributorValidator()
  {
    RuleFor(x => x.Name)
      .NotEmpty()
      .WithMessage("Name is required.")
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
  }
}
