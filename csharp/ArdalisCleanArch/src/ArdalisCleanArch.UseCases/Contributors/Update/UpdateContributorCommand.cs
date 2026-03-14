using ArdalisCleanArch.Core.ContributorAggregate;

namespace ArdalisCleanArch.UseCases.Contributors.Update;

public record UpdateContributorCommand(ContributorId ContributorId, ContributorName NewName) : ICommand<Result<ContributorDto>>;
