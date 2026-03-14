using Ardalis.Result;
using Ardalis.SharedKernel;

namespace NimbleProsWebinar.Demo.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
