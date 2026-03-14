using ArdalisCleanArch.Core.ContributorAggregate;

namespace ArdalisCleanArch.UseCases.Contributors.Get;

public record GetContributorQuery(ContributorId ContributorId) : IQuery<Result<ContributorDto>>;
