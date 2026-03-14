using ArdalisCleanArch.Core.ContributorAggregate;

namespace ArdalisCleanArch.UseCases.Contributors;
public record ContributorDto(ContributorId Id, ContributorName Name, PhoneNumber PhoneNumber);
