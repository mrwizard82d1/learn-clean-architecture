using NimblePros.WebinarDemo.Web.ContributorEndpoints;

namespace NimblePros.WebinarDemo.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
