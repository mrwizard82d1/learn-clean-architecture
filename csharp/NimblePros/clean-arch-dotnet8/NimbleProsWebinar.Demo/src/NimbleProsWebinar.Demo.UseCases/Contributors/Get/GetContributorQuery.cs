using Ardalis.Result;
using Ardalis.SharedKernel;

namespace NimbleProsWebinar.Demo.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
