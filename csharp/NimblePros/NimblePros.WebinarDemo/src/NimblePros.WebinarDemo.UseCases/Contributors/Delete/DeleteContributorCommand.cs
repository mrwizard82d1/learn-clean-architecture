using Ardalis.Result;
using Ardalis.SharedKernel;

namespace NimblePros.WebinarDemo.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
