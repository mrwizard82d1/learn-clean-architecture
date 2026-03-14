using Ardalis.Result;
using Ardalis.SharedKernel;

namespace NimblePros.WebinarDemo.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
