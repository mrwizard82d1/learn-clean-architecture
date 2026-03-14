using NimblePros.WebinarDemo.Web.ContributorEndpoints;

namespace NimblePros.WebinarDemo.Web.Endpoints.ContributorEndpoints;

public class UpdateContributorResponse
{
  public UpdateContributorResponse(ContributorRecord contributor)
  {
    Contributor = contributor;
  }
  public ContributorRecord Contributor { get; set; }
}
