using NimbleProsWebinar_Demo.Web.ContributorEndpoints;

namespace NimbleProsWebinar_Demo.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
