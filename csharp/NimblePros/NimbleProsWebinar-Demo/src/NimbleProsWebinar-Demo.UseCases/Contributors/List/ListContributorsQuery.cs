using Ardalis.Result;
using Ardalis.SharedKernel;

namespace NimbleProsWebinar_Demo.UseCases.Contributors.List;

public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
