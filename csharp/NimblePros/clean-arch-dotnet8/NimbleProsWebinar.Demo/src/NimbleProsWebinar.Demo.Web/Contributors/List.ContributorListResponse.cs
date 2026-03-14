using NimbleProsWebinar.Demo.Web.ContributorEndpoints;

namespace NimbleProsWebinar.Demo.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
