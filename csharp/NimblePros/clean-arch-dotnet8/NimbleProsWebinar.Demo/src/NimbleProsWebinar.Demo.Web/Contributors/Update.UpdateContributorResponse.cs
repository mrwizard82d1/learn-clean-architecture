using NimbleProsWebinar.Demo.Web.ContributorEndpoints;

namespace NimbleProsWebinar.Demo.Web.Endpoints.ContributorEndpoints;

public class UpdateContributorResponse
{
  public UpdateContributorResponse(ContributorRecord contributor)
  {
    Contributor = contributor;
  }
  public ContributorRecord Contributor { get; set; }
}
