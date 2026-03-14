using NimbleProsWebinar_Demo.Web.ContributorEndpoints;

namespace NimbleProsWebinar_Demo.Web.Endpoints.ContributorEndpoints;

public class UpdateContributorResponse
{
  public UpdateContributorResponse(ContributorRecord contributor)
  {
    Contributor = contributor;
  }
  public ContributorRecord Contributor { get; set; }
}
