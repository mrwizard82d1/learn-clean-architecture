using ArdalisCleanArch.Core.ContributorAggregate;

namespace ArdalisCleanArch.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;
