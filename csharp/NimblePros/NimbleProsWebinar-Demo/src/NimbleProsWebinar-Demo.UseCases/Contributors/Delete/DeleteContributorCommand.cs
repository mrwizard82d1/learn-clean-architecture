using Ardalis.Result;
using Ardalis.SharedKernel;

namespace NimbleProsWebinar_Demo.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
